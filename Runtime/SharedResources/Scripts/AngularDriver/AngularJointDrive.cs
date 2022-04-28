namespace Tilia.Interactions.Controllables.AngularDriver
{
    using System.Collections.Generic;
    using Tilia.Interactions.Controllables.Driver;
    using UnityEngine;
    using Zinnia.Data.Attribute;
    using Zinnia.Extension;

    /// <summary>
    /// A rotational drive that utilizes a physics joint to control the rotational angle.
    /// </summary>
    public class AngularJointDrive : AngularDrive
    {
        #region Joint Settings
        [Header("Joint Settings")]
        [Tooltip("The joint being used to drive the rotation.")]
        [SerializeField]
        [Restricted]
        private HingeJoint joint;
        /// <summary>
        /// The joint being used to drive the rotation.
        /// </summary>
        public HingeJoint Joint
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
        [Tooltip("The parent GameObject of the joint.")]
        [SerializeField]
        [Restricted]
        private GameObject jointContainer;
        /// <summary>
        /// The parent <see cref="GameObject"/> of the joint.
        /// </summary>
        public GameObject JointContainer
        {
            get
            {
                return jointContainer;
            }
            protected set
            {
                jointContainer = value;
            }
        }
        #endregion

        /// <summary>
        /// The <see cref="Rigidbody"/> that the joint is using.
        /// </summary>
        protected Rigidbody jointRigidbody;
        /// <summary>
        /// The motor data to set on the joint.
        /// </summary>
        protected JointMotor jointMotor;
        /// <summary>
        /// A reusable collection to hold the active state of children of the <see cref="Rigidbody"/>s that are adjusted.
        /// </summary>
        protected readonly List<bool> rigidbodyChildrenActiveStates = new List<bool>();

        /// <inheritdoc />
        public override Vector3 CalculateDriveAxis(DriveAxis.Axis driveAxis)
        {
            if (!this.IsValidState())
            {
                return default;
            }

            Vector3 axisDirection = base.CalculateDriveAxis(driveAxis);
            Joint.axis = axisDirection * -1f;
            return axisDirection;
        }

        /// <inheritdoc />
        public override void CalculateHingeLocation(Vector3 newHingeLocation)
        {
            if (!this.IsValidState())
            {
                return;
            }

            Joint.anchor = newHingeLocation;
            SetJointContainerPosition();
        }

        /// <inheritdoc />
        public override void ConfigureAutoDrive(bool autoDrive)
        {
            if (!this.IsValidState())
            {
                return;
            }

            Joint.useMotor = autoDrive;
        }

        /// <inheritdoc />
        public override void ApplyExistingAngularVelocity(float multiplier = 1f)
        {
            jointRigidbody.angularVelocity = AxisDirection * pseudoAngularVelocity * multiplier;
        }

        /// <inheritdoc />
        protected override void SetUpInternals()
        {
            jointMotor.force = Joint.motor.force;
            jointRigidbody = Joint.GetComponent<Rigidbody>();
            ConfigureAutoDrive(Facade.MoveToTargetValue);
            base.SetUpInternals();
        }

        /// <inheritdoc />
        protected override void EliminateDriveVelocity()
        {
            jointRigidbody.velocity = Vector3.zero;
            jointRigidbody.angularVelocity = Vector3.zero;
        }

        /// <inheritdoc />
        protected override Transform GetDriveTransform()
        {
            return Joint.transform;
        }

        /// <inheritdoc />
        protected override void ProcessAutoDrive(float driveSpeed)
        {
            jointMotor.targetVelocity = driveSpeed;
            Joint.motor = jointMotor;
        }

        /// <inheritdoc />
        protected override void AttemptApplyLimits()
        {
            if (!Joint.useLimits && ApplyLimits())
            {
                EliminateDriveVelocity();
            }
        }

        /// <summary>
        /// Sets the <see cref="JointContainer"/> position based on the joint anchor.
        /// </summary>
        protected virtual void SetJointContainerPosition()
        {
            // Disable any child rigidbody GameObjects of the joint to prevent the anchor position updating their position.
            Rigidbody[] rigidbodyChildren = Joint.GetComponentsInChildren<Rigidbody>();
            rigidbodyChildrenActiveStates.Clear();
            for (int index = 0; index < rigidbodyChildren.Length; index++)
            {
                if (rigidbodyChildren[index].gameObject == JointContainer || rigidbodyChildren[index] == jointRigidbody)
                {
                    rigidbodyChildrenActiveStates.Add(false);
                    continue;
                }

                rigidbodyChildrenActiveStates.Add(rigidbodyChildren[index].gameObject.activeSelf);
                rigidbodyChildren[index].gameObject.SetActive(false);
            }

            // Set the current joint container to match the joint anchor to provide the correct offset.
            JointContainer.transform.localPosition = Joint.anchor;
            JointContainer.transform.localRotation = Quaternion.identity;

            // Restore the state of child rigidbody GameObjects now the anchor position has been set.
            for (int index = 0; index < rigidbodyChildren.Length; index++)
            {
                if (rigidbodyChildren[index].gameObject == JointContainer || rigidbodyChildren[index] == jointRigidbody)
                {
                    continue;
                }

                rigidbodyChildren[index].gameObject.SetActive(rigidbodyChildrenActiveStates[index]);
            }
        }
    }
}