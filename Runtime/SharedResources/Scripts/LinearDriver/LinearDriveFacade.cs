namespace Tilia.Interactions.Controllables.LinearDriver
{
    using Malimbe.MemberChangeMethod;
    using Malimbe.PropertySerializationAttribute;
    using Malimbe.XmlDocumentationAttribute;
    using Tilia.Interactions.Controllables.Driver;
    using UnityEngine;
    using Zinnia.Data.Attribute;

    /// <summary>
    /// The public interface into any Linear Drive prefab.
    /// </summary>
    public class LinearDriveFacade : DriveFacade<LinearDrive, LinearDriveFacade>
    {
        #region Limit Settings
        /// <summary>
        /// The world space limit of the drive direction along the specified axis.
        /// </summary>
        [Serialized]
        [field: Header("Limit Settings"), DocumentedByXml]
        public float DriveLimit { get; set; } = 1f;
        #endregion

        #region Gizmo Settings
        /// <summary>
        /// The size of the gizmo cube to draw at the limits of the drive.
        /// </summary>
        [Serialized]
        [field: Header("Gizmo Settings"), DocumentedByXml, Restricted(RestrictedAttribute.Restrictions.Muted)]
        public Vector3 GizmoCubeSize { get; set; } = Vector3.one * 0.015f;
        #endregion

        protected virtual void OnDrawGizmosSelected()
        {
            Gizmos.color = Color.yellow;
            Gizmos.matrix = transform.localToWorldMatrix;
            Vector3 origin = Vector3.zero;
            Vector3 direction = DriveAxis.GetAxisDirection(true) * (DriveLimit * 0.5f);
            Vector3 from = origin - direction;
            Vector3 to = origin + direction;
            Gizmos.DrawLine(from, to);
            Gizmos.DrawCube(from, GizmoCubeSize);
            Gizmos.DrawCube(to, GizmoCubeSize);
        }

        /// <summary>
        /// Called after <see cref="DriveLimit"/> has been changed.
        /// </summary>
        [CalledAfterChangeOf(nameof(DriveLimit))]
        protected virtual void OnAfterDriveLimitChange()
        {
            Drive.SetUp();
        }
    }
}