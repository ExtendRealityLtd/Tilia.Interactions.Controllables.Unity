namespace Tilia.Interactions.Controllables.LinearDriver
{
    using Tilia.Interactions.Controllables.Driver;
    using UnityEngine;
    using Zinnia.Data.Attribute;
    using Zinnia.Extension;

    /// <summary>
    /// The public interface into any Linear Drive prefab.
    /// </summary>
    public class LinearDriveFacade : DriveFacade<LinearDrive, LinearDriveFacade>
    {
        #region Limit Settings
        [Header("Limit Settings")]
        [Tooltip("The world space limit of the drive direction along the specified axis.")]
        [SerializeField]
        private float driveLimit = 1f;
        /// <summary>
        /// The world space limit of the drive direction along the specified axis.
        /// </summary>
        public float DriveLimit
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

        #region Gizmo Settings
        [Header("Gizmo Settings")]
        [Tooltip("The size of the gizmo cube to draw at the limits of the drive.")]
        [SerializeField]
        [Restricted(RestrictedAttribute.Restrictions.Muted)]
        private Vector3 gizmoCubeSize = Vector3.one * 0.015f;
        /// <summary>
        /// The size of the gizmo cube to draw at the limits of the drive.
        /// </summary>
        public Vector3 GizmoCubeSize
        {
            get
            {
                return gizmoCubeSize;
            }
            set
            {
                gizmoCubeSize = value;
            }
        }
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
        protected virtual void OnAfterDriveLimitChange()
        {
            Drive.SetUp();
        }
    }
}