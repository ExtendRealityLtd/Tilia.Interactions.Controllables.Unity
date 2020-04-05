namespace Tilia.Interactions.Controllables.Driver
{
    using Malimbe.BehaviourStateRequirementMethod;
    using Malimbe.PropertySerializationAttribute;
    using Malimbe.XmlDocumentationAttribute;
    using UnityEngine;
    using Zinnia.Data.Attribute;
    using Zinnia.Data.Type;
    using Zinnia.Extension;
    using Zinnia.Process;

    /// <summary>
    /// The basis for a mechanism to drive motion on a control.
    /// </summary>
    /// <typeparam name="TFacade">The <see cref="DriveFacade{TDrive, TSelf}"/> to be used with the drive.</typeparam>
    /// <typeparam name="TSelf">The actual concrete implementation of the drive being used.</typeparam>
    public abstract class Drive<TFacade, TSelf> : MonoBehaviour, IProcessable where TFacade : DriveFacade<TSelf, TFacade> where TSelf : Drive<TFacade, TSelf>
    {
        #region Reference Settings
        /// <summary>
        /// The public interface facade.
        /// </summary>
        [Serialized]
        [field: Header("Reference Settings"), DocumentedByXml, Restricted]
        public TFacade Facade { get; protected set; }
        /// <summary>
        /// The <see cref="GameObject"/> containing the output event actions.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml, Restricted]
        public GameObject EventOutputContainer { get; protected set; }
        #endregion

        #region Target Settings
        /// <summary>
        /// The threshold that the current normalized value of the control can be within to consider the target value has been reached.
        /// </summary>
        [Serialized]
        [field: Header("Target Settings"), DocumentedByXml]
        public float TargetValueReachedThreshold { get; set; } = 0.025f;
        /// <summary>
        /// Determines whether to emit the drive events.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml]
        public bool EmitEvents { get; set; } = true;
        #endregion

        /// <summary>
        /// The current raw value for the drive control.
        /// </summary>
        public float Value => CalculateValue(Facade.DriveAxis, DriveLimits);
        /// <summary>
        /// The current normalized value for the drive control between the set limits.
        /// </summary>
        public float NormalizedValue => Mathf.InverseLerp(DriveLimits.minimum, DriveLimits.maximum, Value);
        /// <summary>
        /// The current step value for the drive control.
        /// </summary>
        public float StepValue => CalculateStepValue(Facade);
        /// <summary>
        /// The current normalized step value for the drive control between the set step range.
        /// </summary>
        public float NormalizedStepValue => Mathf.InverseLerp(Facade.StepRange.minimum, Facade.StepRange.maximum, StepValue);
        /// <summary>
        /// The calculated direction for the drive axis.
        /// </summary>
        public Vector3 AxisDirection { get; protected set; }
        /// <summary>
        /// The calculated limits for the drive.
        /// </summary>
        public FloatRange DriveLimits { get; protected set; }

        /// <summary>
        /// The value to set the drive speed to when driving the control to the initial start value.
        /// </summary>
        protected const float initialValueDriveSpeed = 5000f;
        /// <summary>
        /// The previous state of <see cref="Value"/>.
        /// </summary>
        protected float previousValue = float.MaxValue;
        /// <summary>
        /// The previous state of <see cref="StepValue"/>.
        /// </summary>
        protected float previousStepValue = float.MaxValue;
        /// <summary>
        /// The previous state of whether the target value has been reached.
        /// </summary>
        protected bool previousTargetValueReached;
        /// <summary>
        /// Whether the control is moving or not.
        /// </summary>
        protected bool isMoving;
        /// <summary>
        /// Whether the drive is moving to the initial target value.
        /// </summary>
        protected bool isMovingToInitialTargetValue;
        /// <summary>
        /// The cached value for <see cref="EmitEvents"/>.
        /// </summary>
        protected bool cachedEmitEvents;
        /// <summary>
        /// The cached value for <see cref="MoveToTargetValue"/>.
        /// </summary>
        protected bool cachedMoveToTargetValue;
        /// <summary>
        /// The cached value for <see cref="TargetValue"/>.
        /// </summary>
        protected float cachedTargetValue;
        /// <summary>
        /// The cached value for <see cref="DriveSpeed"/>.
        /// </summary>
        protected float cachedDriveSpeed;

        /// <summary>
        /// Sets up the drive mechanism.
        /// </summary>
        public virtual void SetUp()
        {
            if (!Application.isPlaying)
            {
                return;
            }

            SetUpInternals();
            DriveLimits = CalculateDriveLimits(Facade);
            AxisDirection = CalculateDriveAxis(Facade.DriveAxis);
            ProcessDriveSpeed(Facade.DriveSpeed, Facade.MoveToTargetValue);
            SetTargetValue(Facade.TargetValue);
        }

        /// <summary>
        /// Processes the value changes and emits the appropriate events.
        /// </summary>
        [RequiresBehaviourState]
        public virtual void Process()
        {
            if (!Value.ApproxEquals(previousValue))
            {
                if (!isMoving && previousValue < float.MaxValue)
                {
                    EmitStartedMoving();
                    isMoving = true;
                }
                previousValue = Value;
                EmitValueChanged();
                EmitNormalizedValueChanged();
            }
            else
            {
                if (isMoving)
                {
                    EmitStoppedMoving();
                    isMoving = false;
                }
            }

            if (!StepValue.ApproxEquals(previousStepValue))
            {
                previousStepValue = StepValue;
                EmitStepValueChanged();
            }

            float targetValue = GetTargetValue();
            bool targetValueReached = NormalizedValue.ApproxEquals(targetValue, TargetValueReachedThreshold);
            bool shouldEmitEvent = !previousTargetValueReached && targetValueReached;
            previousTargetValueReached = targetValueReached;

            if (CanMoveToTargetValue() && shouldEmitEvent)
            {
                EmitTargetValueReached();
            }
        }

        /// <summary>
        /// Processes the speed in which the drive can affect the control.
        /// </summary>
        /// <param name="driveSpeed">The speed to drive the control at.</param>
        /// <param name="moveToTargetValue">Whether to allow the drive to automatically move the control to the desired target value.</param>
        public virtual void ProcessDriveSpeed(float driveSpeed, bool moveToTargetValue) { }

        /// <summary>
        /// Sets the target value of the drive to the given normalized value.
        /// </summary>
        /// <param name="normalizedValue">The normalized value to set the Target Value to.</param>
        [RequiresBehaviourState]
        public virtual void SetTargetValue(float normalizedValue)
        {
            SetDriveTargetValue(AxisDirection * Mathf.Lerp(DriveLimits.minimum, DriveLimits.maximum, Mathf.Clamp01(normalizedValue)));
        }

        /// <summary>
        /// Calculates the axis to drive the control on.
        /// </summary>
        /// <param name="driveAxis">The desired world axis.</param>
        /// <returns>The direction of the drive axis.</returns>
        public virtual Vector3 CalculateDriveAxis(DriveAxis.Axis driveAxis)
        {
            return driveAxis.GetAxisDirection(true);
        }

        /// <summary>
        /// Configures the ability to automatically drive the control.
        /// </summary>
        /// <param name="autoDrive">Whether the drive can automatically drive the control.</param>
        public virtual void ConfigureAutoDrive(bool autoDrive) { }

        /// <summary>
        /// Calculates the current value of the control.
        /// </summary>
        /// <param name="axis">The axis the drive is operating on.</param>
        /// <param name="limits">The limits of the drive.</param>
        /// <returns>The calculated value.</returns>
        protected abstract float CalculateValue(DriveAxis.Axis axis, FloatRange limits);
        /// <summary>
        /// Calculates the limits of the drive.
        /// </summary>
        /// <param name="facade">The facade containing the data for the calculation.</param>
        /// <returns>The minimum and maximum local space limit the drive can reach.</returns>
        protected abstract FloatRange CalculateDriveLimits(TFacade facade);
        /// <summary>
        /// Gets the <see cref="Transform"/> that the drive is operating on.
        /// </summary>
        /// <returns>The drive <see cref="Transform"/>.</returns>
        protected abstract Transform GetDriveTransform();

        protected virtual void OnEnable()
        {
            SetUp();
            MoveToInitialTargetValue();
        }

        /// <summary>
        /// Performs any required internal setup.
        /// </summary>
        protected virtual void SetUpInternals() { }

        /// <summary>
        /// Sets the target value of the drive.
        /// </summary>
        /// <param name="targetValue">The value to set the drive target to.</param>
        protected virtual void SetDriveTargetValue(Vector3 targetValue) { }

        /// <summary>
        /// Removes any velocity being applied to the drive.
        /// </summary>
        protected virtual void EliminateDriveVelocity() { }

        /// <summary>
        /// Gets the drive control target value.
        /// </summary>
        /// <returns>The target value specified in the facade.</returns>
        protected virtual float GetTargetValue()
        {
            return Facade.TargetValue;
        }

        /// <summary>
        /// Determines whether the drive can move the control to the target value.
        /// </summary>
        /// <returns>Whether the drive can automatically move to the target value specified in the facade.</returns>
        protected virtual bool CanMoveToTargetValue()
        {
            return Facade.MoveToTargetValue;
        }

        /// <summary>
        /// Calculates the current step value of the control.
        /// </summary>
        /// <param name="facade">The facade containing the data for the calculation.</param>
        /// <returns>The calculated step value.</returns>
        protected virtual float CalculateStepValue(TFacade facade)
        {
            return Mathf.Round(Mathf.Lerp(facade.StepRange.minimum / facade.StepIncrement, facade.StepRange.maximum / facade.StepIncrement, NormalizedValue));
        }

        /// <summary>
        /// Emits the ValueChanged event.
        /// </summary>
        protected virtual void EmitValueChanged()
        {
            if (!EmitEvents)
            {
                return;
            }

            Facade.ValueChanged?.Invoke(Value);
        }

        /// <summary>
        /// Emits the NormalizedValueChanged event.
        /// </summary>
        protected virtual void EmitNormalizedValueChanged()
        {
            if (isMovingToInitialTargetValue && NormalizedValue.ApproxEquals(Facade.InitialTargetValue, TargetValueReachedThreshold))
            {
                ResetToCacheAfterReachedInitialTargetValue();
                return;
            }

            if (!EmitEvents)
            {
                return;
            }

            Facade.NormalizedValueChanged?.Invoke(NormalizedValue);
        }

        /// <summary>
        /// Emits the StepValueChanged event.
        /// </summary>
        protected virtual void EmitStepValueChanged()
        {
            if (!EmitEvents)
            {
                return;
            }

            Facade.StepValueChanged?.Invoke(StepValue);
        }

        /// <summary>
        /// Emits the TargetValueReached event.
        /// </summary>
        protected virtual void EmitTargetValueReached()
        {
            if (!EmitEvents)
            {
                return;
            }

            Facade.TargetValueReached?.Invoke(NormalizedValue);
        }

        /// <summary>
        /// Emits the StartedMoving event.
        /// </summary>
        protected virtual void EmitStartedMoving()
        {
            if (!EmitEvents)
            {
                return;
            }

            Facade.StartedMoving?.Invoke(0f);
        }

        /// <summary>
        /// Emits the StoppedMoving event.
        /// </summary>
        protected virtual void EmitStoppedMoving()
        {
            if (!EmitEvents)
            {
                return;
            }

            Facade.StoppedMoving?.Invoke(0f);
        }

        /// <summary>
        /// Moves the drive to the initial target value.
        /// </summary>
        protected virtual void MoveToInitialTargetValue()
        {
            if (!Facade.StartAtInitialTargetValue)
            {
                return;
            }

            cachedEmitEvents = EmitEvents;
            cachedMoveToTargetValue = Facade.MoveToTargetValue;
            cachedTargetValue = Facade.TargetValue;
            cachedDriveSpeed = Facade.DriveSpeed;

            isMovingToInitialTargetValue = true;
            EmitEvents = false;
            Facade.MoveToTargetValue = true;
            Facade.TargetValue = Facade.InitialTargetValue;
            Facade.DriveSpeed = initialValueDriveSpeed;
            SetUp();
        }

        /// <summary>
        /// Resets the drive parameters to the cached values after the initial target value is reached.
        /// </summary>
        protected virtual void ResetToCacheAfterReachedInitialTargetValue()
        {
            EliminateDriveVelocity();
            isMovingToInitialTargetValue = false;
            EmitEvents = cachedEmitEvents;
            Facade.MoveToTargetValue = cachedMoveToTargetValue;
            Facade.TargetValue = cachedTargetValue;
            Facade.DriveSpeed = cachedDriveSpeed;
            SetUp();

            if (!EmitEvents)
            {
                return;
            }

            Facade.InitialTargetValueReached?.Invoke(NormalizedValue);
        }
    }
}