namespace Tilia.Interactions.Controllables.Driver
{
    using System;
    using UnityEngine;
    using UnityEngine.Events;
    using Zinnia.Data.Attribute;
    using Zinnia.Data.Type;
    using Zinnia.Extension;

    /// <summary>
    /// Defines the event with the drive <see cref="float"/> value.
    /// </summary>
    [Serializable]
    public class DriveUnityEvent : UnityEvent<float>
    {
    }

    /// <summary>
    /// The basis of the public interface that will drive a control in relation to a specified world axis.
    /// </summary>
    /// <typeparam name="TDrive">The <see cref="Drive{TFacade, TSelf}"/> to operate with the facade.</typeparam>
    /// <typeparam name="TSelf">The actual concrete implementation of the drive facade being used.</typeparam>
    public abstract class DriveFacade<TDrive, TSelf> : MonoBehaviour where TDrive : Drive<TSelf, TDrive> where TSelf : DriveFacade<TDrive, TSelf>
    {
        #region Reference Settings
        [Header("Reference Settings")]
        [Tooltip("The linked TDrive")]
        [SerializeField]
        [Restricted]
        private TDrive drive;
        /// <summary>
        /// The linked <see cref="TDrive"/>
        /// </summary>
        public TDrive Drive
        {
            get
            {
                return drive;
            }
            protected set
            {
                drive = value;
            }
        }
        [Tooltip("The GameObject reference for the nested Interactable.")]
        [SerializeField]
        private ObjectReference linkedInteractableFacade;
        /// <summary>
        /// The <see cref="GameObject"/> reference for the nested Interactable.
        /// </summary>
        public ObjectReference LinkedInteractableFacade
        {
            get
            {
                return linkedInteractableFacade;
            }
            protected set
            {
                linkedInteractableFacade = value;
            }
        }
        [Tooltip("The GameObject reference for the nested minimum value reached event.")]
        [SerializeField]
        private ObjectReference linkedMinReached;
        /// <summary>
        /// The <see cref="GameObject"/> reference for the nested minimum value reached event.
        /// </summary>
        public ObjectReference LinkedMinReached
        {
            get
            {
                return linkedMinReached;
            }
            protected set
            {
                linkedMinReached = value;
            }
        }
        [Tooltip("The GameObject reference for the nested mid point value reached event.")]
        [SerializeField]
        private ObjectReference linkedMidReached;
        /// <summary>
        /// The <see cref="GameObject"/> reference for the nested mid point value reached event.
        /// </summary>
        public ObjectReference LinkedMidReached
        {
            get
            {
                return linkedMidReached;
            }
            protected set
            {
                linkedMidReached = value;
            }
        }
        [Tooltip("The GameObject reference for the nested max value reached event.")]
        [SerializeField]
        private ObjectReference linkedMaxReached;
        /// <summary>
        /// The <see cref="GameObject"/> reference for the nested max value reached event.
        /// </summary>
        public ObjectReference LinkedMaxReached
        {
            get
            {
                return linkedMaxReached;
            }
            protected set
            {
                linkedMaxReached = value;
            }
        }
        #endregion

        #region Events
        /// <summary>
        /// Emitted when the raw value changes with the raw value data.
        /// </summary>
        [Header("Events")]
        public DriveUnityEvent ValueChanged = new DriveUnityEvent();
        /// <summary>
        /// Emitted when the step value changes with the step value data.
        /// </summary>
        public DriveUnityEvent StepValueChanged = new DriveUnityEvent();
        /// <summary>
        /// Emitted when the normalized value changes with the normalized value data.
        /// </summary>
        public DriveUnityEvent NormalizedValueChanged = new DriveUnityEvent();
        /// <summary>
        /// Emitted when <see cref="InitialTargetValue"/> has been reached by the control.
        /// </summary>
        public DriveUnityEvent InitialTargetValueReached = new DriveUnityEvent();
        /// <summary>
        /// Emitted when <see cref="TargetValue"/> has been reached by the control.
        /// </summary>
        public DriveUnityEvent TargetValueReached = new DriveUnityEvent();
        /// <summary>
        /// Emitted when the drive starts moving the control.
        /// </summary>
        public DriveUnityEvent StartedMoving = new DriveUnityEvent();
        /// <summary>
        /// Emitted when the drive is no longer moving the control and it is stationary.
        /// </summary>
        public DriveUnityEvent StoppedMoving = new DriveUnityEvent();
        #endregion

        #region Drive Settings
        [Header("Drive Settings")]
        [Tooltip("The axis to operate the drive motion on.")]
        [SerializeField]
        private DriveAxis.Axis driveAxis = Driver.DriveAxis.Axis.XAxis;
        /// <summary>
        /// The axis to operate the drive motion on.
        /// </summary>
        public DriveAxis.Axis DriveAxis
        {
            get
            {
                return driveAxis;
            }
            set
            {
                driveAxis = value;
                if (this.IsMemberChangeAllowed())
                {
                    OnAfterDriveAxisChange();
                }
            }
        }
        [Tooltip("The speed in which the drive will attempt to move the control to the desired value.")]
        [SerializeField]
        private float driveSpeed = 10f;
        /// <summary>
        /// The speed in which the drive will attempt to move the control to the desired value.
        /// </summary>
        public float DriveSpeed
        {
            get
            {
                return driveSpeed;
            }
            set
            {
                driveSpeed = value;
                if (this.IsMemberChangeAllowed())
                {
                    OnAfterDriveSpeedChange();
                }
            }
        }
        #endregion

        #region Drag Settings
        [Header("Drag Settings")]
        [Tooltip("The drag to apply when the control is ungrabbed.")]
        [SerializeField]
        private float ungrabbedDrag = 0f;
        /// <summary>
        /// The drag to apply when the control is ungrabbed.
        /// </summary>
        public float UngrabbedDrag
        {
            get
            {
                return ungrabbedDrag;
            }
            set
            {
                ungrabbedDrag = value;
                if (this.IsMemberChangeAllowed())
                {
                    OnAfterUngrabbedDragChange();
                }
            }
        }
        [Tooltip("The drag to apply when the control is grabbed.")]
        [SerializeField]
        private float grabbedDrag = 0f;
        /// <summary>
        /// The drag to apply when the control is grabbed.
        /// </summary>
        public float GrabbedDrag
        {
            get
            {
                return grabbedDrag;
            }
            set
            {
                grabbedDrag = value;
                if (this.IsMemberChangeAllowed())
                {
                    OnAfterGrabbedDragChange();
                }
            }
        }
        #endregion

        #region Target Value Settings
        [Header("Target Value Settings")]
        [Tooltip("Determines if the drive should start the control at the InitialTargetValue when it is first enabled (no events will be emitted).")]
        [SerializeField]
        private bool startAtInitialTargetValue;
        /// <summary>
        /// Determines if the drive should start the control at the <see cref="InitialTargetValue"/> when it is first enabled (no events will be emitted).
        /// </summary>
        public bool StartAtInitialTargetValue
        {
            get
            {
                return startAtInitialTargetValue;
            }
            set
            {
                startAtInitialTargetValue = value;
            }
        }
        [Tooltip("The normalized value to attempt to drive the control to when it is first enabled.")]
        [SerializeField]
        [Range(0f, 1f)]
        private float initialTargetValue = 0.5f;
        /// <summary>
        /// The normalized value to attempt to drive the control to when it is first enabled.
        /// </summary>
        public float InitialTargetValue
        {
            get
            {
                return initialTargetValue;
            }
            set
            {
                initialTargetValue = value;
            }
        }
        [Tooltip("Determines if the drive should move the element to the set TargetValue.")]
        [SerializeField]
        private bool moveToTargetValue;
        /// <summary>
        /// Determines if the drive should move the element to the set <see cref="TargetValue"/>.
        /// </summary>
        public bool MoveToTargetValue
        {
            get
            {
                return moveToTargetValue;
            }
            set
            {
                moveToTargetValue = value;
                if (this.IsMemberChangeAllowed())
                {
                    OnAfterMoveToTargetValueChange();
                }
            }
        }
        [Tooltip("The normalized value to attempt to drive the control to if the MoveToTargetValue is set to true.")]
        [SerializeField]
        [Range(0f, 1f)]
        private float targetValue = 0.5f;
        /// <summary>
        /// The normalized value to attempt to drive the control to if the <see cref="MoveToTargetValue"/> is set to <see langword="true"/>.
        /// </summary>
        public float TargetValue
        {
            get
            {
                return targetValue;
            }
            set
            {
                targetValue = value;
                if (this.IsMemberChangeAllowed())
                {
                    OnAfterTargetValueChange();
                }
            }
        }
        #endregion

        #region Step Settings
        [Header("Step Settings")]
        [Tooltip("The range of step values to use.")]
        [SerializeField]
        private FloatRange stepRange = new FloatRange(0f, 10f);
        /// <summary>
        /// The range of step values to use.
        /// </summary>
        public FloatRange StepRange
        {
            get
            {
                return stepRange;
            }
            set
            {
                stepRange = value;
                if (this.IsMemberChangeAllowed())
                {
                    OnAfterStepRangeChange();
                }
            }
        }
        [Tooltip("The increment to increase the steps in value by.")]
        [SerializeField]
        private float stepIncrement = 1f;
        /// <summary>
        /// The increment to increase the steps in value by.
        /// </summary>
        public float StepIncrement
        {
            get
            {
                return stepIncrement;
            }
            set
            {
                stepIncrement = value;
                if (this.IsMemberChangeAllowed())
                {
                    OnAfterStepIncrementChange();
                }
            }
        }
        [Tooltip("The increment to increase the steps in value by.")]
        [SerializeField]
        private bool snapToStepOnRelease;
        /// <summary>
        /// Attempt to snap to the step value upon releasing the control.
        /// </summary>
        public bool SnapToStepOnRelease
        {
            get
            {
                return snapToStepOnRelease;
            }
            set
            {
                snapToStepOnRelease = value;
                if (this.IsMemberChangeAllowed())
                {
                    OnAfterSnapToStepOnRelease();
                }
            }
        }
        #endregion

        /// <summary>
        /// Sets <see cref="DriveAxis"/>.
        /// </summary>
        /// <param name="axisIndex">The index of the <see cref="DriveAxis.Axis"/>.</param>
        public virtual void SetDriveAxis(int axisIndex)
        {
            DriveAxis = EnumExtensions.GetByIndex<DriveAxis.Axis>(axisIndex);
        }

        /// <summary>
        /// Sets the <see cref="StepRange"/> minimum value.
        /// </summary>
        /// <param name="value">The new minimum value.</param>
        public virtual void SetStepRangeMinimum(float value)
        {
            FloatRange newLimit = new FloatRange(StepRange.ToVector2());
            newLimit.minimum = value;
            StepRange = newLimit;
        }

        /// <summary>
        /// Sets the <see cref="StepRange"/> maximum value.
        /// </summary>
        /// <param name="value">The new maximum value.</param>
        public virtual void SetStepRangeMaximum(float value)
        {
            FloatRange newLimit = new FloatRange(StepRange.ToVector2());
            newLimit.maximum = value;
            StepRange = newLimit;
        }

        /// <summary>
        /// Sets the <see cref="TargetValue"/> to the position that the current step value represents.
        /// </summary>
        public virtual void SetTargetValueByStepValue()
        {
            SetTargetValueByStepValue(Drive.StepValue);
        }

        /// <summary>
        /// Sets the <see cref="TargetValue"/> to the position that the given step value represents.
        /// </summary>
        /// <param name="stepValue">The step value that represents the new target value.</param>
        public virtual void SetTargetValueByStepValue(float stepValue)
        {
            float normalizedStepValue = Mathf.InverseLerp(StepRange.minimum, StepRange.maximum, Mathf.Clamp(stepValue, StepRange.minimum, StepRange.maximum));
            TargetValue = normalizedStepValue;
        }

        /// <summary>
        /// Forces the drive to move to the current step value at the given speed.
        /// </summary>
        /// <param name="driveSpeed">The speed the drive will move the control at.</param>
        public virtual void ForceSnapToStepValue(float driveSpeed)
        {
            MoveToTargetValue = true;
            DriveSpeed = driveSpeed;
            SetTargetValueByStepValue();
        }

        /// <summary>
        /// Calculates the axis to use for the given <see cref="DriveAxis.Axis"/>.
        /// </summary>
        /// <param name="driveAxis">The new value.</param>
        protected virtual void CalculateDriveAxis(DriveAxis.Axis driveAxis)
        {
            Drive.CalculateDriveAxis(driveAxis);
        }

        /// <summary>
        /// Processes the drive's ability to automatically drive the control.
        /// </summary>
        /// <param name="autoDrive">Whether the drive can automatically drive the control.</param>
        protected virtual void ProcessAutoDrive(bool autoDrive)
        {
            Drive.ConfigureAutoDrive(autoDrive);
        }

        /// <summary>
        /// Sets the new <see cref="TargetValue"/>.
        /// </summary>
        /// <param name="targetValue">The new value.</param>
        protected virtual void SetTargetValue(float targetValue)
        {
            Drive.SetTargetValue(targetValue);
        }

        /// <summary>
        /// Processes the changes to the <see cref="DriveSpeed"/>.
        /// </summary>
        /// <param name="driveSpeed">The new value.</param>
        /// <param name="moveToTargetValue">Whether the new value should be processed.</param>
        protected virtual void ProcessDriveSpeed(float driveSpeed, bool moveToTargetValue)
        {
            Drive.ProcessDriveSpeed(driveSpeed, moveToTargetValue);
        }

        /// <summary>
        /// Called after <see cref="DriveAxis"/> has been changed.
        /// </summary>
        protected virtual void OnAfterDriveAxisChange()
        {
            Drive.ResetDriveOnSetup = true;
            Drive.SetUp();
        }

        /// <summary>
        /// Called after <see cref="MoveToTargetValue"/> has been changed.
        /// </summary>
        protected virtual void OnAfterMoveToTargetValueChange()
        {
            Drive.SetUp();
        }

        /// <summary>
        /// Called after <see cref="TargetValue"/> has been changed.
        /// </summary>
        protected virtual void OnAfterTargetValueChange()
        {
            Drive.SetUp();
        }

        /// <summary>
        /// Called after <see cref="DriveSpeed"/> has been changed.
        /// </summary>
        protected virtual void OnAfterDriveSpeedChange()
        {
            Drive.SetUp();
        }

        /// <summary>
        /// Called after <see cref="StepRange"/> has been changed.
        /// </summary>
        protected virtual void OnAfterStepRangeChange()
        {
            Drive.SetUp();
        }

        /// <summary>
        /// Called after <see cref="StepIncrement"/> has been changed.
        /// </summary>
        protected virtual void OnAfterStepIncrementChange()
        {
            Drive.SetUp();
        }

        /// <summary>
        /// Called after <see cref="SnapToStepOnRelease"/> has been changed.
        /// </summary>
        protected virtual void OnAfterSnapToStepOnRelease()
        {
            Drive.ToggleSnapToStepLogic(SnapToStepOnRelease);
        }

        /// <summary>
        /// Called after <see cref="UngrabbedDrag"/> has been changed.
        /// </summary>
        protected virtual void OnAfterUngrabbedDragChange()
        {
            drive.SetUngrabbedDrag(UngrabbedDrag);
        }

        /// <summary>
        /// Called after <see cref="GrabbedDrag"/> has been changed.
        /// </summary>
        protected virtual void OnAfterGrabbedDragChange()
        {
            drive.SetGrabbedDrag(GrabbedDrag);
        }
    }
}