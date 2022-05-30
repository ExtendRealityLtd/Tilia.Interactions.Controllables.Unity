namespace Tilia.Interactions.Controllables.AngularDriver
{
    using Tilia.Interactions.Controllables.Driver;
    using UnityEngine;
    using Zinnia.Data.Attribute;
    using Zinnia.Data.Type;
    using Zinnia.Extension;

    /// <summary>
    /// The public interface into any RotationalDrive prefab.
    /// </summary>
    public class AngularDriveFacade : DriveFacade<AngularDrive, AngularDriveFacade>
    {
        #region Limit Settings
        [Header("Limit Settings")]
        [Tooltip("The rotational angle limits for the drive.")]
        [SerializeField]
        private FloatRange driveLimit = new FloatRange(-180f, 180f);
        /// <summary>
        /// The rotational angle limits for the drive.
        /// </summary>
        public FloatRange DriveLimit
        {
            get
            {
                return driveLimit;
            }
            set
            {
                driveLimit = value;
                if (this.IsMemberChangeAllowed())
                {
                    OnAfterDriveLimitChange();
                }
            }
        }
        #endregion

        #region Hinge Settings
        [Header("Hinge Settings")]
        [Tooltip("The location of the hinge within the local position of the drive.")]
        [SerializeField]
        private Vector3 hingeLocation;
        /// <summary>
        /// The location of the hinge within the local position of the drive.
        /// </summary>
        public Vector3 HingeLocation
        {
            get
            {
                return hingeLocation;
            }
            set
            {
                hingeLocation = value;
                if (this.IsMemberChangeAllowed())
                {
                    OnAfterHingeLocationChange();
                }
            }
        }
        #endregion

        #region Gizmo Settings
        [Header("Gizmo Settings")]
        [Tooltip("The distance of the gizmo hinge location line.")]
        [SerializeField]
        [Restricted(RestrictedAttribute.Restrictions.Muted)]
        private float gizmoLineDistance = 0.2f;
        /// <summary>
        /// The distance of the gizmo hinge location line.
        /// </summary>
        public float GizmoLineDistance
        {
            get
            {
                return gizmoLineDistance;
            }
            set
            {
                gizmoLineDistance = value;
            }
        }
        [Tooltip("The radius of the gizmo hinge location end sphere.")]
        [SerializeField]
        [Restricted(RestrictedAttribute.Restrictions.Muted)]
        private float gizmoSphereRadius = 0.015f;
        /// <summary>
        /// The radius of the gizmo hinge location end sphere.
        /// </summary>
        public float GizmoSphereRadius
        {
            get
            {
                return gizmoSphereRadius;
            }
            set
            {
                gizmoSphereRadius = value;
            }
        }
        #endregion

        /// <summary>
        /// Sets the <see cref="DriveLimit"/> minimum value.
        /// </summary>
        /// <param name="value">The new minimum value.</param>
        public virtual void SetDriveLimitMinimum(float value)
        {
            FloatRange newLimit = new FloatRange(DriveLimit.ToVector2());
            newLimit.minimum = value;
            DriveLimit = newLimit;
        }

        /// <summary>
        /// Sets the <see cref="DriveLimit"/> maximum value.
        /// </summary>
        /// <param name="value">The new maximum value.</param>
        public virtual void SetDriveLimitMaximum(float value)
        {
            FloatRange newLimit = new FloatRange(DriveLimit.ToVector2());
            newLimit.maximum = value;
            DriveLimit = newLimit;
        }

        /// <summary>
        /// Sets the <see cref="HingeLocation"/> x value.
        /// </summary>
        /// <param name="value">The new x value.</param>
        public virtual void SetHingeLocationX(float value)
        {
            HingeLocation = new Vector3(value, HingeLocation.y, HingeLocation.z);
        }

        /// <summary>
        /// Sets the <see cref="HingeLocation"/> y value.
        /// </summary>
        /// <param name="value">The new y value.</param>
        public virtual void SetHingeLocationY(float value)
        {
            HingeLocation = new Vector3(HingeLocation.x, value, HingeLocation.z);
        }

        /// <summary>
        /// Sets the <see cref="HingeLocation"/> z value.
        /// </summary>
        /// <param name="value">The new z value.</param>
        public virtual void SetHingeLocationZ(float value)
        {
            HingeLocation = new Vector3(HingeLocation.x, HingeLocation.y, value);
        }

        /// <summary>
        /// Called after <see cref="DriveLimit"/> has been changed.
        /// </summary>
        protected virtual void OnAfterDriveLimitChange()
        {
            Drive.SetDriveLimits();
        }

        /// <summary>
        /// Called after <see cref="HingeLocation"/> has been changed.
        /// </summary>
        protected virtual void OnAfterHingeLocationChange()
        {
            Drive.SetUp();
        }

        protected virtual void OnDrawGizmosSelected()
        {
            Gizmos.color = Drive.GizmoColor;
            Gizmos.matrix = transform.localToWorldMatrix;

            Vector3 origin = HingeLocation;
            Vector3 direction = DriveAxis.GetAxisDirection(true) * (GizmoLineDistance * 0.5f);
            Vector3 from = origin - direction;
            Vector3 to = origin + direction;

            Gizmos.DrawLine(from, to);
            Gizmos.DrawSphere(from, GizmoSphereRadius);
            Gizmos.DrawSphere(to, GizmoSphereRadius);
        }
    }
}