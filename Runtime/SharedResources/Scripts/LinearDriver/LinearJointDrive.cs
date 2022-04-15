namespace Tilia.Interactions.Controllables.LinearDriver
{
    using Tilia.Interactions.Controllables.Driver;
    using UnityEngine;
    using Zinnia.Data.Attribute;
    using Zinnia.Data.Type;
    using Zinnia.Extension;

    /// <summary>
    /// A directional drive that utilizes a physics joint to control the linear translation movement.
    /// </summary>
    public class LinearJointDrive : LinearDrive
    {
        #region Joint Settings
        [Header("Joint Settings")]
        [Tooltip("The joint being used to drive the movement.")]
        [SerializeField]
        [Restricted]
        private ConfigurableJoint joint;
        /// <summary>
        /// The joint being used to drive the movement.
        /// </summary>
        public ConfigurableJoint Joint
        {
            get
            {
                return joint;
            }
            protected set
            {
                joint = value;
            }
        }
        #endregion

        /// <summary>
        /// The <see cref="Rigidbody"/> that the joint is using.
        /// </summary>
        protected Rigidbody jointRigidbody;

        /// <inheritdoc />
        public override Vector3 CalculateDriveAxis(DriveAxis.Axis driveAxis)
        {
            if (!this.IsValidState())
            {
                return default;
            }

            Joint.xMotion = driveAxis == DriveAxis.Axis.XAxis ? ConfigurableJointMotion.Limited : ConfigurableJointMotion.Locked;
            Joint.yMotion = driveAxis == DriveAxis.Axis.YAxis ? ConfigurableJointMotion.Limited : ConfigurableJointMotion.Locked;
            Joint.zMotion = driveAxis == DriveAxis.Axis.ZAxis ? ConfigurableJointMotion.Limited : ConfigurableJointMotion.Locked;
            Joint.angularXMotion = ConfigurableJointMotion.Locked;
            Joint.angularYMotion = ConfigurableJointMotion.Locked;
            Joint.angularZMotion = ConfigurableJointMotion.Locked;
            return base.CalculateDriveAxis(driveAxis);
        }

        /// <inheritdoc />
        public override FloatRange CalculateDriveLimits(float newLimit)
        {
            if (!isActiveAndEnabled)
            {
                return FloatRange.MinMax;
            }

            FloatRange jointLimit = base.CalculateDriveLimits(newLimit);
            SoftJointLimit softJointLimit = new SoftJointLimit();
            softJointLimit.limit = jointLimit.maximum;
            Joint.linearLimit = softJointLimit;
            return jointLimit;
        }

        /// <inheritdoc />
        public override void ProcessDriveSpeed(float driveSpeed, bool moveToTargetValue)
        {
            if (!this.IsValidState())
            {
                return;
            }

            JointDrive snapDriver = new JointDrive();
            snapDriver.positionSpring = driveSpeed;
            snapDriver.positionDamper = 1f;
            snapDriver.maximumForce = moveToTargetValue ? 1f : 0f;

            Joint.xDrive = snapDriver;
            Joint.yDrive = snapDriver;
            Joint.zDrive = snapDriver;
        }
        /// <inheritdoc />
        protected override void SetUpInternals()
        {
            jointRigidbody = Joint.GetComponent<Rigidbody>();
            base.SetUpInternals();
        }

        /// <inheritdoc />
        protected override Transform GetDriveTransform()
        {
            return Joint.transform;
        }

        /// <inheritdoc />
        protected override void SetDriveTargetValue(Vector3 targetValue)
        {
            Joint.targetPosition = targetValue;
        }

        /// <inheritdoc />
        protected override void EliminateDriveVelocity()
        {
            jointRigidbody.velocity = Vector3.zero;
            jointRigidbody.angularVelocity = Vector3.zero;
        }
    }
}