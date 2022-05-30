namespace Tilia.Interactions.Controllables.LinearDriver
{
    using Tilia.Interactions.Controllables.Driver;
    using UnityEngine;
    using Zinnia.Data.Attribute;
    using Zinnia.Data.Type;
    using Zinnia.Data.Type.Transformation;
    using Zinnia.Extension;
    using Zinnia.Tracking.Modification;

    /// <summary>
    /// A directional drive that manipulates a <see cref="Transform.position"/> to control the linear translation movement without the use of any physics.
    /// </summary>
    public class LinearTransformDrive : LinearDrive
    {
        #region Reference Settings
        [Header("Reference Settings")]
        [Tooltip("The Vector3Restrictor to clamp the position of the drive within the drive limits.")]
        [SerializeField]
        [Restricted]
        private Vector3Restrictor positionClamper;
        /// <summary>
        /// The <see cref="Vector3Restrictor"/> to clamp the position of the drive within the drive limits.
        /// </summary>
        public Vector3Restrictor PositionClamper
        {
            get
            {
                return positionClamper;
            }
            protected set
            {
                positionClamper = value;
            }
        }
        [Tooltip("The TransformPropertyApplier to automatically move the drive to a specific location.")]
        [SerializeField]
        [Restricted]
        private TransformPropertyApplier propertyApplier;
        /// <summary>
        /// The <see cref="TransformPropertyApplier"/> to automatically move the drive to a specific location.
        /// </summary>
        public TransformPropertyApplier PropertyApplier
        {
            get
            {
                return propertyApplier;
            }
            protected set
            {
                propertyApplier = value;
            }
        }
        #endregion

        /// <summary>
        /// The position to automatically move the drive to.
        /// </summary>
        private readonly TransformData autoDrivePosition = new TransformData();

        /// <inheritdoc />
        public override void Process()
        {
            if (!this.IsValidState())
            {
                return;
            }

            ConfigureAutoDrive(Facade.MoveToTargetValue);
            base.Process();
        }

        /// <inheritdoc />
        public override Vector3 CalculateDriveAxis(DriveAxis.Axis driveAxis)
        {
            if (!this.IsValidState())
            {
                return default;
            }

            PositionClamper.XBounds = driveAxis == DriveAxis.Axis.XAxis ? DriveLimits : default;
            PositionClamper.YBounds = driveAxis == DriveAxis.Axis.YAxis ? DriveLimits : default;
            PositionClamper.ZBounds = driveAxis == DriveAxis.Axis.ZAxis ? DriveLimits : default;

            return -base.CalculateDriveAxis(driveAxis);
        }

        /// <inheritdoc />
        public override void ProcessDriveSpeed(float driveSpeed, bool moveToTargetValue)
        {
            if (!this.IsValidState())
            {
                return;
            }

            PropertyApplier.TransitionDuration = driveSpeed.ApproxEquals(0f) ? 0f : 1f / driveSpeed;
            PropertyApplier.enabled = moveToTargetValue;
            if (PropertyApplier.enabled)
            {
                if (Interactable.Configuration.ConsumerRigidbody != null)
                {
                    Interactable.Configuration.ConsumerRigidbody.velocity = Vector3.zero;
                }
                PropertyApplier.Apply();
            }
        }

        /// <inheritdoc />
        protected override Transform GetDriveTransform()
        {
            return Interactable.transform;
        }

        /// <inheritdoc />
        protected override void SetDriveTargetValue(Vector3 targetValue)
        {
            autoDrivePosition.UseLocalValues = true;
            autoDrivePosition.Transform = GetDriveTransform();
            autoDrivePosition.PositionOverride = targetValue;
            PropertyApplier.Source = autoDrivePosition;
            PropertyApplier.Apply();
        }
    }
}