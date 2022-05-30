# Class AngularTransformDrive

A rotational drive that directly manipulates a Transform.rotation to control the rotational angle without the use of any physics.

## Contents

* [Inheritance]
* [Namespace]
* [Syntax]
* [Properties]
  * [RotationModifier]
  * [VelocityApplier]
* [Methods]
  * [ApplyExistingAngularVelocity(Single)]
  * [AttemptApplyLimits()]
  * [CalculateDriveAxis(DriveAxis.Axis)]
  * [CalculateHingeLocation(Vector3)]
  * [EliminateDriveVelocity()]
  * [GetDriveTransform()]
  * [ProcessAutoDrive(Single)]
* [Implements]

## Details

##### Inheritance

* System.Object
* [Drive]<[AngularDriveFacade], [AngularDrive]\>
* [AngularDrive]
* AngularTransformDrive

##### Implements

IProcessable

##### Inherited Members

[AngularDrive.PreviousActualAngle]

[AngularDrive.CurrentActualAngle]

[AngularDrive.ActualTargetAngle]

[AngularDrive.circleDegrees]

[AngularDrive.circleUpperRightQuadrant]

[AngularDrive.circleUpperLeftQuadrant]

[AngularDrive.previousPseudoRotation]

[AngularDrive.currentPseudoRotation]

[AngularDrive.pseudoAngularVelocity]

[AngularDrive.rotationMultiplier]

[AngularDrive.previousActualRotation]

[AngularDrive.currentActualRotation]

[AngularDrive.Process()]

[AngularDrive.ResetDrive()]

[AngularDrive.SetUpInternals()]

[AngularDrive.CalculateDriveLimits(AngularDriveFacade)]

[AngularDrive.CalculateValue(DriveAxis.Axis, FloatRange)]

[AngularDrive.GetSimpleEulerAngles()]

[AngularDrive.CalculateDirectionMultiplier()]

[AngularDrive.ApplyLimits()]

[AngularDrive.CalculateAutoDriveVelocity()]

[AngularDrive.CalculateRotationMultiplier()]

[AngularDrive.MatchActualTargetAngle(Single)]

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
public class AngularTransformDrive : AngularDrive
```

### Properties

#### RotationModifier

The TransformPositionDifferenceRotation to drive the rotation of the control.

##### Declaration

```
public TransformPositionDifferenceRotation RotationModifier { get; protected set; }
```

#### VelocityApplier

The ArtificialVelocityApplier that applies artificial angular velocity to the control after releasing.

##### Declaration

```
public ArtificialVelocityApplier VelocityApplier { get; protected set; }
```

### Methods

#### ApplyExistingAngularVelocity(Single)

Attempts to apply the existing angular velocity back on to the rotation of the drive.

##### Declaration

```
public override void ApplyExistingAngularVelocity(float multiplier = 1F)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | multiplier | The amount to multiply the angular velocity to be applied by. |

##### Overrides

[AngularDrive.ApplyExistingAngularVelocity(Single)]

#### AttemptApplyLimits()

Attempts to apply the limits on the drive.

##### Declaration

```
protected override void AttemptApplyLimits()
```

##### Overrides

[AngularDrive.AttemptApplyLimits()]

#### CalculateDriveAxis(DriveAxis.Axis)

Calculates the axis to drive the control on.

##### Declaration

```
public override Vector3 CalculateDriveAxis(DriveAxis.Axis driveAxis)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [DriveAxis.Axis] | driveAxis | The desired world axis. |

##### Returns

| Type | Description |
| --- | --- |
| Vector3 | The direction of the drive axis. |

##### Overrides

Tilia.Interactions.Controllables.Driver.Drive<Tilia.Interactions.Controllables.AngularDriver.AngularDriveFacade, Tilia.Interactions.Controllables.AngularDriver.AngularDrive>.CalculateDriveAxis(Tilia.Interactions.Controllables.Driver.DriveAxis.Axis)

#### CalculateHingeLocation(Vector3)

Calculates the location of the rotational hinge for the drive.

##### Declaration

```
public override void CalculateHingeLocation(Vector3 newHingeLocation)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| Vector3 | newHingeLocation | The new local space for the hinge point. |

##### Overrides

[AngularDrive.CalculateHingeLocation(Vector3)]

#### EliminateDriveVelocity()

Removes any velocity being applied to the drive.

##### Declaration

```
protected override void EliminateDriveVelocity()
```

##### Overrides

Tilia.Interactions.Controllables.Driver.Drive<Tilia.Interactions.Controllables.AngularDriver.AngularDriveFacade, Tilia.Interactions.Controllables.AngularDriver.AngularDrive>.EliminateDriveVelocity()

#### GetDriveTransform()

Gets the Transform that the drive is operating on.

##### Declaration

```
protected override Transform GetDriveTransform()
```

##### Returns

| Type | Description |
| --- | --- |
| Transform | The drive Transform. |

##### Overrides

Tilia.Interactions.Controllables.Driver.Drive<Tilia.Interactions.Controllables.AngularDriver.AngularDriveFacade, Tilia.Interactions.Controllables.AngularDriver.AngularDrive>.GetDriveTransform()

#### ProcessAutoDrive(Single)

Automatically controls the drive to the target rotation at the given speed.

##### Declaration

```
protected override void ProcessAutoDrive(float driveSpeed)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | driveSpeed | The speed to automatically rotate the drive. |

##### Overrides

[AngularDrive.ProcessAutoDrive(Single)]

### Implements

IProcessable

[Drive]: ../Driver/Drive-2.md
[AngularDriveFacade]: AngularDriveFacade.md
[AngularDrive]: AngularDrive.md
[AngularDrive.PreviousActualAngle]: AngularDrive.md#Tilia_Interactions_Controllables_AngularDriver_AngularDrive_PreviousActualAngle
[AngularDrive.CurrentActualAngle]: AngularDrive.md#Tilia_Interactions_Controllables_AngularDriver_AngularDrive_CurrentActualAngle
[AngularDrive.ActualTargetAngle]: AngularDrive.md#Tilia_Interactions_Controllables_AngularDriver_AngularDrive_ActualTargetAngle
[AngularDrive.circleDegrees]: AngularDrive.md#Tilia_Interactions_Controllables_AngularDriver_AngularDrive_circleDegrees
[AngularDrive.circleUpperRightQuadrant]: AngularDrive.md#Tilia_Interactions_Controllables_AngularDriver_AngularDrive_circleUpperRightQuadrant
[AngularDrive.circleUpperLeftQuadrant]: AngularDrive.md#Tilia_Interactions_Controllables_AngularDriver_AngularDrive_circleUpperLeftQuadrant
[AngularDrive.previousPseudoRotation]: AngularDrive.md#Tilia_Interactions_Controllables_AngularDriver_AngularDrive_previousPseudoRotation
[AngularDrive.currentPseudoRotation]: AngularDrive.md#Tilia_Interactions_Controllables_AngularDriver_AngularDrive_currentPseudoRotation
[AngularDrive.pseudoAngularVelocity]: AngularDrive.md#Tilia_Interactions_Controllables_AngularDriver_AngularDrive_pseudoAngularVelocity
[AngularDrive.rotationMultiplier]: AngularDrive.md#Tilia_Interactions_Controllables_AngularDriver_AngularDrive_rotationMultiplier
[AngularDrive.previousActualRotation]: AngularDrive.md#Tilia_Interactions_Controllables_AngularDriver_AngularDrive_previousActualRotation
[AngularDrive.currentActualRotation]: AngularDrive.md#Tilia_Interactions_Controllables_AngularDriver_AngularDrive_currentActualRotation
[AngularDrive.Process()]: AngularDrive.md#Tilia_Interactions_Controllables_AngularDriver_AngularDrive_Process
[AngularDrive.ResetDrive()]: AngularDrive.md#Tilia_Interactions_Controllables_AngularDriver_AngularDrive_ResetDrive
[AngularDrive.SetUpInternals()]: AngularDrive.md#Tilia_Interactions_Controllables_AngularDriver_AngularDrive_SetUpInternals
[AngularDrive.CalculateDriveLimits(AngularDriveFacade)]: AngularDrive.md#Tilia_Interactions_Controllables_AngularDriver_AngularDrive_CalculateDriveLimits_Tilia_Interactions_Controllables_AngularDriver_AngularDriveFacade_
[AngularDrive.CalculateValue(DriveAxis.Axis, FloatRange)]: AngularDrive.md#Tilia_Interactions_Controllables_AngularDriver_AngularDrive_CalculateValue_Tilia_Interactions_Controllables_Driver_DriveAxis_Axis_FloatRange_
[AngularDrive.GetSimpleEulerAngles()]: AngularDrive.md#Tilia_Interactions_Controllables_AngularDriver_AngularDrive_GetSimpleEulerAngles
[AngularDrive.CalculateDirectionMultiplier()]: AngularDrive.md#Tilia_Interactions_Controllables_AngularDriver_AngularDrive_CalculateDirectionMultiplier
[AngularDrive.ApplyLimits()]: AngularDrive.md#Tilia_Interactions_Controllables_AngularDriver_AngularDrive_ApplyLimits
[AngularDrive.CalculateAutoDriveVelocity()]: AngularDrive.md#Tilia_Interactions_Controllables_AngularDriver_AngularDrive_CalculateAutoDriveVelocity
[AngularDrive.CalculateRotationMultiplier()]: AngularDrive.md#Tilia_Interactions_Controllables_AngularDriver_AngularDrive_CalculateRotationMultiplier
[AngularDrive.MatchActualTargetAngle(Single)]: AngularDrive.md#Tilia_Interactions_Controllables_AngularDriver_AngularDrive_MatchActualTargetAngle_System_Single_
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
[AngularDrive.ApplyExistingAngularVelocity(Single)]: AngularDrive.md#Tilia_Interactions_Controllables_AngularDriver_AngularDrive_ApplyExistingAngularVelocity_System_Single_
[AngularDrive.AttemptApplyLimits()]: AngularDrive.md#Tilia_Interactions_Controllables_AngularDriver_AngularDrive_AttemptApplyLimits
[DriveAxis.Axis]: ../Driver/DriveAxis.Axis.md
[AngularDrive.CalculateHingeLocation(Vector3)]: AngularDrive.md#Tilia_Interactions_Controllables_AngularDriver_AngularDrive_CalculateHingeLocation_Vector3_
[AngularDrive.ProcessAutoDrive(Single)]: AngularDrive.md#Tilia_Interactions_Controllables_AngularDriver_AngularDrive_ProcessAutoDrive_System_Single_
[Inheritance]: #Inheritance
[Namespace]: #Namespace
[Syntax]: #Syntax
[Properties]: #Properties
[RotationModifier]: #RotationModifier
[VelocityApplier]: #VelocityApplier
[Methods]: #Methods
[ApplyExistingAngularVelocity(Single)]: #ApplyExistingAngularVelocitySingle
[AttemptApplyLimits()]: #AttemptApplyLimits
[CalculateDriveAxis(DriveAxis.Axis)]: #CalculateDriveAxisDriveAxis.Axis
[CalculateHingeLocation(Vector3)]: #CalculateHingeLocationVector3
[EliminateDriveVelocity()]: #EliminateDriveVelocity
[GetDriveTransform()]: #GetDriveTransform
[ProcessAutoDrive(Single)]: #ProcessAutoDriveSingle
[Implements]: #Implements
