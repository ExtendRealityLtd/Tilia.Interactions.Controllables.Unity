# Class LinearTransformDrive

A directional drive that manipulates a Transform.position to control the linear translation movement without the use of any physics.

## Contents

* [Inheritance]
* [Namespace]
* [Syntax]
* [Properties]
  * [PositionClamper]
  * [PropertyApplier]
* [Methods]
  * [CalculateDriveAxis(DriveAxis.Axis)]
  * [GetDriveTransform()]
  * [Process()]
  * [ProcessDriveSpeed(Single, Boolean)]
  * [SetDriveTargetValue(Vector3)]
* [Implements]

## Details

##### Inheritance

* System.Object
* [Drive]<[LinearDriveFacade], [LinearDrive]\>
* [LinearDrive]
* LinearTransformDrive

##### Implements

IProcessable

##### Inherited Members

[LinearDrive.CalculateDriveLimits(Single)]

[LinearDrive.CalculateDriveLimits(LinearDriveFacade)]

[LinearDrive.CalculateValue(DriveAxis.Axis, FloatRange)]

[LinearDrive.ConfigureAutoDrive(Boolean)]

[Drive<LinearDriveFacade, LinearDrive>.Facade]

[Drive<LinearDriveFacade, LinearDrive>.EventOutputContainer]

[Drive<LinearDriveFacade, LinearDrive>.SnapToStepContainer]

[Drive<LinearDriveFacade, LinearDrive>.GrabbedDragEmitter]

[Drive<LinearDriveFacade, LinearDrive>.UngrabbedDragEmitter]

[Drive<LinearDriveFacade, LinearDrive>.Interactable]

[Drive<LinearDriveFacade, LinearDrive>.InteractableMesh]

[Drive<LinearDriveFacade, LinearDrive>.ResetDriveOnSetup]

[Drive<LinearDriveFacade, LinearDrive>.ResetDriveOnSetupFirstTimeOnly]

[Drive<LinearDriveFacade, LinearDrive>.IsGrabbable]

[Drive<LinearDriveFacade, LinearDrive>.InitialValueDriveSpeed]

[Drive<LinearDriveFacade, LinearDrive>.GizmoColor]

[Drive<LinearDriveFacade, LinearDrive>.TargetValueReachedThreshold]

[Drive<LinearDriveFacade, LinearDrive>.EmitEvents]

[Drive<LinearDriveFacade, LinearDrive>.Value]

[Drive<LinearDriveFacade, LinearDrive>.NormalizedValue]

[Drive<LinearDriveFacade, LinearDrive>.StepValue]

[Drive<LinearDriveFacade, LinearDrive>.NormalizedStepValue]

[Drive<LinearDriveFacade, LinearDrive>.AxisDirection]

[Drive<LinearDriveFacade, LinearDrive>.DriveLimits]

[Drive<LinearDriveFacade, LinearDrive>.previousValue]

[Drive<LinearDriveFacade, LinearDrive>.previousStepValue]

[Drive<LinearDriveFacade, LinearDrive>.previousTargetValueReached]

[Drive<LinearDriveFacade, LinearDrive>.isMoving]

[Drive<LinearDriveFacade, LinearDrive>.isMovingToInitialTargetValue]

[Drive<LinearDriveFacade, LinearDrive>.cachedEmitEvents]

[Drive<LinearDriveFacade, LinearDrive>.cachedMoveToTargetValue]

[Drive<LinearDriveFacade, LinearDrive>.cachedTargetValue]

[Drive<LinearDriveFacade, LinearDrive>.cachedDriveSpeed]

[Drive<LinearDriveFacade, LinearDrive>.wasDisabled]

[Drive<LinearDriveFacade, LinearDrive>.ConfigureAutoDrive(Boolean)]

[Drive<LinearDriveFacade, LinearDrive>.SetUp()]

[Drive<LinearDriveFacade, LinearDrive>.Process()]

[Drive<LinearDriveFacade, LinearDrive>.ToggleSnapToStepLogic(Boolean)]

[Drive<LinearDriveFacade, LinearDrive>.SetDriveLimits()]

[Drive<LinearDriveFacade, LinearDrive>.SetAxisDirection()]

[Drive<LinearDriveFacade, LinearDrive>.SetGrabbedDrag(Single)]

[Drive<LinearDriveFacade, LinearDrive>.SetUngrabbedDrag(Single)]

[Drive<LinearDriveFacade, LinearDrive>.ProcessDriveSpeed(Single, Boolean)]

[Drive<LinearDriveFacade, LinearDrive>.SetTargetValue(Single)]

[Drive<LinearDriveFacade, LinearDrive>.CalculateDriveAxis(DriveAxis.Axis)]

[Drive<LinearDriveFacade, LinearDrive>.ResetDrive()]

[Drive<LinearDriveFacade, LinearDrive>.ToggleGrabbaleState(Boolean)]

[Drive<LinearDriveFacade, LinearDrive>.PreventGrab()]

[Drive<LinearDriveFacade, LinearDrive>.AllowGrab()]

[Drive<LinearDriveFacade, LinearDrive>.CalculateValue(DriveAxis.Axis, FloatRange)]

[Drive<LinearDriveFacade, LinearDrive>.CalculateDriveLimits(LinearDriveFacade)]

[Drive<LinearDriveFacade, LinearDrive>.GetDriveTransform()]

[Drive<LinearDriveFacade, LinearDrive>.OnEnable()]

[Drive<LinearDriveFacade, LinearDrive>.OnDisable()]

[Drive<LinearDriveFacade, LinearDrive>.SetUpInternals()]

[Drive<LinearDriveFacade, LinearDrive>.SetDriveTargetValue(Vector3)]

[Drive<LinearDriveFacade, LinearDrive>.EliminateDriveVelocity()]

[Drive<LinearDriveFacade, LinearDrive>.EmitStartMoving()]

[Drive<LinearDriveFacade, LinearDrive>.EmitStopMoving()]

[Drive<LinearDriveFacade, LinearDrive>.CheckStepValueChange()]

[Drive<LinearDriveFacade, LinearDrive>.CheckTargetValueReached()]

[Drive<LinearDriveFacade, LinearDrive>.GetTargetValue()]

[Drive<LinearDriveFacade, LinearDrive>.CanMoveToTargetValue()]

[Drive<LinearDriveFacade, LinearDrive>.CalculateStepValue(LinearDriveFacade)]

[Drive<LinearDriveFacade, LinearDrive>.EmitValueChanged()]

[Drive<LinearDriveFacade, LinearDrive>.EmitNormalizedValueChanged()]

[Drive<LinearDriveFacade, LinearDrive>.EmitStepValueChanged()]

[Drive<LinearDriveFacade, LinearDrive>.EmitTargetValueReached()]

[Drive<LinearDriveFacade, LinearDrive>.EmitStartedMoving()]

[Drive<LinearDriveFacade, LinearDrive>.EmitStoppedMoving()]

[Drive<LinearDriveFacade, LinearDrive>.MoveToInitialTargetValue()]

[Drive<LinearDriveFacade, LinearDrive>.ResetToCacheAfterReachedInitialTargetValue()]

[Drive<LinearDriveFacade, LinearDrive>.OnAfterIsGrabbableChange()]

##### Namespace

* [Tilia.Interactions.Controllables.LinearDriver]

##### Syntax

```
public class LinearTransformDrive : LinearDrive
```

### Properties

#### PositionClamper

The Vector3Restrictor to clamp the position of the drive within the drive limits.

##### Declaration

```
public Vector3Restrictor PositionClamper { get; protected set; }
```

#### PropertyApplier

The TransformPropertyApplier to automatically move the drive to a specific location.

##### Declaration

```
public TransformPropertyApplier PropertyApplier { get; protected set; }
```

### Methods

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

Tilia.Interactions.Controllables.Driver.Drive<Tilia.Interactions.Controllables.LinearDriver.LinearDriveFacade, Tilia.Interactions.Controllables.LinearDriver.LinearDrive>.CalculateDriveAxis(Tilia.Interactions.Controllables.Driver.DriveAxis.Axis)

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

Tilia.Interactions.Controllables.Driver.Drive<Tilia.Interactions.Controllables.LinearDriver.LinearDriveFacade, Tilia.Interactions.Controllables.LinearDriver.LinearDrive>.GetDriveTransform()

#### Process()

Processes the value changes and emits the appropriate events.

##### Declaration

```
public override void Process()
```

##### Overrides

Tilia.Interactions.Controllables.Driver.Drive<Tilia.Interactions.Controllables.LinearDriver.LinearDriveFacade, Tilia.Interactions.Controllables.LinearDriver.LinearDrive>.Process()

#### ProcessDriveSpeed(Single, Boolean)

Processes the speed in which the drive can affect the control.

##### Declaration

```
public override void ProcessDriveSpeed(float driveSpeed, bool moveToTargetValue)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | driveSpeed | The speed to drive the control at. |
| System.Boolean | moveToTargetValue | Whether to allow the drive to automatically move the control to the desired target value. |

##### Overrides

Tilia.Interactions.Controllables.Driver.Drive<Tilia.Interactions.Controllables.LinearDriver.LinearDriveFacade, Tilia.Interactions.Controllables.LinearDriver.LinearDrive>.ProcessDriveSpeed(System.Single, System.Boolean)

#### SetDriveTargetValue(Vector3)

Sets the target value of the drive.

##### Declaration

```
protected override void SetDriveTargetValue(Vector3 targetValue)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| Vector3 | targetValue | The value to set the drive target to. |

##### Overrides

Tilia.Interactions.Controllables.Driver.Drive<Tilia.Interactions.Controllables.LinearDriver.LinearDriveFacade, Tilia.Interactions.Controllables.LinearDriver.LinearDrive>.SetDriveTargetValue(Vector3)

### Implements

IProcessable

[Drive]: ../Driver/Drive-2.md
[LinearDriveFacade]: LinearDriveFacade.md
[LinearDrive]: LinearDrive.md
[LinearDrive.CalculateDriveLimits(Single)]: LinearDrive.md#Tilia_Interactions_Controllables_LinearDriver_LinearDrive_CalculateDriveLimits_System_Single_
[LinearDrive.CalculateDriveLimits(LinearDriveFacade)]: LinearDrive.md#Tilia_Interactions_Controllables_LinearDriver_LinearDrive_CalculateDriveLimits_Tilia_Interactions_Controllables_LinearDriver_LinearDriveFacade_
[LinearDrive.CalculateValue(DriveAxis.Axis, FloatRange)]: LinearDrive.md#Tilia_Interactions_Controllables_LinearDriver_LinearDrive_CalculateValue_Tilia_Interactions_Controllables_Driver_DriveAxis_Axis_FloatRange_
[LinearDrive.ConfigureAutoDrive(Boolean)]: LinearDrive.md#Tilia_Interactions_Controllables_LinearDriver_LinearDrive_ConfigureAutoDrive_System_Boolean_
[Drive<LinearDriveFacade, LinearDrive>.Facade]: Tilia.Interactions.Controllables.Driver.Drive-2.md#Tilia_Interactions_Controllables_Driver_Drive_2_Facade
[Drive<LinearDriveFacade, LinearDrive>.EventOutputContainer]: Tilia.Interactions.Controllables.Driver.Drive-2.md#Tilia_Interactions_Controllables_Driver_Drive_2_EventOutputContainer
[Drive<LinearDriveFacade, LinearDrive>.SnapToStepContainer]: Tilia.Interactions.Controllables.Driver.Drive-2.md#Tilia_Interactions_Controllables_Driver_Drive_2_SnapToStepContainer
[Drive<LinearDriveFacade, LinearDrive>.GrabbedDragEmitter]: Tilia.Interactions.Controllables.Driver.Drive-2.md#Tilia_Interactions_Controllables_Driver_Drive_2_GrabbedDragEmitter
[Drive<LinearDriveFacade, LinearDrive>.UngrabbedDragEmitter]: Tilia.Interactions.Controllables.Driver.Drive-2.md#Tilia_Interactions_Controllables_Driver_Drive_2_UngrabbedDragEmitter
[Drive<LinearDriveFacade, LinearDrive>.Interactable]: Tilia.Interactions.Controllables.Driver.Drive-2.md#Tilia_Interactions_Controllables_Driver_Drive_2_Interactable
[Drive<LinearDriveFacade, LinearDrive>.InteractableMesh]: Tilia.Interactions.Controllables.Driver.Drive-2.md#Tilia_Interactions_Controllables_Driver_Drive_2_InteractableMesh
[Drive<LinearDriveFacade, LinearDrive>.ResetDriveOnSetup]: Tilia.Interactions.Controllables.Driver.Drive-2.md#Tilia_Interactions_Controllables_Driver_Drive_2_ResetDriveOnSetup
[Drive<LinearDriveFacade, LinearDrive>.ResetDriveOnSetupFirstTimeOnly]: Tilia.Interactions.Controllables.Driver.Drive-2.md#Tilia_Interactions_Controllables_Driver_Drive_2_ResetDriveOnSetupFirstTimeOnly
[Drive<LinearDriveFacade, LinearDrive>.IsGrabbable]: Tilia.Interactions.Controllables.Driver.Drive-2.md#Tilia_Interactions_Controllables_Driver_Drive_2_IsGrabbable
[Drive<LinearDriveFacade, LinearDrive>.InitialValueDriveSpeed]: Tilia.Interactions.Controllables.Driver.Drive-2.md#Tilia_Interactions_Controllables_Driver_Drive_2_InitialValueDriveSpeed
[Drive<LinearDriveFacade, LinearDrive>.GizmoColor]: Tilia.Interactions.Controllables.Driver.Drive-2.md#Tilia_Interactions_Controllables_Driver_Drive_2_GizmoColor
[Drive<LinearDriveFacade, LinearDrive>.TargetValueReachedThreshold]: Tilia.Interactions.Controllables.Driver.Drive-2.md#Tilia_Interactions_Controllables_Driver_Drive_2_TargetValueReachedThreshold
[Drive<LinearDriveFacade, LinearDrive>.EmitEvents]: Tilia.Interactions.Controllables.Driver.Drive-2.md#Tilia_Interactions_Controllables_Driver_Drive_2_EmitEvents
[Drive<LinearDriveFacade, LinearDrive>.Value]: Tilia.Interactions.Controllables.Driver.Drive-2.md#Tilia_Interactions_Controllables_Driver_Drive_2_Value
[Drive<LinearDriveFacade, LinearDrive>.NormalizedValue]: Tilia.Interactions.Controllables.Driver.Drive-2.md#Tilia_Interactions_Controllables_Driver_Drive_2_NormalizedValue
[Drive<LinearDriveFacade, LinearDrive>.StepValue]: Tilia.Interactions.Controllables.Driver.Drive-2.md#Tilia_Interactions_Controllables_Driver_Drive_2_StepValue
[Drive<LinearDriveFacade, LinearDrive>.NormalizedStepValue]: Tilia.Interactions.Controllables.Driver.Drive-2.md#Tilia_Interactions_Controllables_Driver_Drive_2_NormalizedStepValue
[Drive<LinearDriveFacade, LinearDrive>.AxisDirection]: Tilia.Interactions.Controllables.Driver.Drive-2.md#Tilia_Interactions_Controllables_Driver_Drive_2_AxisDirection
[Drive<LinearDriveFacade, LinearDrive>.DriveLimits]: Tilia.Interactions.Controllables.Driver.Drive-2.md#Tilia_Interactions_Controllables_Driver_Drive_2_DriveLimits
[Drive<LinearDriveFacade, LinearDrive>.previousValue]: Tilia.Interactions.Controllables.Driver.Drive-2.md#Tilia_Interactions_Controllables_Driver_Drive_2_previousValue
[Drive<LinearDriveFacade, LinearDrive>.previousStepValue]: Tilia.Interactions.Controllables.Driver.Drive-2.md#Tilia_Interactions_Controllables_Driver_Drive_2_previousStepValue
[Drive<LinearDriveFacade, LinearDrive>.previousTargetValueReached]: Tilia.Interactions.Controllables.Driver.Drive-2.md#Tilia_Interactions_Controllables_Driver_Drive_2_previousTargetValueReached
[Drive<LinearDriveFacade, LinearDrive>.isMoving]: Tilia.Interactions.Controllables.Driver.Drive-2.md#Tilia_Interactions_Controllables_Driver_Drive_2_isMoving
[Drive<LinearDriveFacade, LinearDrive>.isMovingToInitialTargetValue]: Tilia.Interactions.Controllables.Driver.Drive-2.md#Tilia_Interactions_Controllables_Driver_Drive_2_isMovingToInitialTargetValue
[Drive<LinearDriveFacade, LinearDrive>.cachedEmitEvents]: Tilia.Interactions.Controllables.Driver.Drive-2.md#Tilia_Interactions_Controllables_Driver_Drive_2_cachedEmitEvents
[Drive<LinearDriveFacade, LinearDrive>.cachedMoveToTargetValue]: Tilia.Interactions.Controllables.Driver.Drive-2.md#Tilia_Interactions_Controllables_Driver_Drive_2_cachedMoveToTargetValue
[Drive<LinearDriveFacade, LinearDrive>.cachedTargetValue]: Tilia.Interactions.Controllables.Driver.Drive-2.md#Tilia_Interactions_Controllables_Driver_Drive_2_cachedTargetValue
[Drive<LinearDriveFacade, LinearDrive>.cachedDriveSpeed]: Tilia.Interactions.Controllables.Driver.Drive-2.md#Tilia_Interactions_Controllables_Driver_Drive_2_cachedDriveSpeed
[Drive<LinearDriveFacade, LinearDrive>.wasDisabled]: Tilia.Interactions.Controllables.Driver.Drive-2.md#Tilia_Interactions_Controllables_Driver_Drive_2_wasDisabled
[Drive<LinearDriveFacade, LinearDrive>.ConfigureAutoDrive(Boolean)]: Tilia.Interactions.Controllables.Driver.Drive-2.md#Tilia_Interactions_Controllables_Driver_Drive_2_ConfigureAutoDrive_System_Boolean_
[Drive<LinearDriveFacade, LinearDrive>.SetUp()]: Tilia.Interactions.Controllables.Driver.Drive-2.md#Tilia_Interactions_Controllables_Driver_Drive_2_SetUp
[Drive<LinearDriveFacade, LinearDrive>.Process()]: Tilia.Interactions.Controllables.Driver.Drive-2.md#Tilia_Interactions_Controllables_Driver_Drive_2_Process
[Drive<LinearDriveFacade, LinearDrive>.ToggleSnapToStepLogic(Boolean)]: Tilia.Interactions.Controllables.Driver.Drive-2.md#Tilia_Interactions_Controllables_Driver_Drive_2_ToggleSnapToStepLogic_System_Boolean_
[Drive<LinearDriveFacade, LinearDrive>.SetDriveLimits()]: Tilia.Interactions.Controllables.Driver.Drive-2.md#Tilia_Interactions_Controllables_Driver_Drive_2_SetDriveLimits
[Drive<LinearDriveFacade, LinearDrive>.SetAxisDirection()]: Tilia.Interactions.Controllables.Driver.Drive-2.md#Tilia_Interactions_Controllables_Driver_Drive_2_SetAxisDirection
[Drive<LinearDriveFacade, LinearDrive>.SetGrabbedDrag(Single)]: Tilia.Interactions.Controllables.Driver.Drive-2.md#Tilia_Interactions_Controllables_Driver_Drive_2_SetGrabbedDrag_System_Single_
[Drive<LinearDriveFacade, LinearDrive>.SetUngrabbedDrag(Single)]: Tilia.Interactions.Controllables.Driver.Drive-2.md#Tilia_Interactions_Controllables_Driver_Drive_2_SetUngrabbedDrag_System_Single_
[Drive<LinearDriveFacade, LinearDrive>.ProcessDriveSpeed(Single, Boolean)]: Tilia.Interactions.Controllables.Driver.Drive-2.md#Tilia_Interactions_Controllables_Driver_Drive_2_ProcessDriveSpeed_System_Single_System_Boolean_
[Drive<LinearDriveFacade, LinearDrive>.SetTargetValue(Single)]: Tilia.Interactions.Controllables.Driver.Drive-2.md#Tilia_Interactions_Controllables_Driver_Drive_2_SetTargetValue_System_Single_
[Drive<LinearDriveFacade, LinearDrive>.CalculateDriveAxis(DriveAxis.Axis)]: Tilia.Interactions.Controllables.Driver.Drive-2.md#Tilia_Interactions_Controllables_Driver_Drive_2_CalculateDriveAxis_Tilia_Interactions_Controllables_Driver_DriveAxis_Axis_
[Drive<LinearDriveFacade, LinearDrive>.ResetDrive()]: Tilia.Interactions.Controllables.Driver.Drive-2.md#Tilia_Interactions_Controllables_Driver_Drive_2_ResetDrive
[Drive<LinearDriveFacade, LinearDrive>.ToggleGrabbaleState(Boolean)]: Tilia.Interactions.Controllables.Driver.Drive-2.md#Tilia_Interactions_Controllables_Driver_Drive_2_ToggleGrabbaleState_System_Boolean_
[Drive<LinearDriveFacade, LinearDrive>.PreventGrab()]: Tilia.Interactions.Controllables.Driver.Drive-2.md#Tilia_Interactions_Controllables_Driver_Drive_2_PreventGrab
[Drive<LinearDriveFacade, LinearDrive>.AllowGrab()]: Tilia.Interactions.Controllables.Driver.Drive-2.md#Tilia_Interactions_Controllables_Driver_Drive_2_AllowGrab
[Drive<LinearDriveFacade, LinearDrive>.CalculateValue(DriveAxis.Axis, FloatRange)]: Tilia.Interactions.Controllables.Driver.Drive-2.md#Tilia_Interactions_Controllables_Driver_Drive_2_CalculateValue_Tilia_Interactions_Controllables_Driver_DriveAxis_Axis_FloatRange_
[Drive<LinearDriveFacade, LinearDrive>.CalculateDriveLimits(LinearDriveFacade)]: Tilia.Interactions.Controllables.Driver.Drive-2.md#Tilia_Interactions_Controllables_Driver_Drive_2_CalculateDriveLimits__0_
[Drive<LinearDriveFacade, LinearDrive>.GetDriveTransform()]: Tilia.Interactions.Controllables.Driver.Drive-2.md#Tilia_Interactions_Controllables_Driver_Drive_2_GetDriveTransform
[Drive<LinearDriveFacade, LinearDrive>.OnEnable()]: Tilia.Interactions.Controllables.Driver.Drive-2.md#Tilia_Interactions_Controllables_Driver_Drive_2_OnEnable
[Drive<LinearDriveFacade, LinearDrive>.OnDisable()]: Tilia.Interactions.Controllables.Driver.Drive-2.md#Tilia_Interactions_Controllables_Driver_Drive_2_OnDisable
[Drive<LinearDriveFacade, LinearDrive>.SetUpInternals()]: Tilia.Interactions.Controllables.Driver.Drive-2.md#Tilia_Interactions_Controllables_Driver_Drive_2_SetUpInternals
[Drive<LinearDriveFacade, LinearDrive>.SetDriveTargetValue(Vector3)]: Tilia.Interactions.Controllables.Driver.Drive-2.md#Tilia_Interactions_Controllables_Driver_Drive_2_SetDriveTargetValue_Vector3_
[Drive<LinearDriveFacade, LinearDrive>.EliminateDriveVelocity()]: Tilia.Interactions.Controllables.Driver.Drive-2.md#Tilia_Interactions_Controllables_Driver_Drive_2_EliminateDriveVelocity
[Drive<LinearDriveFacade, LinearDrive>.EmitStartMoving()]: Tilia.Interactions.Controllables.Driver.Drive-2.md#Tilia_Interactions_Controllables_Driver_Drive_2_EmitStartMoving
[Drive<LinearDriveFacade, LinearDrive>.EmitStopMoving()]: Tilia.Interactions.Controllables.Driver.Drive-2.md#Tilia_Interactions_Controllables_Driver_Drive_2_EmitStopMoving
[Drive<LinearDriveFacade, LinearDrive>.CheckStepValueChange()]: Tilia.Interactions.Controllables.Driver.Drive-2.md#Tilia_Interactions_Controllables_Driver_Drive_2_CheckStepValueChange
[Drive<LinearDriveFacade, LinearDrive>.CheckTargetValueReached()]: Tilia.Interactions.Controllables.Driver.Drive-2.md#Tilia_Interactions_Controllables_Driver_Drive_2_CheckTargetValueReached
[Drive<LinearDriveFacade, LinearDrive>.GetTargetValue()]: Tilia.Interactions.Controllables.Driver.Drive-2.md#Tilia_Interactions_Controllables_Driver_Drive_2_GetTargetValue
[Drive<LinearDriveFacade, LinearDrive>.CanMoveToTargetValue()]: Tilia.Interactions.Controllables.Driver.Drive-2.md#Tilia_Interactions_Controllables_Driver_Drive_2_CanMoveToTargetValue
[Drive<LinearDriveFacade, LinearDrive>.CalculateStepValue(LinearDriveFacade)]: Tilia.Interactions.Controllables.Driver.Drive-2.md#Tilia_Interactions_Controllables_Driver_Drive_2_CalculateStepValue__0_
[Drive<LinearDriveFacade, LinearDrive>.EmitValueChanged()]: Tilia.Interactions.Controllables.Driver.Drive-2.md#Tilia_Interactions_Controllables_Driver_Drive_2_EmitValueChanged
[Drive<LinearDriveFacade, LinearDrive>.EmitNormalizedValueChanged()]: Tilia.Interactions.Controllables.Driver.Drive-2.md#Tilia_Interactions_Controllables_Driver_Drive_2_EmitNormalizedValueChanged
[Drive<LinearDriveFacade, LinearDrive>.EmitStepValueChanged()]: Tilia.Interactions.Controllables.Driver.Drive-2.md#Tilia_Interactions_Controllables_Driver_Drive_2_EmitStepValueChanged
[Drive<LinearDriveFacade, LinearDrive>.EmitTargetValueReached()]: Tilia.Interactions.Controllables.Driver.Drive-2.md#Tilia_Interactions_Controllables_Driver_Drive_2_EmitTargetValueReached
[Drive<LinearDriveFacade, LinearDrive>.EmitStartedMoving()]: Tilia.Interactions.Controllables.Driver.Drive-2.md#Tilia_Interactions_Controllables_Driver_Drive_2_EmitStartedMoving
[Drive<LinearDriveFacade, LinearDrive>.EmitStoppedMoving()]: Tilia.Interactions.Controllables.Driver.Drive-2.md#Tilia_Interactions_Controllables_Driver_Drive_2_EmitStoppedMoving
[Drive<LinearDriveFacade, LinearDrive>.MoveToInitialTargetValue()]: Tilia.Interactions.Controllables.Driver.Drive-2.md#Tilia_Interactions_Controllables_Driver_Drive_2_MoveToInitialTargetValue
[Drive<LinearDriveFacade, LinearDrive>.ResetToCacheAfterReachedInitialTargetValue()]: Tilia.Interactions.Controllables.Driver.Drive-2.md#Tilia_Interactions_Controllables_Driver_Drive_2_ResetToCacheAfterReachedInitialTargetValue
[Drive<LinearDriveFacade, LinearDrive>.OnAfterIsGrabbableChange()]: Tilia.Interactions.Controllables.Driver.Drive-2.md#Tilia_Interactions_Controllables_Driver_Drive_2_OnAfterIsGrabbableChange
[Tilia.Interactions.Controllables.LinearDriver]: README.md
[DriveAxis.Axis]: ../Driver/DriveAxis.Axis.md
[Inheritance]: #Inheritance
[Namespace]: #Namespace
[Syntax]: #Syntax
[Properties]: #Properties
[PositionClamper]: #PositionClamper
[PropertyApplier]: #PropertyApplier
[Methods]: #Methods
[CalculateDriveAxis(DriveAxis.Axis)]: #CalculateDriveAxisDriveAxis.Axis
[GetDriveTransform()]: #GetDriveTransform
[Process()]: #Process
[ProcessDriveSpeed(Single, Boolean)]: #ProcessDriveSpeedSingle-Boolean
[SetDriveTargetValue(Vector3)]: #SetDriveTargetValueVector3
[Implements]: #Implements
