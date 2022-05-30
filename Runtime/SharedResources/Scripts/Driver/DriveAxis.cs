namespace Tilia.Interactions.Controllables.Driver
{
    using UnityEngine;

    /// <summary>
    /// Denotes a world axis for the drive to operate on.
    /// </summary>
    public static class DriveAxis
    {
        /// <summary>
        /// The axis to operate the drive on.
        /// </summary>
        public enum Axis
        {
            /// <summary>
            /// The world space X Axis.
            /// </summary>
            XAxis,
            /// <summary>
            /// The world space Y Axis.
            /// </summary>
            YAxis,
            /// <summary>
            /// The world space Z Axis.
            /// </summary>
            ZAxis
        }

        /// <summary>
        /// Gets the axis direction for the given <see cref="DriveAxis"/>.
        /// </summary>
        /// <param name="axis">The desired world axis.</param>
        /// <param name="negativeDirection">Whether to get the negative axis direction.</param>
        /// <returns>The direction of the drive axis.</returns>
        public static Vector3 GetAxisDirection(this Axis axis, bool negativeDirection = false)
        {
            Vector3 axisDirection = Vector3.zero;
            switch (axis)
            {
                case Axis.XAxis:
                    axisDirection = negativeDirection ? Vector3.left : Vector3.right;
                    break;
                case Axis.YAxis:
                    axisDirection = negativeDirection ? Vector3.down : Vector3.up;
                    break;
                case Axis.ZAxis:
                    axisDirection = negativeDirection ? Vector3.back : Vector3.forward;
                    break;
            }
            return axisDirection;
        }

        /// <summary>
        /// Gets the scale on the given <see cref="Transform"/> for the specified <see cref="DriveAxis"/>.
        /// </summary>
        /// <param name="axis">The desired axis.</param>
        /// <param name="source">The source of the scale.</param>
        /// <param name="useLocalScale">Whether to use the local scale of the <see cref="Transform"/> or the world scale.</param>
        /// <returns>The scale of the source for a given axis.</returns>
        public static float GetAxisScale(this Axis axis, Transform source, bool useLocalScale = true)
        {
            switch (axis)
            {
                case Axis.XAxis:
                    return useLocalScale ? source.localScale.x : source.lossyScale.x;
                case Axis.YAxis:
                    return useLocalScale ? source.localScale.y : source.lossyScale.y;
                case Axis.ZAxis:
                    return useLocalScale ? source.localScale.z : source.lossyScale.z;
            }

            return 1f;
        }

        /// <summary>
        /// Overwrites the given source <see cref="Vector3"/> over the given target <see cref="Vector3"/>.
        /// </summary>
        /// <param name="axis">The axis to overwrite on.</param>
        /// <param name="source">The source data to overwrite from.</param>
        /// <param name="target">The target data to overwrite the source data to.</param>
        /// <returns>The overwritten result.</returns>
        public static Vector3 Overwrite(this Axis axis, Vector3 source, Vector3 target)
        {
            switch (axis)
            {
                case Axis.XAxis:
                    return new Vector3(source.x, target.y, target.z);
                case Axis.YAxis:
                    return new Vector3(target.x, source.y, target.z);
                case Axis.ZAxis:
                    return new Vector3(target.x, target.y, source.z);
            }

            return Vector3.zero;
        }
    }
}