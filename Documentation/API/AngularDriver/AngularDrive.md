# Class AngularDrive

The basis to drive a control in a rotational angle.

## Contents

* [Inheritance]
* [Namespace]
* [Syntax]
* [Fields]
  * [circleDegrees]
  * [circleUpperLeftQuadrant]
  * [circleUpperRightQuadrant]
  * [currentActualRotation]
  * [currentPseudoRotation]
  * [previousActualRotation]
  * [previousPseudoRotation]
  * [pseudoAngularVelocity]
  * [rotationMultiplier]
* [Properties]
  * [ActualTargetAngle]
  * [CurrentActualAngle]
  * [PreviousActualAngle]
* [Methods]
  * [ApplyExistingAngularVelocity(Single)]
  * [ApplyLimits()]
  * [AttemptApplyLimits()]
  * [CalculateAutoDriveVelocity()]
  * [CalculateDirectionMultiplier()]
  * [CalculateDriveLimits(AngularDriveFacade)]
  * [CalculateHingeLocation(Vector3)]
  * [CalculateRotationMultiplier()]
  * [CalculateValue(DriveAxis.Axis, FloatRange)]
  * [GetSimpleEulerAngles()]
  * [MatchActualTargetAngle(Single)]
  * [Process()]
  * [ProcessAutoDrive(Single)]
  * [ResetDrive()]
  * [SetUpInternals()]
* [Implements]

## Details

##### Inheritance

* System.Object
* [Drive]<[AngularDriveFacade], [AngularDrive]\>
* AngularDrive
* [AngularJointDrive]
* [AngularTransformDrive]

##### Implements

IProcessable

##### Inherited Members

[Drive<AngularDriveFacade, AngularDrive>.Facade]

[Drive<AngularDriveFacade, AngularDrive>.EventOutputContainer]

[Drive<AngularDriveFacade, AngularDrive>.SnapToStepContainer]

[Drive<AngularDriveFacade, AngularDrive>.GrabbedDragEmitter]

[Drive<AngularDriveFacade, AngularDrive>.UngrabbedDragEmitter]

[Drive<AngularDriveFacade, AngularDrive>.Interactable]

[Drive<AngularDriveFacade, AngularDrive>.InteractableMesh]

[Drive<AngularDriveFacade, AngularDrive>.ResetDriveOnSetup]

[Drive<AngularDriveFacade, AngularDrive>.ResetDriveOnSetupFirstTimeOnly]

[Drive<AngularDriveFacade, AngularDrive>.IsGrabbable]

[Drive<AngularDriveFacade, AngularDrive>.InitialValueDriveSpeed]

[Drive<AngularDriveFacade, AngularDrive>.GizmoColor]

[Drive<AngularDriveFacade, AngularDrive>.TargetValueReachedThreshold]

[Drive<AngularDriveFacade, AngularDrive>.EmitEvents]

[Drive<AngularDriveFacade, AngularDrive>.Value]

[Drive<AngularDriveFacade, AngularDrive>.NormalizedValue]

[Drive<AngularDriveFacade, AngularDrive>.StepValue]

[Drive<AngularDriveFacade, AngularDrive>.NormalizedStepValue]

[Drive<AngularDriveFacade, AngularDrive>.AxisDirection]

[Drive<AngularDriveFacade, AngularDrive>.DriveLimits]

[Drive<AngularDriveFacade, AngularDrive>.previousValue]

[Drive<AngularDriveFacade, AngularDrive>.previousStepValue]

[Drive<AngularDriveFacade, AngularDrive>.previousTargetValueReached]

[Drive<AngularDriveFacade, AngularDrive>.isMoving]

[Drive<AngularDriveFacade, AngularDrive>.isMovingToInitialTargetValue]

[Drive<AngularDriveFacade, AngularDrive>.cachedEmitEvents]

[Drive<AngularDriveFacade, AngularDrive>.cachedMoveToTargetValue]

[Drive<AngularDriveFacade, AngularDrive>.cachedTargetValue]

[Drive<AngularDriveFacade, AngularDrive>.cachedDriveSpeed]

[Drive<AngularDriveFacade, AngularDrive>.wasDisabled]

[Drive<AngularDriveFacade, AngularDrive>.ConfigureAutoDrive(Boolean)]

[Drive<AngularDriveFacade, AngularDrive>.SetUp()]

[Drive<AngularDriveFacade, AngularDrive>.Process()]

[Drive<AngularDriveFacade, AngularDrive>.ToggleSnapToStepLogic(Boolean)]

[Drive<AngularDriveFacade, AngularDrive>.SetDriveLimits()]

[Drive<AngularDriveFacade, AngularDrive>.SetAxisDirection()]

[Drive<AngularDriveFacade, AngularDrive>.SetGrabbedDrag(Single)]

[Drive<AngularDriveFacade, AngularDrive>.SetUngrabbedDrag(Single)]

[Drive<AngularDriveFacade, AngularDrive>.ProcessDriveSpeed(Single, Boolean)]

[Drive<AngularDriveFacade, AngularDrive>.SetTargetValue(Single)]

[Drive<AngularDriveFacade, AngularDrive>.CalculateDriveAxis(DriveAxis.Axis)]

[Drive<AngularDriveFacade, AngularDrive>.ResetDrive()]

[Drive<AngularDriveFacade, AngularDrive>.ToggleGrabbaleState(Boolean)]

[Drive<AngularDriveFacade, AngularDrive>.PreventGrab()]

[Drive<AngularDriveFacade, AngularDrive>.AllowGrab()]

[Drive<AngularDriveFacade, AngularDrive>.CalculateValue(DriveAxis.Axis, FloatRange)]

[Drive<AngularDriveFacade, AngularDrive>.CalculateDriveLimits(AngularDriveFacade)]

[Drive<AngularDriveFacade, AngularDrive>.GetDriveTransform()]

[Drive<AngularDriveFacade, AngularDrive>.OnEnable()]

[Drive<AngularDriveFacade, AngularDrive>.OnDisable()]

[Drive<AngularDriveFacade, AngularDrive>.SetUpInternals()]

[Drive<AngularDriveFacade, AngularDrive>.SetDriveTargetValue(Vector3)]

[Drive<AngularDriveFacade, AngularDrive>.EliminateDriveVelocity()]

[Drive<AngularDriveFacade, AngularDrive>.EmitStartMoving()]

[Drive<AngularDriveFacade, AngularDrive>.EmitStopMoving()]

[Drive<AngularDriveFacade, AngularDrive>.CheckStepValueChange()]

[Drive<AngularDriveFacade, AngularDrive>.CheckTargetValueReached()]

[Drive<AngularDriveFacade, AngularDrive>.GetTargetValue()]

[Drive<AngularDriveFacade, AngularDrive>.CanMoveToTargetValue()]

[Drive<AngularDriveFacade, AngularDrive>.CalculateStepValue(AngularDriveFacade)]

[Drive<AngularDriveFacade, AngularDrive>.EmitValueChanged()]

[Drive<AngularDriveFacade, AngularDrive>.EmitNormalizedValueChanged()]

[Drive<AngularDriveFacade, AngularDrive>.EmitStepValueChanged()]

[Drive<AngularDriveFacade, AngularDrive>.EmitTargetValueReached()]

[Drive<AngularDriveFacade, AngularDrive>.EmitStartedMoving()]

[Drive<AngularDriveFacade, AngularDrive>.EmitStoppedMoving()]

[Drive<AngularDriveFacade, AngularDrive>.MoveToInitialTargetValue()]

[Drive<AngularDriveFacade, AngularDrive>.ResetToCacheAfterReachedInitialTargetValue()]

[Drive<AngularDriveFacade, AngularDrive>.OnAfterIsGrabbableChange()]

##### Namespace

* [Tilia.Interactions.Controllables.AngularDriver]

##### Syntax

```
public abstract class AngularDrive : Drive<AngularDriveFacade, AngularDrive>
```

### Fields

#### circleDegrees

The total number of degrees in a circle.

##### Declaration

```
protected const float circleDegrees = 360F
```

#### circleUpperLeftQuadrant

The angle range that defines the upper left quadrant of a circle.

##### Declaration

```
protected static readonly FloatRange circleUpperLeftQuadrant
```

#### circleUpperRightQuadrant

##### Declaration

```
protected static readonly FloatRange circleUpperRightQuadrant
```

#### currentActualRotation

The current actual rotational value of the drive.

##### Declaration

```
protected Vector3 currentActualRotation
```

#### currentPseudoRotation

The representation of the current frame rotation in meaningful values and not limited to 0f to 360f.

##### Declaration

```
protected float currentPseudoRotation
```

#### previousActualRotation

The previous actual rotational value of the drive.

##### Declaration

```
protected Vector3 previousActualRotation
```

#### previousPseudoRotation

The representation of the previous frame rotation in meaningful values and not limited to 0f to 360f.

##### Declaration

```
protected float previousPseudoRotation
```

#### pseudoAngularVelocity

The representation of the rotational velocity.

##### Declaration

```
protected float pseudoAngularVelocity
```

#### rotationMultiplier

The multiplier used to determine how many complete revolutions the drive has performed.

##### Declaration

```
protected float rotationMultiplier
```

### Properties

#### ActualTargetAngle

The target angle for the control to reach.

##### Declaration

```
protected virtual float ActualTargetAngle { get; }
```

#### CurrentActualAngle

The current rotation angle of the control.

##### Declaration

```
protected virtual float CurrentActualAngle { get; }
```

#### PreviousActualAngle

The previous rotation angle of the control.

##### Declaration

```
protected virtual float PreviousActualAngle { get; }
```

### Methods

#### ApplyExistingAngularVelocity(Single)

Attempts to apply the existing angular velocity back on to the rotation of the drive.

##### Declaration

```
public abstract void ApplyExistingAngularVelocity(float multiplier = 1F)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | multiplier | The amount to multiply the angular velocity to be applied by. |

#### ApplyLimits()

Applies the limits on the drive rotation.

##### Declaration

```
protected virtual bool ApplyLimits()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | Whether the limits have been applied. |

#### AttemptApplyLimits()

Attempts to apply the limits on the drive.

##### Declaration

```
protected virtual void AttemptApplyLimits()
```

#### CalculateAutoDriveVelocity()

Calculates the velocity that the drive should automatically rotate the control with.

##### Declaration

```
protected virtual float CalculateAutoDriveVelocity()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Single | The velocity to drive the control automatically with. |

#### CalculateDirectionMultiplier()

Calculates a multiplier based on the direction the rotation is traveling.

##### Declaration

```
protected virtual float CalculateDirectionMultiplier()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Single | The multiplier that represents the direction. |

#### CalculateDriveLimits(AngularDriveFacade)

Calculates the limits of the drive.

##### Declaration

```
protected override FloatRange CalculateDriveLimits(AngularDriveFacade facade)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [AngularDriveFacade] | facade | n/a |

##### Returns

| Type | Description |
| --- | --- |
| FloatRange | The minimum and maximum local space limit the drive can reach. |

##### Overrides

Tilia.Interactions.Controllables.Driver.Drive<Tilia.Interactions.Controllables.AngularDriver.AngularDriveFacade, Tilia.Interactions.Controllables.AngularDriver.AngularDrive>.CalculateDriveLimits(Tilia.Interactions.Controllables.AngularDriver.AngularDriveFacade)

#### CalculateHingeLocation(Vector3)

Calculates the location of the rotational hinge for the drive.

##### Declaration

```
public abstract void CalculateHingeLocation(Vector3 newHingeLocation)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| Vector3 | newHingeLocation | The new local space for the hinge point. |

#### CalculateRotationMultiplier()

Calculates the current rotation the control is at.

##### Declaration

```
protected virtual void CalculateRotationMultiplier()
```

#### CalculateValue(DriveAxis.Axis, FloatRange)

Calculates the current value of the control.

##### Declaration

```
protected override float CalculateValue(DriveAxis.Axis driveAxis, FloatRange limits)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [DriveAxis.Axis] | driveAxis | n/a |
| FloatRange | limits | The limits of the drive. |

##### Returns

| Type | Description |
| --- | --- |
| System.Single | The calculated value. |

##### Overrides

Tilia.Interactions.Controllables.Driver.Drive<Tilia.Interactions.Controllables.AngularDriver.AngularDriveFacade, Tilia.Interactions.Controllables.AngularDriver.AngularDrive>.CalculateValue(Tilia.Interactions.Controllables.Driver.DriveAxis.Axis, FloatRange)

#### GetSimpleEulerAngles()

Attempts to retrieve a simple x, y or z euler angle from the Transform.localEulerAngles utilizing any other axis rotation.

##### Declaration

```
protected virtual Vector3 GetSimpleEulerAngles()
```

##### Returns

| Type | Description |
| --- | --- |
| Vector3 | The actual axis angle from 0f to 360f. |

#### MatchActualTargetAngle(Single)

Attempts to match the target angle to set the control at the correct angle if the drive is no longer moving.

##### Declaration

```
protected virtual void MatchActualTargetAngle(float driveSpeed)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | driveSpeed | The speed the drive is automatically rotating at. |

#### Process()

Processes the value changes and emits the appropriate events.

##### Declaration

```
public override void Process()
```

##### Overrides

Tilia.Interactions.Controllables.Driver.Drive<Tilia.Interactions.Controllables.AngularDriver.AngularDriveFacade, Tilia.Interactions.Controllables.AngularDriver.AngularDrive>.Process()

#### ProcessAutoDrive(Single)

Automatically controls the drive to the target rotation at the given speed.

##### Declaration

```
protected abstract void ProcessAutoDrive(float driveSpeed)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | driveSpeed | The speed to automatically rotate the drive. |

#### ResetDrive()

Resets the drive back to any default settings.

##### Declaration

```
public override void ResetDrive()
```

##### Overrides

Tilia.Interactions.Controllables.Driver.Drive<Tilia.Interactions.Controllables.AngularDriver.AngularDriveFacade, Tilia.Interactions.Controllables.AngularDriver.AngularDrive>.ResetDrive()

#### SetUpInternals()

Performs any required internal setup.

##### Declaration

```
protected override void SetUpInternals()
```

##### Overrides

Tilia.Interactions.Controllables.Driver.Drive<Tilia.Interactions.Controllables.AngularDriver.AngularDriveFacade, Tilia.Interactions.Controllables.AngularDriver.AngularDrive>.SetUpInternals()

### Implements

IProcessable

[Drive]: ../Driver/Drive-2.md
[AngularDrive]: AngularDrive.md
[AngularJointDrive]: AngularJointDrive.md
[AngularTransformDrive]: AngularTransformDrive.md
[Drive<AngularDriveFacade, AngularDrive>.Facade]: Tilia.Interactions.Controllables.Driver.Drive-2.md#Tilia_Interactions_Controllables_Driver_Drive_2_Facade
[Drive<AngularDriveFacade, AngularDrive>.EventOutputContainer]: Tilia.Interactions.Controllables.Driver.Drive-2.md#Tilia_Interactions_Controllables_Driver_Drive_2_EventOutputContainer
[Drive<AngularDriveFacade, AngularDrive>.SnapToStepContainer]: Tilia.Interactions.Controllables.Driver.Drive-2.md#Tilia_Interactions_Controllables_Driver_Drive_2_SnapToStepContainer
[Drive<AngularDriveFacade, AngularDrive>.GrabbedDragEmitter]: Tilia.Interactions.Controllables.Driver.Drive-2.md#Tilia_Interactions_Controllables_Driver_Drive_2_GrabbedDragEmitter
[Drive<AngularDriveFacade, AngularDrive>.UngrabbedDragEmitter]: Tilia.Interactions.Controllables.Driver.Drive-2.md#Tilia_Interactions_Controllables_Driver_Drive_2_UngrabbedDragEmitter
[Drive<AngularDriveFacade, AngularDrive>.Interactable]: Tilia.Interactions.Controllables.Driver.Drive-2.md#Tilia_Interactions_Controllables_Driver_Drive_2_Interactable
[Drive<AngularDriveFacade, AngularDrive>.InteractableMesh]: Tilia.Interactions.Controllables.Driver.Drive-2.md#Tilia_Interactions_Controllables_Driver_Drive_2_InteractableMesh
[Drive<AngularDriveFacade, AngularDrive>.ResetDriveOnSetup]: Tilia.Interactions.Controllables.Driver.Drive-2.md#Tilia_Interactions_Controllables_Driver_Drive_2_ResetDriveOnSetup
[Drive<AngularDriveFacade, AngularDrive>.ResetDriveOnSetupFirstTimeOnly]: Tilia.Interactions.Controllables.Driver.Drive-2.md#Tilia_Interactions_Controllables_Driver_Drive_2_ResetDriveOnSetupFirstTimeOnly
[Drive<AngularDriveFacade, AngularDrive>.IsGrabbable]: Tilia.Interactions.Controllables.Driver.Drive-2.md#Tilia_Interactions_Controllables_Driver_Drive_2_IsGrabbable
[Drive<AngularDriveFacade, AngularDrive>.InitialValueDriveSpeed]: Tilia.Interactions.Controllables.Driver.Drive-2.md#Tilia_Interactions_Controllables_Driver_Drive_2_InitialValueDriveSpeed
[Drive<AngularDriveFacade, AngularDrive>.GizmoColor]: Tilia.Interactions.Controllables.Driver.Drive-2.md#Tilia_Interactions_Controllables_Driver_Drive_2_GizmoColor
[Drive<AngularDriveFacade, AngularDrive>.TargetValueReachedThreshold]: Tilia.Interactions.Controllables.Driver.Drive-2.md#Tilia_Interactions_Controllables_Driver_Drive_2_TargetValueReachedThreshold
[Drive<AngularDriveFacade, AngularDrive>.EmitEvents]: Tilia.Interactions.Controllables.Driver.Drive-2.md#Tilia_Interactions_Controllables_Driver_Drive_2_EmitEvents
[Drive<AngularDriveFacade, AngularDrive>.Value]: Tilia.Interactions.Controllables.Driver.Drive-2.md#Tilia_Interactions_Controllables_Driver_Drive_2_Value
[Drive<AngularDriveFacade, AngularDrive>.NormalizedValue]: Tilia.Interactions.Controllables.Driver.Drive-2.md#Tilia_Interactions_Controllables_Driver_Drive_2_NormalizedValue
[Drive<AngularDriveFacade, AngularDrive>.StepValue]: Tilia.Interactions.Controllables.Driver.Drive-2.md#Tilia_Interactions_Controllables_Driver_Drive_2_StepValue
[Drive<AngularDriveFacade, AngularDrive>.NormalizedStepValue]: Tilia.Interactions.Controllables.Driver.Drive-2.md#Tilia_Interactions_Controllables_Driver_Drive_2_NormalizedStepValue
[Drive<AngularDriveFacade, AngularDrive>.AxisDirection]: Tilia.Interactions.Controllables.Driver.Drive-2.md#Tilia_Interactions_Controllables_Driver_Drive_2_AxisDirection
[Drive<AngularDriveFacade, AngularDrive>.DriveLimits]: Tilia.Interactions.Controllables.Driver.Drive-2.md#Tilia_Interactions_Controllables_Driver_Drive_2_DriveLimits
[Drive<AngularDriveFacade, AngularDrive>.previousValue]: Tilia.Interactions.Controllables.Driver.Drive-2.md#Tilia_Interactions_Controllables_Driver_Drive_2_previousValue
[Drive<AngularDriveFacade, AngularDrive>.previousStepValue]: Tilia.Interactions.Controllables.Driver.Drive-2.md#Tilia_Interactions_Controllables_Driver_Drive_2_previousStepValue
[Drive<AngularDriveFacade, AngularDrive>.previousTargetValueReached]: Tilia.Interactions.Controllables.Driver.Drive-2.md#Tilia_Interactions_Controllables_Driver_Drive_2_previousTargetValueReached
[Drive<AngularDriveFacade, AngularDrive>.isMoving]: Tilia.Interactions.Controllables.Driver.Drive-2.md#Tilia_Interactions_Controllables_Driver_Drive_2_isMoving
[Drive<AngularDriveFacade, AngularDrive>.isMovingToInitialTargetValue]: Tilia.Interactions.Controllables.Driver.Drive-2.md#Tilia_Interactions_Controllables_Driver_Drive_2_isMovingToInitialTargetValue
[Drive<AngularDriveFacade, AngularDrive>.cachedEmitEvents]: Tilia.Interactions.Controllables.Driver.Drive-2.md#Tilia_Interactions_Controllables_Driver_Drive_2_cachedEmitEvents
[Drive<AngularDriveFacade, AngularDrive>.cachedMoveToTargetValue]: Tilia.Interactions.Controllables.Driver.Drive-2.md#Tilia_Interactions_Controllables_Driver_Drive_2_cachedMoveToTargetValue
[Drive<AngularDriveFacade, AngularDrive>.cachedTargetValue]: Tilia.Interactions.Controllables.Driver.Drive-2.md#Tilia_Interactions_Controllables_Driver_Drive_2_cachedTargetValue
[Drive<AngularDriveFacade, AngularDrive>.cachedDriveSpeed]: Tilia.Interactions.Controllables.Driver.Drive-2.md#Tilia_Interactions_Controllables_Driver_Drive_2_cachedDriveSpeed
[Drive<AngularDriveFacade, AngularDrive>.wasDisabled]: Tilia.Interactions.Controllables.Driver.Drive-2.md#Tilia_Interactions_Controllables_Driver_Drive_2_wasDisabled
[Drive<AngularDriveFacade, AngularDrive>.ConfigureAutoDrive(Boolean)]: Tilia.Interactions.Controllables.Driver.Drive-2.md#Tilia_Interactions_Controllables_Driver_Drive_2_ConfigureAutoDrive_System_Boolean_
[Drive<AngularDriveFacade, AngularDrive>.SetUp()]: Tilia.Interactions.Controllables.Driver.Drive-2.md#Tilia_Interactions_Controllables_Driver_Drive_2_SetUp
[Drive<AngularDriveFacade, AngularDrive>.Process()]: Tilia.Interactions.Controllables.Driver.Drive-2.md#Tilia_Interactions_Controllables_Driver_Drive_2_Process
[Drive<AngularDriveFacade, AngularDrive>.ToggleSnapToStepLogic(Boolean)]: Tilia.Interactions.Controllables.Driver.Drive-2.md#Tilia_Interactions_Controllables_Driver_Drive_2_ToggleSnapToStepLogic_System_Boolean_
[Drive<AngularDriveFacade, AngularDrive>.SetDriveLimits()]: Tilia.Interactions.Controllables.Driver.Drive-2.md#Tilia_Interactions_Controllables_Driver_Drive_2_SetDriveLimits
[Drive<AngularDriveFacade, AngularDrive>.SetAxisDirection()]: Tilia.Interactions.Controllables.Driver.Drive-2.md#Tilia_Interactions_Controllables_Driver_Drive_2_SetAxisDirection
[Drive<AngularDriveFacade, AngularDrive>.SetGrabbedDrag(Single)]: Tilia.Interactions.Controllables.Driver.Drive-2.md#Tilia_Interactions_Controllables_Driver_Drive_2_SetGrabbedDrag_System_Single_
[Drive<AngularDriveFacade, AngularDrive>.SetUngrabbedDrag(Single)]: Tilia.Interactions.Controllables.Driver.Drive-2.md#Tilia_Interactions_Controllables_Driver_Drive_2_SetUngrabbedDrag_System_Single_
[Drive<AngularDriveFacade, AngularDrive>.ProcessDriveSpeed(Single, Boolean)]: Tilia.Interactions.Controllables.Driver.Drive-2.md#Tilia_Interactions_Controllables_Driver_Drive_2_ProcessDriveSpeed_System_Single_System_Boolean_
[Drive<AngularDriveFacade, AngularDrive>.SetTargetValue(Single)]: Tilia.Interactions.Controllables.Driver.Drive-2.md#Tilia_Interactions_Controllables_Driver_Drive_2_SetTargetValue_System_Single_
[Drive<AngularDriveFacade, AngularDrive>.CalculateDriveAxis(DriveAxis.Axis)]: Tilia.Interactions.Controllables.Driver.Drive-2.md#Tilia_Interactions_Controllables_Driver_Drive_2_CalculateDriveAxis_Tilia_Interactions_Controllables_Driver_DriveAxis_Axis_
[Drive<AngularDriveFacade, AngularDrive>.ResetDrive()]: Tilia.Interactions.Controllables.Driver.Drive-2.md#Tilia_Interactions_Controllables_Driver_Drive_2_ResetDrive
[Drive<AngularDriveFacade, AngularDrive>.ToggleGrabbaleState(Boolean)]: Tilia.Interactions.Controllables.Driver.Drive-2.md#Tilia_Interactions_Controllables_Driver_Drive_2_ToggleGrabbaleState_System_Boolean_
[Drive<AngularDriveFacade, AngularDrive>.PreventGrab()]: Tilia.Interactions.Controllables.Driver.Drive-2.md#Tilia_Interactions_Controllables_Driver_Drive_2_PreventGrab
[Drive<AngularDriveFacade, AngularDrive>.AllowGrab()]: Tilia.Interactions.Controllables.Driver.Drive-2.md#Tilia_Interactions_Controllables_Driver_Drive_2_AllowGrab
[Drive<AngularDriveFacade, AngularDrive>.CalculateValue(DriveAxis.Axis, FloatRange)]: Tilia.Interactions.Controllables.Driver.Drive-2.md#Tilia_Interactions_Controllables_Driver_Drive_2_CalculateValue_Tilia_Interactions_Controllables_Driver_DriveAxis_Axis_FloatRange_
[Drive<AngularDriveFacade, AngularDrive>.CalculateDriveLimits(AngularDriveFacade)]: Tilia.Interactions.Controllables.Driver.Drive-2.md#Tilia_Interactions_Controllables_Driver_Drive_2_CalculateDriveLimits__0_
[Drive<AngularDriveFacade, AngularDrive>.GetDriveTransform()]: Tilia.Interactions.Controllables.Driver.Drive-2.md#Tilia_Interactions_Controllables_Driver_Drive_2_GetDriveTransform
[Drive<AngularDriveFacade, AngularDrive>.OnEnable()]: Tilia.Interactions.Controllables.Driver.Drive-2.md#Tilia_Interactions_Controllables_Driver_Drive_2_OnEnable
[Drive<AngularDriveFacade, AngularDrive>.OnDisable()]: Tilia.Interactions.Controllables.Driver.Drive-2.md#Tilia_Interactions_Controllables_Driver_Drive_2_OnDisable
[Drive<AngularDriveFacade, AngularDrive>.SetUpInternals()]: Tilia.Interactions.Controllables.Driver.Drive-2.md#Tilia_Interactions_Controllables_Driver_Drive_2_SetUpInternals
[Drive<AngularDriveFacade, AngularDrive>.SetDriveTargetValue(Vector3)]: Tilia.Interactions.Controllables.Driver.Drive-2.md#Tilia_Interactions_Controllables_Driver_Drive_2_SetDriveTargetValue_Vector3_
[Drive<AngularDriveFacade, AngularDrive>.EliminateDriveVelocity()]: Tilia.Interactions.Controllables.Driver.Drive-2.md#Tilia_Interactions_Controllables_Driver_Drive_2_EliminateDriveVelocity
[Drive<AngularDriveFacade, AngularDrive>.EmitStartMoving()]: Tilia.Interactions.Controllables.Driver.Drive-2.md#Tilia_Interactions_Controllables_Driver_Drive_2_EmitStartMoving
[Drive<AngularDriveFacade, AngularDrive>.EmitStopMoving()]: Tilia.Interactions.Controllables.Driver.Drive-2.md#Tilia_Interactions_Controllables_Driver_Drive_2_EmitStopMoving
[Drive<AngularDriveFacade, AngularDrive>.CheckStepValueChange()]: Tilia.Interactions.Controllables.Driver.Drive-2.md#Tilia_Interactions_Controllables_Driver_Drive_2_CheckStepValueChange
[Drive<AngularDriveFacade, AngularDrive>.CheckTargetValueReached()]: Tilia.Interactions.Controllables.Driver.Drive-2.md#Tilia_Interactions_Controllables_Driver_Drive_2_CheckTargetValueReached
[Drive<AngularDriveFacade, AngularDrive>.GetTargetValue()]: Tilia.Interactions.Controllables.Driver.Drive-2.md#Tilia_Interactions_Controllables_Driver_Drive_2_GetTargetValue
[Drive<AngularDriveFacade, AngularDrive>.CanMoveToTargetValue()]: Tilia.Interactions.Controllables.Driver.Drive-2.md#Tilia_Interactions_Controllables_Driver_Drive_2_CanMoveToTargetValue
[Drive<AngularDriveFacade, AngularDrive>.CalculateStepValue(AngularDriveFacade)]: Tilia.Interactions.Controllables.Driver.Drive-2.md#Tilia_Interactions_Controllables_Driver_Drive_2_CalculateStepValue__0_
[Drive<AngularDriveFacade, AngularDrive>.EmitValueChanged()]: Tilia.Interactions.Controllables.Driver.Drive-2.md#Tilia_Interactions_Controllables_Driver_Drive_2_EmitValueChanged
[Drive<AngularDriveFacade, AngularDrive>.EmitNormalizedValueChanged()]: Tilia.Interactions.Controllables.Driver.Drive-2.md#Tilia_Interactions_Controllables_Driver_Drive_2_EmitNormalizedValueChanged
[Drive<AngularDriveFacade, AngularDrive>.EmitStepValueChanged()]: Tilia.Interactions.Controllables.Driver.Drive-2.md#Tilia_Interactions_Controllables_Driver_Drive_2_EmitStepValueChanged
[Drive<AngularDriveFacade, AngularDrive>.EmitTargetValueReached()]: Tilia.Interactions.Controllables.Driver.Drive-2.md#Tilia_Interactions_Controllables_Driver_Drive_2_EmitTargetValueReached
[Drive<AngularDriveFacade, AngularDrive>.EmitStartedMoving()]: Tilia.Interactions.Controllables.Driver.Drive-2.md#Tilia_Interactions_Controllables_Driver_Drive_2_EmitStartedMoving
[Drive<AngularDriveFacade, AngularDrive>.EmitStoppedMoving()]: Tilia.Interactions.Controllables.Driver.Drive-2.md#Tilia_Interactions_Controllables_Driver_Drive_2_EmitStoppedMoving
[Drive<AngularDriveFacade, AngularDrive>.MoveToInitialTargetValue()]: Tilia.Interactions.Controllables.Driver.Drive-2.md#Tilia_Interactions_Controllables_Driver_Drive_2_MoveToInitialTargetValue
[Drive<AngularDriveFacade, AngularDrive>.ResetToCacheAfterReachedInitialTargetValue()]: Tilia.Interactions.Controllables.Driver.Drive-2.md#Tilia_Interactions_Controllables_Driver_Drive_2_ResetToCacheAfterReachedInitialTargetValue
[Drive<AngularDriveFacade, AngularDrive>.OnAfterIsGrabbableChange()]: Tilia.Interactions.Controllables.Driver.Drive-2.md#Tilia_Interactions_Controllables_Driver_Drive_2_OnAfterIsGrabbableChange
[Tilia.Interactions.Controllables.AngularDriver]: README.md
[AngularDriveFacade]: AngularDriveFacade.md
[DriveAxis.Axis]: ../Driver/DriveAxis.Axis.md
[Inheritance]: #Inheritance
[Namespace]: #Namespace
[Syntax]: #Syntax
[Fields]: #Fields
[circleDegrees]: #circleDegrees
[circleUpperLeftQuadrant]: #circleUpperLeftQuadrant
[circleUpperRightQuadrant]: #circleUpperRightQuadrant
[currentActualRotation]: #currentActualRotation
[currentPseudoRotation]: #currentPseudoRotation
[previousActualRotation]: #previousActualRotation
[previousPseudoRotation]: #previousPseudoRotation
[pseudoAngularVelocity]: #pseudoAngularVelocity
[rotationMultiplier]: #rotationMultiplier
[Properties]: #Properties
[ActualTargetAngle]: #ActualTargetAngle
[CurrentActualAngle]: #CurrentActualAngle
[PreviousActualAngle]: #PreviousActualAngle
[Methods]: #Methods
[ApplyExistingAngularVelocity(Single)]: #ApplyExistingAngularVelocitySingle
[ApplyLimits()]: #ApplyLimits
[AttemptApplyLimits()]: #AttemptApplyLimits
[CalculateAutoDriveVelocity()]: #CalculateAutoDriveVelocity
[CalculateDirectionMultiplier()]: #CalculateDirectionMultiplier
[CalculateDriveLimits(AngularDriveFacade)]: #CalculateDriveLimitsAngularDriveFacade
[CalculateHingeLocation(Vector3)]: #CalculateHingeLocationVector3
[CalculateRotationMultiplier()]: #CalculateRotationMultiplier
[CalculateValue(DriveAxis.Axis, FloatRange)]: #CalculateValueDriveAxis.Axis-FloatRange
[GetSimpleEulerAngles()]: #GetSimpleEulerAngles
[MatchActualTargetAngle(Single)]: #MatchActualTargetAngleSingle
[Process()]: #Process
[ProcessAutoDrive(Single)]: #ProcessAutoDriveSingle
[ResetDrive()]: #ResetDrive
[SetUpInternals()]: #SetUpInternals
[Implements]: #Implements
