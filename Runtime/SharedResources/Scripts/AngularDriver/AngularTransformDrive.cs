namespace Tilia.Interactions.Controllables.AngularDriver
{
    using System.Collections.Generic;
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
        [Tooltip("A TransformPositionDifferenceRotation collection to drive the rotation of the control.")]
        [SerializeField]
        [Restricted]
        private List<TransformPositionDifferenceRotation> rotationModifiers = new List<TransformPositionDifferenceRotation>();
        /// <summary>
        /// A <see cref="TransformPositionDifferenceRotation"/> collection to drive the rotation of the control.
        /// </summary>
        public List<TransformPositionDifferenceRotation> RotationModifiers
        {
            get
            {
                return rotationModifiers;
            }
            protected set
            {
                rotationModifiers = value;
            }
        }
        [Tooltip("A RotateAroundAngularVelocity collection to drive the twist rotation of the control.")]
        [SerializeField]
        [Restricted]
        private List<RotateAroundAngularVelocity> twistRotationModifiers = new List<RotateAroundAngularVelocity>();
        /// <summary>
        /// A <see cref="RotateAroundAngularVelocity"/> collection to drive the twist rotation of the control.
        /// </summary>
        public List<RotateAroundAngularVelocity> TwistRotationModifiers
        {
            get
            {
                return twistRotationModifiers;
            }
            protected set
            {
                twistRotationModifiers = value;
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
            SetupRotationModifiers(driveAxis);
            SetupTwistRotationModifiers(driveAxis);
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
                GetDriveTransform().localRotation *= Quaternion.Euler(-AxisDirection * CalculatedDriveSpeed(driveSpeed));
            }
        }

        /// <summary>
        /// Calculates the drive speed.
        /// </summary>
        /// <param name="driveSpeed">The raw drive speed.</param>
        /// <returns>The calculated drive speed.</returns>
        protected virtual float CalculatedDriveSpeed(float driveSpeed)
        {
            return (driveSpeed * 0.5f) * Time.deltaTime;
        }

        /// <summary>
        /// Sets up the <see cref="RotationModifiers"/> collection with the given drive axis.
        /// </summary>
        /// <param name="driveAxis">The selected drive axis to set the modifiers to work on.</param>
        protected virtual void SetupRotationModifiers(DriveAxis.Axis driveAxis)
        {
            foreach (TransformPositionDifferenceRotation rotationModifier in RotationModifiers)
            {
                switch (driveAxis)
                {
                    case DriveAxis.Axis.XAxis:
                        rotationModifier.FollowOnAxis = Vector3State.XOnly;
                        break;
                    case DriveAxis.Axis.YAxis:
                        rotationModifier.FollowOnAxis = Vector3State.YOnly;
                        break;
                    case DriveAxis.Axis.ZAxis:
                        rotationModifier.FollowOnAxis = Vector3State.ZOnly;
                        break;
                }
            }
        }

        /// <summary>
        /// Sets up the <see cref="TwistRotationModifiers"/> collection with the given drive axis.
        /// </summary>
        /// <param name="driveAxis">The selected drive axis to set the modifiers to work on.</param>
        protected virtual void SetupTwistRotationModifiers(DriveAxis.Axis driveAxis)
        {
            foreach (RotateAroundAngularVelocity rotationModifier in TwistRotationModifiers)
            {
                switch (driveAxis)
                {
                    case DriveAxis.Axis.XAxis:
                        rotationModifier.ApplyToAxis = Vector3State.XOnly;
                        break;
                    case DriveAxis.Axis.YAxis:
                        rotationModifier.ApplyToAxis = Vector3State.YOnly;
                        break;
                    case DriveAxis.Axis.ZAxis:
                        rotationModifier.ApplyToAxis = Vector3State.ZOnly;
                        break;
                }
            }
        }
    }
}