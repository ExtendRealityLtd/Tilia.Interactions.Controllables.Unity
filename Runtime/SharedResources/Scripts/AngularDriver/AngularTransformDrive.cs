namespace Tilia.Interactions.Controllables.AngularDriver
{
    using Tilia.Interactions.Controllables.Driver;
    using UnityEngine;
    using Zinnia.Data.Attribute;
    using Zinnia.Data.Type;
    using Zinnia.Extension;
    using Zinnia.Tracking.Follow.Modifier.Property.Rotation;
    using Zinnia.Tracking.Velocity;

    /// <summary>
    /// A rotational drive that directly manipulates a <see cref="Transform.rotation"/> to control the rotational angle without the use of any physics.
    /// </summary>
    public class AngularTransformDrive : AngularDrive
    {
        #region Reference Settings
        [Header("Reference Settings")]
        [Tooltip("The TransformPositionDifferenceRotation to drive the rotation of the control.")]
        [SerializeField]
        [Restricted]
        private TransformPositionDifferenceRotation rotationModifier;
        /// <summary>
        /// The <see cref="TransformPositionDifferenceRotation"/> to drive the rotation of the control.
        /// </summary>
        public TransformPositionDifferenceRotation RotationModifier
        {
            get
            {
                return rotationModifier;
            }
            protected set
            {
                rotationModifier = value;
            }
        }
        [Tooltip("The ArtificialVelocityApplier that applies artificial angular velocity to the control after releasing.")]
        [SerializeField]
        [Restricted]
        private ArtificialVelocityApplier velocityApplier;
        /// <summary>
        /// The <see cref="ArtificialVelocityApplier"/> that applies artificial angular velocity to the control after releasing.
        /// </summary>
        public ArtificialVelocityApplier VelocityApplier
        {
            get
            {
                return velocityApplier;
            }
            protected set
            {
                velocityApplier = value;
            }
        }
        #endregion

        /// <inheritdoc />
        public override Vector3 CalculateDriveAxis(DriveAxis.Axis driveAxis)
        {
            if (!this.IsValidState())
            {
                return default;
            }

            Vector3 axisDirection = base.CalculateDriveAxis(driveAxis);
            switch (driveAxis)
            {
                case DriveAxis.Axis.XAxis:
                    RotationModifier.FollowOnAxis = Vector3State.XOnly;
                    break;
                case DriveAxis.Axis.YAxis:
                    RotationModifier.FollowOnAxis = Vector3State.YOnly;
                    break;
                case DriveAxis.Axis.ZAxis:
                    RotationModifier.FollowOnAxis = Vector3State.ZOnly;
                    break;
            }

            return axisDirection;
        }

        /// <inheritdoc />
        public override void CalculateHingeLocation(Vector3 newHingeLocation)
        {
            if (!this.IsValidState())
            {
                return;
            }

            transform.localPosition = newHingeLocation;
            InteractableMesh.transform.localPosition = newHingeLocation * -1f;
        }

        /// <inheritdoc />
        public override void ApplyExistingAngularVelocity(float multiplier = 1f)
        {
            VelocityApplier.AngularVelocity = AxisDirection * pseudoAngularVelocity * multiplier;
            VelocityApplier.Apply();
        }

        /// <inheritdoc />
        protected override void EliminateDriveVelocity()
        {
            VelocityApplier.Velocity = Vector3.zero;
            VelocityApplier.AngularVelocity = Vector3.zero;
        }

        /// <inheritdoc />
        protected override Transform GetDriveTransform()
        {
            return Interactable.transform;
        }

        /// <inheritdoc />
        protected override void AttemptApplyLimits()
        {
            if (ApplyLimits())
            {
                EliminateDriveVelocity();
            }
        }

        /// <inheritdoc />
        protected override void ProcessAutoDrive(float driveSpeed)
        {
            if (Facade.MoveToTargetValue && !driveSpeed.ApproxEquals(0f))
            {
                GetDriveTransform().localRotation *= Quaternion.Euler(-AxisDirection * driveSpeed * Time.deltaTime);
            }
        }
    }
}