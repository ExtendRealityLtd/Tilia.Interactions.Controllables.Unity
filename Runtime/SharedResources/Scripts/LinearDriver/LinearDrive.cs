namespace Tilia.Interactions.Controllables.LinearDriver
{
    using Tilia.Interactions.Controllables.Driver;
    using UnityEngine;
    using Zinnia.Data.Type;
    using Zinnia.Extension;

    /// <summary>
    /// The basis to drive a control in a linear direction.
    /// </summary>
    public abstract class LinearDrive : Drive<LinearDriveFacade, LinearDrive>
    {
        /// <summary>
        /// Calculates the limits of the drive.
        /// </summary>
        /// <param name="newLimit">The maximum local space limit the drive can reach.</param>
        /// <returns>The minimum and maximum local space limit the drive can reach.</returns>
        public virtual FloatRange CalculateDriveLimits(float newLimit)
        {
            if (!isActiveAndEnabled)
            {
                return FloatRange.MinMax;
            }

            float motionLimit = Mathf.Abs(newLimit * 0.5f);
            return new FloatRange(-motionLimit, motionLimit);
        }

        /// <inheritdoc />
        protected override FloatRange CalculateDriveLimits(LinearDriveFacade facade)
        {
            return CalculateDriveLimits(facade.DriveLimit);
        }

        /// <inheritdoc />
        protected override float CalculateValue(DriveAxis.Axis axis, FloatRange limits)
        {
            if (!this.IsValidState())
            {
                return default;
            }

            float result = 0f;
            switch (axis)
            {
                case DriveAxis.Axis.XAxis:
                    result = GetDriveTransform().localPosition.x;
                    break;
                case DriveAxis.Axis.YAxis:
                    result = GetDriveTransform().localPosition.y;
                    break;
                case DriveAxis.Axis.ZAxis:
                    result = GetDriveTransform().localPosition.z;
                    break;
            }
            return Mathf.Clamp(result, limits.minimum, limits.maximum);
        }

        /// <inheritdoc />
        public override void ConfigureAutoDrive(bool autoDrive)
        {
            if (!this.IsValidState())
            {
                return;
            }

            ProcessDriveSpeed(Facade.DriveSpeed, Facade.MoveToTargetValue);
        }
    }
}