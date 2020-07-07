namespace Tilia.Interactions.Controllables.AngularDriver
{
    using Malimbe.MemberChangeMethod;
    using Malimbe.PropertySerializationAttribute;
    using Malimbe.XmlDocumentationAttribute;
    using Tilia.Interactions.Controllables.Driver;
    using UnityEngine;
    using Zinnia.Data.Attribute;
    using Zinnia.Data.Type;

    /// <summary>
    /// The public interface into any RotationalDrive prefab.
    /// </summary>
    public class AngularDriveFacade : DriveFacade<AngularDrive, AngularDriveFacade>
    {
        #region Limit Settings
        /// <summary>
        /// The rotational angle limits for the drive.
        /// </summary>
        [Serialized]
        [field: Header("Limit Settings"), DocumentedByXml]
        public FloatRange DriveLimit { get; set; } = new FloatRange(-180f, 180f);
        #endregion

        #region Hinge Settings
        /// <summary>
        /// The location of the hinge within the local position of the drive.
        /// </summary>
        [Serialized]
        [field: Header("Hinge Settings"), DocumentedByXml]
        public Vector3 HingeLocation { get; set; }
        #endregion

        #region Gizmo Settings
        /// <summary>
        /// The distance of the gizmo hinge location line.
        /// </summary>
        [Serialized]
        [field: Header("Gizmo Settings"), DocumentedByXml, Restricted(RestrictedAttribute.Restrictions.Muted)]
        public float GizmoLineDistance { get; set; } = 0.2f;
        /// <summary>
        /// The radius of the gizmo hinge location end sphere.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml, Restricted(RestrictedAttribute.Restrictions.Muted)]
        public float GizmoSphereRadius { get; set; } = 0.015f;
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

        protected virtual void OnDrawGizmosSelected()
        {
            Gizmos.color = Color.yellow;
            Gizmos.matrix = transform.localToWorldMatrix;
            Vector3 origin = HingeLocation;
            Vector3 direction = DriveAxis.GetAxisDirection(true) * (GizmoLineDistance * 0.5f);
            Vector3 from = origin - direction;
            Vector3 to = origin + direction;
            Gizmos.DrawLine(from, to);
            Gizmos.DrawSphere(from, GizmoSphereRadius);
            Gizmos.DrawSphere(to, GizmoSphereRadius);
        }

        /// <summary>
        /// Called after <see cref="DriveLimit"/> has been changed.
        /// </summary>
        [CalledAfterChangeOf(nameof(DriveLimit))]
        protected virtual void OnAfterDriveLimitChange()
        {
            Drive.SetDriveLimits();
        }

        /// <summary>
        /// Called after <see cref="HingeLocation"/> has been changed.
        /// </summary>
        [CalledAfterChangeOf(nameof(HingeLocation))]
        protected virtual void OnAfterHingeLocationChange()
        {
            Drive.SetUp();
        }
    }
}