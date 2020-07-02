# Class AngularDriveFacade

The public interface into any RotationalDrive prefab.

## Contents

* [Inheritance]
* [Namespace]
* [Syntax]
* [Properties]
  * [DriveLimit]
  * [GizmoLineDistance]
  * [GizmoSphereRadius]
  * [HingeLocation]
* [Methods]
  * [OnAfterHingeLocationChange()]
  * [OnDrawGizmosSelected()]

## Details

##### Inheritance

* System.Object
* [DriveFacade]<[AngularDrive], [AngularDriveFacade]\>
* AngularDriveFacade

##### Inherited Members

[DriveFacade<AngularDrive, AngularDriveFacade>.Drive]

[DriveFacade<AngularDrive, AngularDriveFacade>.ValueChanged]

[DriveFacade<AngularDrive, AngularDriveFacade>.StepValueChanged]

[DriveFacade<AngularDrive, AngularDriveFacade>.NormalizedValueChanged]

[DriveFacade<AngularDrive, AngularDriveFacade>.InitialTargetValueReached]

[DriveFacade<AngularDrive, AngularDriveFacade>.TargetValueReached]

[DriveFacade<AngularDrive, AngularDriveFacade>.StartedMoving]

[DriveFacade<AngularDrive, AngularDriveFacade>.StoppedMoving]

[DriveFacade<AngularDrive, AngularDriveFacade>.DriveAxis]

[DriveFacade<AngularDrive, AngularDriveFacade>.DriveSpeed]

[DriveFacade<AngularDrive, AngularDriveFacade>.StartAtInitialTargetValue]

[DriveFacade<AngularDrive, AngularDriveFacade>.InitialTargetValue]

[DriveFacade<AngularDrive, AngularDriveFacade>.MoveToTargetValue]

[DriveFacade<AngularDrive, AngularDriveFacade>.TargetValue]

[DriveFacade<AngularDrive, AngularDriveFacade>.StepRange]

[DriveFacade<AngularDrive, AngularDriveFacade>.StepIncrement]

[DriveFacade<AngularDrive, AngularDriveFacade>.SetTargetValueByStepValue()]

[DriveFacade<AngularDrive, AngularDriveFacade>.SetTargetValueByStepValue(Single)]

[DriveFacade<AngularDrive, AngularDriveFacade>.ForceSnapToStepValue(Single)]

[DriveFacade<AngularDrive, AngularDriveFacade>.CalculateDriveAxis(DriveAxis.Axis)]

[DriveFacade<AngularDrive, AngularDriveFacade>.ProcessAutoDrive(Boolean)]

[DriveFacade<AngularDrive, AngularDriveFacade>.SetTargetValue(Single)]

[DriveFacade<AngularDrive, AngularDriveFacade>.ProcessDriveSpeed(Single, Boolean)]

[DriveFacade<AngularDrive, AngularDriveFacade>.OnAfterDriveAxisChange()]

[DriveFacade<AngularDrive, AngularDriveFacade>.OnAfterMoveToTargetValueChange()]

[DriveFacade<AngularDrive, AngularDriveFacade>.OnAfterTargetValueChange()]

[DriveFacade<AngularDrive, AngularDriveFacade>.OnAfterDriveSpeedChange()]

[DriveFacade<AngularDrive, AngularDriveFacade>.OnAfterStepRangeChange()]

[DriveFacade<AngularDrive, AngularDriveFacade>.OnAfterStepIncrementChange()]

##### Namespace

* [Tilia.Interactions.Controllables.AngularDriver]

##### Syntax

```
public class AngularDriveFacade : DriveFacade<AngularDrive, AngularDriveFacade>
```

### Properties

#### DriveLimit

The rotational angle limits for the drive.

##### Declaration

```
public FloatRange DriveLimit { get; set; }
```

#### GizmoLineDistance

The distance of the gizmo hinge location line.

##### Declaration

```
public float GizmoLineDistance { get; set; }
```

#### GizmoSphereRadius

The radius of the gizmo hinge location end sphere.

##### Declaration

```
public float GizmoSphereRadius { get; set; }
```

#### HingeLocation

The location of the hinge within the local position of the drive.

##### Declaration

```
public Vector3 HingeLocation { get; set; }
```

### Methods

#### OnAfterHingeLocationChange()

Called after [HingeLocation] has been changed.

##### Declaration

```
protected virtual void OnAfterHingeLocationChange()
```

#### OnDrawGizmosSelected()

##### Declaration

```
protected virtual void OnDrawGizmosSelected()
```

[DriveFacade]: ../Driver/DriveFacade-2.md
[AngularDrive]: AngularDrive.md
[AngularDriveFacade]: AngularDriveFacade.md
[DriveFacade<AngularDrive, AngularDriveFacade>.Drive]: Tilia.Interactions.Controllables.Driver.DriveFacade-2.md#Tilia_Interactions_Controllables_Driver_DriveFacade_2_Drive
[DriveFacade<AngularDrive, AngularDriveFacade>.ValueChanged]: Tilia.Interactions.Controllables.Driver.DriveFacade-2.md#Tilia_Interactions_Controllables_Driver_DriveFacade_2_ValueChanged
[DriveFacade<AngularDrive, AngularDriveFacade>.StepValueChanged]: Tilia.Interactions.Controllables.Driver.DriveFacade-2.md#Tilia_Interactions_Controllables_Driver_DriveFacade_2_StepValueChanged
[DriveFacade<AngularDrive, AngularDriveFacade>.NormalizedValueChanged]: Tilia.Interactions.Controllables.Driver.DriveFacade-2.md#Tilia_Interactions_Controllables_Driver_DriveFacade_2_NormalizedValueChanged
[DriveFacade<AngularDrive, AngularDriveFacade>.InitialTargetValueReached]: Tilia.Interactions.Controllables.Driver.DriveFacade-2.md#Tilia_Interactions_Controllables_Driver_DriveFacade_2_InitialTargetValueReached
[DriveFacade<AngularDrive, AngularDriveFacade>.TargetValueReached]: Tilia.Interactions.Controllables.Driver.DriveFacade-2.md#Tilia_Interactions_Controllables_Driver_DriveFacade_2_TargetValueReached
[DriveFacade<AngularDrive, AngularDriveFacade>.StartedMoving]: Tilia.Interactions.Controllables.Driver.DriveFacade-2.md#Tilia_Interactions_Controllables_Driver_DriveFacade_2_StartedMoving
[DriveFacade<AngularDrive, AngularDriveFacade>.StoppedMoving]: Tilia.Interactions.Controllables.Driver.DriveFacade-2.md#Tilia_Interactions_Controllables_Driver_DriveFacade_2_StoppedMoving
[DriveFacade<AngularDrive, AngularDriveFacade>.DriveAxis]: Tilia.Interactions.Controllables.Driver.DriveFacade-2.md#Tilia_Interactions_Controllables_Driver_DriveFacade_2_DriveAxis
[DriveFacade<AngularDrive, AngularDriveFacade>.DriveSpeed]: Tilia.Interactions.Controllables.Driver.DriveFacade-2.md#Tilia_Interactions_Controllables_Driver_DriveFacade_2_DriveSpeed
[DriveFacade<AngularDrive, AngularDriveFacade>.StartAtInitialTargetValue]: Tilia.Interactions.Controllables.Driver.DriveFacade-2.md#Tilia_Interactions_Controllables_Driver_DriveFacade_2_StartAtInitialTargetValue
[DriveFacade<AngularDrive, AngularDriveFacade>.InitialTargetValue]: Tilia.Interactions.Controllables.Driver.DriveFacade-2.md#Tilia_Interactions_Controllables_Driver_DriveFacade_2_InitialTargetValue
[DriveFacade<AngularDrive, AngularDriveFacade>.MoveToTargetValue]: Tilia.Interactions.Controllables.Driver.DriveFacade-2.md#Tilia_Interactions_Controllables_Driver_DriveFacade_2_MoveToTargetValue
[DriveFacade<AngularDrive, AngularDriveFacade>.TargetValue]: Tilia.Interactions.Controllables.Driver.DriveFacade-2.md#Tilia_Interactions_Controllables_Driver_DriveFacade_2_TargetValue
[DriveFacade<AngularDrive, AngularDriveFacade>.StepRange]: Tilia.Interactions.Controllables.Driver.DriveFacade-2.md#Tilia_Interactions_Controllables_Driver_DriveFacade_2_StepRange
[DriveFacade<AngularDrive, AngularDriveFacade>.StepIncrement]: Tilia.Interactions.Controllables.Driver.DriveFacade-2.md#Tilia_Interactions_Controllables_Driver_DriveFacade_2_StepIncrement
[DriveFacade<AngularDrive, AngularDriveFacade>.SetTargetValueByStepValue()]: Tilia.Interactions.Controllables.Driver.DriveFacade-2.md#Tilia_Interactions_Controllables_Driver_DriveFacade_2_SetTargetValueByStepValue
[DriveFacade<AngularDrive, AngularDriveFacade>.SetTargetValueByStepValue(Single)]: Tilia.Interactions.Controllables.Driver.DriveFacade-2.md#Tilia_Interactions_Controllables_Driver_DriveFacade_2_SetTargetValueByStepValue_System_Single_
[DriveFacade<AngularDrive, AngularDriveFacade>.ForceSnapToStepValue(Single)]: Tilia.Interactions.Controllables.Driver.DriveFacade-2.md#Tilia_Interactions_Controllables_Driver_DriveFacade_2_ForceSnapToStepValue_System_Single_
[DriveFacade<AngularDrive, AngularDriveFacade>.CalculateDriveAxis(DriveAxis.Axis)]: Tilia.Interactions.Controllables.Driver.DriveFacade-2.md#Tilia_Interactions_Controllables_Driver_DriveFacade_2_CalculateDriveAxis_Tilia_Interactions_Controllables_Driver_DriveAxis_Axis_
[DriveFacade<AngularDrive, AngularDriveFacade>.ProcessAutoDrive(Boolean)]: Tilia.Interactions.Controllables.Driver.DriveFacade-2.md#Tilia_Interactions_Controllables_Driver_DriveFacade_2_ProcessAutoDrive_System_Boolean_
[DriveFacade<AngularDrive, AngularDriveFacade>.SetTargetValue(Single)]: Tilia.Interactions.Controllables.Driver.DriveFacade-2.md#Tilia_Interactions_Controllables_Driver_DriveFacade_2_SetTargetValue_System_Single_
[DriveFacade<AngularDrive, AngularDriveFacade>.ProcessDriveSpeed(Single, Boolean)]: Tilia.Interactions.Controllables.Driver.DriveFacade-2.md#Tilia_Interactions_Controllables_Driver_DriveFacade_2_ProcessDriveSpeed_System_Single_System_Boolean_
[DriveFacade<AngularDrive, AngularDriveFacade>.OnAfterDriveAxisChange()]: Tilia.Interactions.Controllables.Driver.DriveFacade-2.md#Tilia_Interactions_Controllables_Driver_DriveFacade_2_OnAfterDriveAxisChange
[DriveFacade<AngularDrive, AngularDriveFacade>.OnAfterMoveToTargetValueChange()]: Tilia.Interactions.Controllables.Driver.DriveFacade-2.md#Tilia_Interactions_Controllables_Driver_DriveFacade_2_OnAfterMoveToTargetValueChange
[DriveFacade<AngularDrive, AngularDriveFacade>.OnAfterTargetValueChange()]: Tilia.Interactions.Controllables.Driver.DriveFacade-2.md#Tilia_Interactions_Controllables_Driver_DriveFacade_2_OnAfterTargetValueChange
[DriveFacade<AngularDrive, AngularDriveFacade>.OnAfterDriveSpeedChange()]: Tilia.Interactions.Controllables.Driver.DriveFacade-2.md#Tilia_Interactions_Controllables_Driver_DriveFacade_2_OnAfterDriveSpeedChange
[DriveFacade<AngularDrive, AngularDriveFacade>.OnAfterStepRangeChange()]: Tilia.Interactions.Controllables.Driver.DriveFacade-2.md#Tilia_Interactions_Controllables_Driver_DriveFacade_2_OnAfterStepRangeChange
[DriveFacade<AngularDrive, AngularDriveFacade>.OnAfterStepIncrementChange()]: Tilia.Interactions.Controllables.Driver.DriveFacade-2.md#Tilia_Interactions_Controllables_Driver_DriveFacade_2_OnAfterStepIncrementChange
[Tilia.Interactions.Controllables.AngularDriver]: README.md
[HingeLocation]: AngularDriveFacade.md#HingeLocation
[Inheritance]: #Inheritance
[Namespace]: #Namespace
[Syntax]: #Syntax
[Properties]: #Properties
[DriveLimit]: #DriveLimit
[GizmoLineDistance]: #GizmoLineDistance
[GizmoSphereRadius]: #GizmoSphereRadius
[HingeLocation]: #HingeLocation
[Methods]: #Methods
[OnAfterHingeLocationChange()]: #OnAfterHingeLocationChange
[OnDrawGizmosSelected()]: #OnDrawGizmosSelected
