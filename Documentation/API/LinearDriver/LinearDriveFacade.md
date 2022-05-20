# Class LinearDriveFacade

The public interface into any Linear Drive prefab.

## Contents

* [Inheritance]
* [Namespace]
* [Syntax]
* [Properties]
  * [DriveLimit]
  * [GizmoCubeSize]
* [Methods]
  * [OnAfterDriveLimitChange()]
  * [OnDrawGizmosSelected()]

## Details

##### Inheritance

* System.Object
* [DriveFacade]<[LinearDrive], [LinearDriveFacade]\>
* LinearDriveFacade

##### Inherited Members

[DriveFacade<LinearDrive, LinearDriveFacade>.Drive]

[DriveFacade<LinearDrive, LinearDriveFacade>.LinkedInteractableFacade]

[DriveFacade<LinearDrive, LinearDriveFacade>.LinkedMinReached]

[DriveFacade<LinearDrive, LinearDriveFacade>.LinkedMidReached]

[DriveFacade<LinearDrive, LinearDriveFacade>.LinkedMaxReached]

[DriveFacade<LinearDrive, LinearDriveFacade>.ValueChanged]

[DriveFacade<LinearDrive, LinearDriveFacade>.StepValueChanged]

[DriveFacade<LinearDrive, LinearDriveFacade>.NormalizedValueChanged]

[DriveFacade<LinearDrive, LinearDriveFacade>.InitialTargetValueReached]

[DriveFacade<LinearDrive, LinearDriveFacade>.TargetValueReached]

[DriveFacade<LinearDrive, LinearDriveFacade>.StartedMoving]

[DriveFacade<LinearDrive, LinearDriveFacade>.StoppedMoving]

[DriveFacade<LinearDrive, LinearDriveFacade>.DriveAxis]

[DriveFacade<LinearDrive, LinearDriveFacade>.DriveSpeed]

[DriveFacade<LinearDrive, LinearDriveFacade>.UngrabbedDrag]

[DriveFacade<LinearDrive, LinearDriveFacade>.GrabbedDrag]

[DriveFacade<LinearDrive, LinearDriveFacade>.StartAtInitialTargetValue]

[DriveFacade<LinearDrive, LinearDriveFacade>.InitialTargetValue]

[DriveFacade<LinearDrive, LinearDriveFacade>.MoveToTargetValue]

[DriveFacade<LinearDrive, LinearDriveFacade>.TargetValue]

[DriveFacade<LinearDrive, LinearDriveFacade>.StepRange]

[DriveFacade<LinearDrive, LinearDriveFacade>.StepIncrement]

[DriveFacade<LinearDrive, LinearDriveFacade>.SnapToStepOnRelease]

[DriveFacade<LinearDrive, LinearDriveFacade>.SetDriveAxis(Int32)]

[DriveFacade<LinearDrive, LinearDriveFacade>.SetStepRangeMinimum(Single)]

[DriveFacade<LinearDrive, LinearDriveFacade>.SetStepRangeMaximum(Single)]

[DriveFacade<LinearDrive, LinearDriveFacade>.SetTargetValueByStepValue()]

[DriveFacade<LinearDrive, LinearDriveFacade>.SetTargetValueByStepValue(Single)]

[DriveFacade<LinearDrive, LinearDriveFacade>.ForceSnapToStepValue(Single)]

[DriveFacade<LinearDrive, LinearDriveFacade>.CalculateDriveAxis(DriveAxis.Axis)]

[DriveFacade<LinearDrive, LinearDriveFacade>.ProcessAutoDrive(Boolean)]

[DriveFacade<LinearDrive, LinearDriveFacade>.SetTargetValue(Single)]

[DriveFacade<LinearDrive, LinearDriveFacade>.ProcessDriveSpeed(Single, Boolean)]

[DriveFacade<LinearDrive, LinearDriveFacade>.OnAfterDriveAxisChange()]

[DriveFacade<LinearDrive, LinearDriveFacade>.OnAfterMoveToTargetValueChange()]

[DriveFacade<LinearDrive, LinearDriveFacade>.OnAfterTargetValueChange()]

[DriveFacade<LinearDrive, LinearDriveFacade>.OnAfterDriveSpeedChange()]

[DriveFacade<LinearDrive, LinearDriveFacade>.OnAfterStepRangeChange()]

[DriveFacade<LinearDrive, LinearDriveFacade>.OnAfterStepIncrementChange()]

[DriveFacade<LinearDrive, LinearDriveFacade>.OnAfterSnapToStepOnRelease()]

[DriveFacade<LinearDrive, LinearDriveFacade>.OnAfterUngrabbedDragChange()]

[DriveFacade<LinearDrive, LinearDriveFacade>.OnAfterGrabbedDragChange()]

##### Namespace

* [Tilia.Interactions.Controllables.LinearDriver]

##### Syntax

```
public class LinearDriveFacade : DriveFacade<LinearDrive, LinearDriveFacade>
```

### Properties

#### DriveLimit

The world space limit of the drive direction along the specified axis.

##### Declaration

```
public float DriveLimit { get; set; }
```

#### GizmoCubeSize

The size of the gizmo cube to draw at the limits of the drive.

##### Declaration

```
public Vector3 GizmoCubeSize { get; set; }
```

### Methods

#### OnAfterDriveLimitChange()

Called after [DriveLimit] has been changed.

##### Declaration

```
protected virtual void OnAfterDriveLimitChange()
```

#### OnDrawGizmosSelected()

##### Declaration

```
protected virtual void OnDrawGizmosSelected()
```

[DriveFacade]: ../Driver/DriveFacade-2.md
[LinearDrive]: LinearDrive.md
[LinearDriveFacade]: LinearDriveFacade.md
[DriveFacade<LinearDrive, LinearDriveFacade>.Drive]: Tilia.Interactions.Controllables.Driver.DriveFacade-2.md#Tilia_Interactions_Controllables_Driver_DriveFacade_2_Drive
[DriveFacade<LinearDrive, LinearDriveFacade>.LinkedInteractableFacade]: Tilia.Interactions.Controllables.Driver.DriveFacade-2.md#Tilia_Interactions_Controllables_Driver_DriveFacade_2_LinkedInteractableFacade
[DriveFacade<LinearDrive, LinearDriveFacade>.LinkedMinReached]: Tilia.Interactions.Controllables.Driver.DriveFacade-2.md#Tilia_Interactions_Controllables_Driver_DriveFacade_2_LinkedMinReached
[DriveFacade<LinearDrive, LinearDriveFacade>.LinkedMidReached]: Tilia.Interactions.Controllables.Driver.DriveFacade-2.md#Tilia_Interactions_Controllables_Driver_DriveFacade_2_LinkedMidReached
[DriveFacade<LinearDrive, LinearDriveFacade>.LinkedMaxReached]: Tilia.Interactions.Controllables.Driver.DriveFacade-2.md#Tilia_Interactions_Controllables_Driver_DriveFacade_2_LinkedMaxReached
[DriveFacade<LinearDrive, LinearDriveFacade>.ValueChanged]: Tilia.Interactions.Controllables.Driver.DriveFacade-2.md#Tilia_Interactions_Controllables_Driver_DriveFacade_2_ValueChanged
[DriveFacade<LinearDrive, LinearDriveFacade>.StepValueChanged]: Tilia.Interactions.Controllables.Driver.DriveFacade-2.md#Tilia_Interactions_Controllables_Driver_DriveFacade_2_StepValueChanged
[DriveFacade<LinearDrive, LinearDriveFacade>.NormalizedValueChanged]: Tilia.Interactions.Controllables.Driver.DriveFacade-2.md#Tilia_Interactions_Controllables_Driver_DriveFacade_2_NormalizedValueChanged
[DriveFacade<LinearDrive, LinearDriveFacade>.InitialTargetValueReached]: Tilia.Interactions.Controllables.Driver.DriveFacade-2.md#Tilia_Interactions_Controllables_Driver_DriveFacade_2_InitialTargetValueReached
[DriveFacade<LinearDrive, LinearDriveFacade>.TargetValueReached]: Tilia.Interactions.Controllables.Driver.DriveFacade-2.md#Tilia_Interactions_Controllables_Driver_DriveFacade_2_TargetValueReached
[DriveFacade<LinearDrive, LinearDriveFacade>.StartedMoving]: Tilia.Interactions.Controllables.Driver.DriveFacade-2.md#Tilia_Interactions_Controllables_Driver_DriveFacade_2_StartedMoving
[DriveFacade<LinearDrive, LinearDriveFacade>.StoppedMoving]: Tilia.Interactions.Controllables.Driver.DriveFacade-2.md#Tilia_Interactions_Controllables_Driver_DriveFacade_2_StoppedMoving
[DriveFacade<LinearDrive, LinearDriveFacade>.DriveAxis]: Tilia.Interactions.Controllables.Driver.DriveFacade-2.md#Tilia_Interactions_Controllables_Driver_DriveFacade_2_DriveAxis
[DriveFacade<LinearDrive, LinearDriveFacade>.DriveSpeed]: Tilia.Interactions.Controllables.Driver.DriveFacade-2.md#Tilia_Interactions_Controllables_Driver_DriveFacade_2_DriveSpeed
[DriveFacade<LinearDrive, LinearDriveFacade>.UngrabbedDrag]: Tilia.Interactions.Controllables.Driver.DriveFacade-2.md#Tilia_Interactions_Controllables_Driver_DriveFacade_2_UngrabbedDrag
[DriveFacade<LinearDrive, LinearDriveFacade>.GrabbedDrag]: Tilia.Interactions.Controllables.Driver.DriveFacade-2.md#Tilia_Interactions_Controllables_Driver_DriveFacade_2_GrabbedDrag
[DriveFacade<LinearDrive, LinearDriveFacade>.StartAtInitialTargetValue]: Tilia.Interactions.Controllables.Driver.DriveFacade-2.md#Tilia_Interactions_Controllables_Driver_DriveFacade_2_StartAtInitialTargetValue
[DriveFacade<LinearDrive, LinearDriveFacade>.InitialTargetValue]: Tilia.Interactions.Controllables.Driver.DriveFacade-2.md#Tilia_Interactions_Controllables_Driver_DriveFacade_2_InitialTargetValue
[DriveFacade<LinearDrive, LinearDriveFacade>.MoveToTargetValue]: Tilia.Interactions.Controllables.Driver.DriveFacade-2.md#Tilia_Interactions_Controllables_Driver_DriveFacade_2_MoveToTargetValue
[DriveFacade<LinearDrive, LinearDriveFacade>.TargetValue]: Tilia.Interactions.Controllables.Driver.DriveFacade-2.md#Tilia_Interactions_Controllables_Driver_DriveFacade_2_TargetValue
[DriveFacade<LinearDrive, LinearDriveFacade>.StepRange]: Tilia.Interactions.Controllables.Driver.DriveFacade-2.md#Tilia_Interactions_Controllables_Driver_DriveFacade_2_StepRange
[DriveFacade<LinearDrive, LinearDriveFacade>.StepIncrement]: Tilia.Interactions.Controllables.Driver.DriveFacade-2.md#Tilia_Interactions_Controllables_Driver_DriveFacade_2_StepIncrement
[DriveFacade<LinearDrive, LinearDriveFacade>.SnapToStepOnRelease]: Tilia.Interactions.Controllables.Driver.DriveFacade-2.md#Tilia_Interactions_Controllables_Driver_DriveFacade_2_SnapToStepOnRelease
[DriveFacade<LinearDrive, LinearDriveFacade>.SetDriveAxis(Int32)]: Tilia.Interactions.Controllables.Driver.DriveFacade-2.md#Tilia_Interactions_Controllables_Driver_DriveFacade_2_SetDriveAxis_System_Int32_
[DriveFacade<LinearDrive, LinearDriveFacade>.SetStepRangeMinimum(Single)]: Tilia.Interactions.Controllables.Driver.DriveFacade-2.md#Tilia_Interactions_Controllables_Driver_DriveFacade_2_SetStepRangeMinimum_System_Single_
[DriveFacade<LinearDrive, LinearDriveFacade>.SetStepRangeMaximum(Single)]: Tilia.Interactions.Controllables.Driver.DriveFacade-2.md#Tilia_Interactions_Controllables_Driver_DriveFacade_2_SetStepRangeMaximum_System_Single_
[DriveFacade<LinearDrive, LinearDriveFacade>.SetTargetValueByStepValue()]: Tilia.Interactions.Controllables.Driver.DriveFacade-2.md#Tilia_Interactions_Controllables_Driver_DriveFacade_2_SetTargetValueByStepValue
[DriveFacade<LinearDrive, LinearDriveFacade>.SetTargetValueByStepValue(Single)]: Tilia.Interactions.Controllables.Driver.DriveFacade-2.md#Tilia_Interactions_Controllables_Driver_DriveFacade_2_SetTargetValueByStepValue_System_Single_
[DriveFacade<LinearDrive, LinearDriveFacade>.ForceSnapToStepValue(Single)]: Tilia.Interactions.Controllables.Driver.DriveFacade-2.md#Tilia_Interactions_Controllables_Driver_DriveFacade_2_ForceSnapToStepValue_System_Single_
[DriveFacade<LinearDrive, LinearDriveFacade>.CalculateDriveAxis(DriveAxis.Axis)]: Tilia.Interactions.Controllables.Driver.DriveFacade-2.md#Tilia_Interactions_Controllables_Driver_DriveFacade_2_CalculateDriveAxis_Tilia_Interactions_Controllables_Driver_DriveAxis_Axis_
[DriveFacade<LinearDrive, LinearDriveFacade>.ProcessAutoDrive(Boolean)]: Tilia.Interactions.Controllables.Driver.DriveFacade-2.md#Tilia_Interactions_Controllables_Driver_DriveFacade_2_ProcessAutoDrive_System_Boolean_
[DriveFacade<LinearDrive, LinearDriveFacade>.SetTargetValue(Single)]: Tilia.Interactions.Controllables.Driver.DriveFacade-2.md#Tilia_Interactions_Controllables_Driver_DriveFacade_2_SetTargetValue_System_Single_
[DriveFacade<LinearDrive, LinearDriveFacade>.ProcessDriveSpeed(Single, Boolean)]: Tilia.Interactions.Controllables.Driver.DriveFacade-2.md#Tilia_Interactions_Controllables_Driver_DriveFacade_2_ProcessDriveSpeed_System_Single_System_Boolean_
[DriveFacade<LinearDrive, LinearDriveFacade>.OnAfterDriveAxisChange()]: Tilia.Interactions.Controllables.Driver.DriveFacade-2.md#Tilia_Interactions_Controllables_Driver_DriveFacade_2_OnAfterDriveAxisChange
[DriveFacade<LinearDrive, LinearDriveFacade>.OnAfterMoveToTargetValueChange()]: Tilia.Interactions.Controllables.Driver.DriveFacade-2.md#Tilia_Interactions_Controllables_Driver_DriveFacade_2_OnAfterMoveToTargetValueChange
[DriveFacade<LinearDrive, LinearDriveFacade>.OnAfterTargetValueChange()]: Tilia.Interactions.Controllables.Driver.DriveFacade-2.md#Tilia_Interactions_Controllables_Driver_DriveFacade_2_OnAfterTargetValueChange
[DriveFacade<LinearDrive, LinearDriveFacade>.OnAfterDriveSpeedChange()]: Tilia.Interactions.Controllables.Driver.DriveFacade-2.md#Tilia_Interactions_Controllables_Driver_DriveFacade_2_OnAfterDriveSpeedChange
[DriveFacade<LinearDrive, LinearDriveFacade>.OnAfterStepRangeChange()]: Tilia.Interactions.Controllables.Driver.DriveFacade-2.md#Tilia_Interactions_Controllables_Driver_DriveFacade_2_OnAfterStepRangeChange
[DriveFacade<LinearDrive, LinearDriveFacade>.OnAfterStepIncrementChange()]: Tilia.Interactions.Controllables.Driver.DriveFacade-2.md#Tilia_Interactions_Controllables_Driver_DriveFacade_2_OnAfterStepIncrementChange
[DriveFacade<LinearDrive, LinearDriveFacade>.OnAfterSnapToStepOnRelease()]: Tilia.Interactions.Controllables.Driver.DriveFacade-2.md#Tilia_Interactions_Controllables_Driver_DriveFacade_2_OnAfterSnapToStepOnRelease
[DriveFacade<LinearDrive, LinearDriveFacade>.OnAfterUngrabbedDragChange()]: Tilia.Interactions.Controllables.Driver.DriveFacade-2.md#Tilia_Interactions_Controllables_Driver_DriveFacade_2_OnAfterUngrabbedDragChange
[DriveFacade<LinearDrive, LinearDriveFacade>.OnAfterGrabbedDragChange()]: Tilia.Interactions.Controllables.Driver.DriveFacade-2.md#Tilia_Interactions_Controllables_Driver_DriveFacade_2_OnAfterGrabbedDragChange
[Tilia.Interactions.Controllables.LinearDriver]: README.md
[DriveLimit]: LinearDriveFacade.md#DriveLimit
[Inheritance]: #Inheritance
[Namespace]: #Namespace
[Syntax]: #Syntax
[Properties]: #Properties
[DriveLimit]: #DriveLimit
[GizmoCubeSize]: #GizmoCubeSize
[Methods]: #Methods
[OnAfterDriveLimitChange()]: #OnAfterDriveLimitChange
[OnDrawGizmosSelected()]: #OnDrawGizmosSelected
