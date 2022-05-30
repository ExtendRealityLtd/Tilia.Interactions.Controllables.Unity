namespace Tilia.Interactions.Controllables.Driver
{
    using Tilia.Interactions.Interactables.Interactables;
    using UnityEngine;
    using Zinnia.Data.Attribute;
    using Zinnia.Data.Type;
    using Zinnia.Event.Proxy;
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
        [Header("Reference Settings")]
        [Tooltip("The public interface facade.")]
        [SerializeField]
        [Restricted]
        private TFacade facade;
        /// <summary>
        /// The public interface facade.
        /// </summary>
        public TFacade Facade
        {
            get
            {
                return facade;
            }
            protected set
            {
                facade = value;
            }
        }
        [Tooltip("The GameObject containing the output event actions.")]
        [SerializeField]
        [Restricted]
        private GameObject eventOutputContainer;
        /// <summary>
        /// The <see cref="GameObject"/> containing the output event actions.
        /// </summary>
        public GameObject EventOutputContainer
        {
            get
            {
                return eventOutputContainer;
            }
            protected set
            {
                eventOutputContainer = value;
            }
        }
        [Tooltip("The GameObject containing the snap to step logic.")]
        [SerializeField]
        [Restricted]
        private GameObject snapToStepContainer;
        /// <summary>
        /// The <see cref="GameObject"/> containing the snap to step logic.
        /// </summary>
        public GameObject SnapToStepContainer
        {
            get
            {
                return snapToStepContainer;
            }
            protected set
            {
                snapToStepContainer = value;
            }
        }
        [Tooltip("The Float Emitter for handling grabbed drag.")]
        [SerializeField]
        [Restricted]
        private FloatEventProxyEmitter grabbedDragEmitter;
        /// <summary>
        /// The Float Emitter for handling grabbed drag.
        /// </summary>
        public FloatEventProxyEmitter GrabbedDragEmitter
        {
            get
            {
                return grabbedDragEmitter;
            }
            protected set
            {
                grabbedDragEmitter = value;
            }
        }
        [Tooltip("The Float Emitter for handling ungrabbed drag.")]
        [SerializeField]
        [Restricted]
        private FloatEventProxyEmitter ungrabbedDragEmitter;
        /// <summary>
        /// The Float Emitter for handling ungrabbed drag.
        /// </summary>
        public FloatEventProxyEmitter UngrabbedDragEmitter
        {
            get
            {
                return ungrabbedDragEmitter;
            }
            protected set
            {
                ungrabbedDragEmitter = value;
            }
        }
        [Tooltip("The InteractableFacade that controls the movement of the drive.")]
        [SerializeField]
        [Restricted]
        private InteractableFacade interactable;
        /// <summary>
        /// The <see cref="InteractableFacade"/> that controls the movement of the drive.
        /// </summary>
        public InteractableFacade Interactable
        {
            get
            {
                return interactable;
            }
            protected set
            {
                interactable = value;
            }
        }
        [Tooltip("The GameObject that contains the meshes for the control.")]
        [SerializeField]
        [Restricted]
        private GameObject interactableMesh;
        /// <summary>
        /// The <see cref="GameObject"/> that contains the meshes for the control.
        /// </summary>
        public GameObject InteractableMesh
        {
            get
            {
                return interactableMesh;
            }
            protected set
            {
                interactableMesh = value;
            }
        }
        #endregion

        #region Drive Settings
        [Header("Drive Settings")]
        [Tooltip("Whether to reset the drive data when the SetUp method is executed.")]
        [SerializeField]
        private bool resetDriveOnSetup = true;
        /// <summary>
        /// Whether to reset the drive data when the <see cref="SetUp"/> method is executed.
        /// </summary>
        public bool ResetDriveOnSetup
        {
            get
            {
                return resetDriveOnSetup;
            }
            set
            {
                resetDriveOnSetup = value;
            }
        }
        [Tooltip("Whether to set the ResetDriveOnSetup property back to false after the SetUp method has executed to prevent future automatic resets until the value is manually changed again.")]
        [SerializeField]
        private bool resetDriveOnSetupFirstTimeOnly = true;
        /// <summary>
        /// Whether to set the <see cref="ResetDriveOnSetup"/> property back to <see cref="false"/> after the <see cref="SetUp"/> method has executed to prevent future automatic resets until the value is manually changed again.
        /// </summary>
        public bool ResetDriveOnSetupFirstTimeOnly
        {
            get
            {
                return resetDriveOnSetupFirstTimeOnly;
            }
            set
            {
                resetDriveOnSetupFirstTimeOnly = value;
            }
        }
        [Tooltip("Determines whether the drive is grabbable and whether it can be moved.")]
        [SerializeField]
        private bool isGrabbable = true;
        /// <summary>
        /// Determines whether the drive is grabbable and whether it can be moved.
        /// </summary>
        public bool IsGrabbable
        {
            get
            {
                return isGrabbable;
            }
            set
            {
                isGrabbable = value;
                if (this.IsMemberChangeAllowed())
                {
                    OnAfterIsGrabbableChange();
                }
            }
        }
        [Tooltip("The value to set the drive speed to when driving the control to the initial start value.")]
        [SerializeField]
        private float initialValueDriveSpeed = 5000f;
        /// <summary>
        /// The value to set the drive speed to when driving the control to the initial start value.
        /// </summary>
        public float InitialValueDriveSpeed
        {
            get
            {
                return initialValueDriveSpeed;
            }
            set
            {
                initialValueDriveSpeed = value;
            }
        }
        [Tooltip("The color of the gizmo hinge location line.")]
        [SerializeField]
        private Color gizmoColor = Color.yellow;
        /// <summary>
        /// The color of the gizmo hinge location line.
        /// </summary>
        public Color GizmoColor
        {
            get
            {
                return gizmoColor;
            }
            set
            {
                gizmoColor = value;
            }
        }
        #endregion

        #region Target Settings
        [Header("Target Settings")]
        [Tooltip("The threshold that the current normalized value of the control can be within to consider the target value has been reached.")]
        [SerializeField]
        private float targetValueReachedThreshold = 0.025f;
        /// <summary>
        /// The threshold that the current normalized value of the control can be within to consider the target value has been reached.
        /// </summary>
        public float TargetValueReachedThreshold
        {
            get
            {
                return targetValueReachedThreshold;
            }
            set
            {
                targetValueReachedThreshold = value;
            }
        }
        [Tooltip("Determines whether to emit the drive events.")]
        [SerializeField]
        private bool emitEvents = true;
        /// <summary>
        /// Determines whether to emit the drive events.
        /// </summary>
        public bool EmitEvents
        {
            get
            {
                return emitEvents;
            }
            set
            {
                emitEvents = value;
            }
        }
        #endregion

        /// <summary>
        /// The current raw value for the drive control.
        /// </summary>
        public virtual float Value => CalculateValue(Facade.DriveAxis, DriveLimits);
        /// <summary>
        /// The current normalized value for the drive control between the set limits.
        /// </summary>
        public virtual float NormalizedValue => Mathf.InverseLerp(DriveLimits.minimum, DriveLimits.maximum, Value);
        /// <summary>
        /// The current step value for the drive control.
        /// </summary>
        public virtual float StepValue => CalculateStepValue(Facade);
        /// <summary>
        /// The current normalized step value for the drive control between the set step range.
        /// </summary>
        public virtual float NormalizedStepValue => Mathf.InverseLerp(Facade.StepRange.minimum, Facade.StepRange.maximum, StepValue);
        /// <summary>
        /// The calculated direction for the drive axis.
        /// </summary>
        public virtual Vector3 AxisDirection { get; protected set; }
        /// <summary>
        /// The calculated limits for the drive.
        /// </summary>
        public virtual FloatRange DriveLimits { get; protected set; }

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
        /// Whether this component has previously been disabled before the next process.
        /// </summary>
        protected bool wasDisabled;

        /// <summary>
        /// Configures the ability to automatically drive the control.
        /// </summary>
        /// <param name="autoDrive">Whether the drive can automatically drive the control.</param>
        public virtual void ConfigureAutoDrive(bool autoDrive) { }

        /// <summary>
        /// Sets up the drive mechanism.
        /// </summary>
        public virtual void SetUp()
        {
            if (!this.IsValidState())
            {
                return;
            }

            if (ResetDriveOnSetup)
            {
                ResetDrive();
            }

            SetUpInternals();
            SetDriveLimits();
            SetAxisDirection();
            ProcessDriveSpeed(Facade.DriveSpeed, Facade.MoveToTargetValue);
            SetTargetValue(Facade.TargetValue);
            ToggleSnapToStepLogic(Facade.SnapToStepOnRelease);
            ToggleGrabbaleState(IsGrabbable);
        }

        /// <summary>
        /// Processes the value changes and emits the appropriate events.
        /// </summary>
        public virtual void Process()
        {
            if (!this.IsValidState())
            {
                return;
            }

            if (wasDisabled || !Value.ApproxEquals(previousValue))
            {
                EmitStartMoving();
            }
            else
            {
                EmitStopMoving();
            }

            CheckStepValueChange();
            CheckTargetValueReached();

            wasDisabled = false;
        }

        /// <summary>
        /// Toggles the state of the <see cref="SnapToStepContainer"/>.
        /// </summary>
        public virtual void ToggleSnapToStepLogic(bool state)
        {
            if (!this.IsValidState() || SnapToStepContainer == null)
            {
                return;
            }

            SnapToStepContainer.SetActive(state);
        }

        /// <summary>
        /// Sets the <see cref="DriveLimits"/> based on the <see cref="Facade"/> drive limit settings.
        /// </summary>
        public virtual void SetDriveLimits()
        {
            if (!this.IsValidState())
            {
                return;
            }

            DriveLimits = CalculateDriveLimits(Facade);
        }

        /// <summary>
        /// Sets the <see cref="AxisDirection"/> based on the <see cref="Facade.DriveAxis"/> value.
        /// </summary>
        public virtual void SetAxisDirection()
        {
            if (!this.IsValidState())
            {
                return;
            }

            AxisDirection = CalculateDriveAxis(Facade.DriveAxis);
        }

        /// <summary>
        /// Sets the grabbed drag value.
        /// </summary>
        /// <param name="value">The drag value.</param>
        public virtual void SetGrabbedDrag(float value)
        {
            if (!this.IsValidState() || GrabbedDragEmitter == null)
            {
                return;
            }

            GrabbedDragEmitter.Payload = value;
        }

        /// <summary>
        /// Sets the ungrabbed drag value.
        /// </summary>
        /// <param name="value">The drag value.</param>
        public virtual void SetUngrabbedDrag(float value)
        {
            if (!this.IsValidState() || UngrabbedDragEmitter == null)
            {
                return;
            }

            UngrabbedDragEmitter.Payload = value;
        }

        /// <summary>
        /// Processes the speed in which the drive can affect the control.
        /// </summary>
        /// <param name="driveSpeed">The speed to drive the control at.</param>
        /// <param name="moveToTargetValue">Whether to allow the drive to automatically move the control to the desired target value.</param>
        public virtual void ProcessDriveSpeed(float driveSpeed, bool moveToTargetValue)
        {
            if (!this.IsValidState())
            {
                return;
            }
        }

        /// <summary>
        /// Sets the target value of the drive to the given normalized value.
        /// </summary>
        /// <param name="normalizedValue">The normalized value to set the Target Value to.</param>
        public virtual void SetTargetValue(float normalizedValue)
        {
            if (!this.IsValidState())
            {
                return;
            }

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
        /// Resets the drive back to any default settings.
        /// </summary>
        public virtual void ResetDrive()
        {
            if (!this.IsValidState())
            {
                return;
            }

            if (ResetDriveOnSetupFirstTimeOnly)
            {
                ResetDriveOnSetup = false;
            }
        }

        /// <summary>
        /// Toggles whether the drive can be grabbed or not.
        /// </summary>
        /// <param name="isLocked">Whether can be grabbed.</param>
        public virtual void ToggleGrabbaleState(bool isGrabbable)
        {
            if (isGrabbable)
            {
                AllowGrab();
            }
            else
            {
                PreventGrab();
            }
        }

        /// <summary>
        /// Prevents grabbing the drive.
        /// </summary>
        public virtual void PreventGrab()
        {
            if (!this.IsValidState() || Interactable == null)
            {
                return;
            }

            Interactable.DisableGrab();
        }

        /// <summary>
        /// Allows grabbing the drive.
        /// </summary>
        public virtual void AllowGrab()
        {
            if (!this.IsValidState() || Interactable == null)
            {
                return;
            }

            Interactable.EnableGrab();
        }

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

        protected virtual void OnDisable()
        {
            wasDisabled = true;
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
        /// Emits the drive start moving process.
        /// </summary>
        protected virtual void EmitStartMoving()
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

        /// <summary>
        /// Emits the drive stop moving process.
        /// </summary>
        protected virtual void EmitStopMoving()
        {
            if (isMoving)
            {
                EmitStoppedMoving();
                isMoving = false;
            }
        }

        /// <summary>
        /// Checks if the <see cref="StepValue"/> has changed.
        /// </summary>
        protected virtual void CheckStepValueChange()
        {
            if (!StepValue.ApproxEquals(previousStepValue))
            {
                previousStepValue = StepValue;
                EmitStepValueChanged();
            }
        }

        /// <summary>
        /// Checks if the target value has been reached.
        /// </summary>
        protected virtual void CheckTargetValueReached()
        {
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
            return Mathf.Round(Mathf.Lerp(facade.StepRange.minimum / facade.StepIncrement, facade.StepRange.maximum / facade.StepIncrement, NormalizedValue)) * facade.StepIncrement;
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
            Facade.DriveSpeed = InitialValueDriveSpeed;
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

        /// <summary>
        /// Called after <see cref="IsGrabbable"/> has been changed.
        /// </summary>
        protected virtual void OnAfterIsGrabbableChange()
        {
            ToggleGrabbaleState(IsGrabbable);
        }
    }
}