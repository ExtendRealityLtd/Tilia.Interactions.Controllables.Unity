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
  * [OnAfterDriveLimitChange()]
  * [OnAfterHingeLocationChange()]
  * [OnDrawGizmosSelected()]
  * [SetDriveLimitMaximum(Single)]
  * [SetDriveLimitMinimum(Single)]
  * [SetHingeLocationX(Single)]
  * [SetHingeLocationY(Single)]
  * [SetHingeLocationZ(Single)]

## Details

##### Inheritance

* System.Object
* [DriveFacade]<[AngularDrive], [AngularDriveFacade]\>
* AngularDriveFacade

##### Inherited Members

[DriveFacade<AngularDrive, AngularDriveFacade>.Drive]

[DriveFacade<AngularDrive, AngularDriveFacade>.LinkedInteractableFacade]

[DriveFacade<AngularDrive, AngularDriveFacade>.LinkedMinReached]

[DriveFacade<AngularDrive, AngularDriveFacade>.LinkedMidReached]

[DriveFacade<AngularDrive, AngularDriveFacade>.LinkedMaxReached]

[DriveFacade<AngularDrive, AngularDriveFacade>.ValueChanged]

[DriveFacade<AngularDrive, AngularDriveFacade>.StepValueChanged]

[DriveFacade<AngularDrive, AngularDriveFacade>.NormalizedValueChanged]

[DriveFacade<AngularDrive, AngularDriveFacade>.InitialTargetValueReached]

[DriveFacade<AngularDrive, AngularDriveFacade>.TargetValueReached]

[DriveFacade<AngularDrive, AngularDriveFacade>.StartedMoving]

[DriveFacade<AngularDrive, AngularDriveFacade>.StoppedMoving]

[DriveFacade<AngularDrive, AngularDriveFacade>.DriveAxis]

[DriveFacade<AngularDrive, AngularDriveFacade>.DriveSpeed]

[DriveFacade<AngularDrive, AngularDriveFacade>.UngrabbedDrag]

[DriveFacade<AngularDrive, AngularDriveFacade>.GrabbedDrag]

[DriveFacade<AngularDrive, AngularDriveFacade>.StartAtInitialTargetValue]

[DriveFacade<AngularDrive, AngularDriveFacade>.InitialTargetValue]

[DriveFacade<AngularDrive, AngularDriveFacade>.MoveToTargetValue]

[DriveFacade<AngularDrive, AngularDriveFacade>.TargetValue]

[DriveFacade<AngularDrive, AngularDriveFacade>.StepRange]

[DriveFacade<AngularDrive, AngularDriveFacade>.StepIncrement]

[DriveFacade<AngularDrive, AngularDriveFacade>.SnapToStepOnRelease]

[DriveFacade<AngularDrive, AngularDriveFacade>.SetDriveAxis(Int32)]

[DriveFacade<AngularDrive, AngularDriveFacade>.SetStepRangeMinimum(Single)]

[DriveFacade<AngularDrive, AngularDriveFacade>.SetStepRangeMaximum(Single)]

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

[DriveFacade<AngularDrive, AngularDriveFacade>.OnAfterSnapToStepOnRelease()]

[DriveFacade<AngularDrive, AngularDriveFacade>.OnAfterUngrabbedDragChange()]

[DriveFacade<AngularDrive, AngularDriveFacade>.OnAfterGrabbedDragChange()]

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

#### OnAfterDriveLimitChange()

Called after [DriveLimit] has been changed.

##### Declaration

```
protected virtual void OnAfterDriveLimitChange()
```

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

#### SetDriveLimitMaximum(Single)

Sets the [DriveLimit] maximum value.

##### Declaration

```
public virtual void SetDriveLimitMaximum(float value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | value | The new maximum value. |

#### SetDriveLimitMinimum(Single)

Sets the [DriveLimit] minimum value.

##### Declaration

```
public virtual void SetDriveLimitMinimum(float value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | value | The new minimum value. |

#### SetHingeLocationX(Single)

Sets the [HingeLocation] x value.

##### Declaration

```
public virtual void SetHingeLocationX(float value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | value | The new x value. |

#### SetHingeLocationY(Single)

Sets the [HingeLocation] y value.

##### Declaration

```
public virtual void SetHingeLocationY(float value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | value | The new y value. |

#### SetHingeLocationZ(Single)

Sets the [HingeLocation] z value.

##### Declaration

```
public virtual void SetHingeLocationZ(float value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | value | The new z value. |

[DriveFacade]: ../Driver/DriveFacade-2.md
[AngularDrive]: AngularDrive.md
[AngularDriveFacade]: AngularDriveFacade.md
[DriveFacade<AngularDrive, AngularDriveFacade>.Drive]: Tilia.Interactions.Controllables.Driver.DriveFacade-2.md#Tilia_Interactions_Controllables_Driver_DriveFacade_2_Drive
[DriveFacade<AngularDrive, AngularDriveFacade>.LinkedInteractableFacade]: Tilia.Interactions.Controllables.Driver.DriveFacade-2.md#Tilia_Interactions_Controllables_Driver_DriveFacade_2_LinkedInteractableFacade
[DriveFacade<AngularDrive, AngularDriveFacade>.LinkedMinReached]: Tilia.Interactions.Controllables.Driver.DriveFacade-2.md#Tilia_Interactions_Controllables_Driver_DriveFacade_2_LinkedMinReached
[DriveFacade<AngularDrive, AngularDriveFacade>.LinkedMidReached]: Tilia.Interactions.Controllables.Driver.DriveFacade-2.md#Tilia_Interactions_Controllables_Driver_DriveFacade_2_LinkedMidReached
[DriveFacade<AngularDrive, AngularDriveFacade>.LinkedMaxReached]: Tilia.Interactions.Controllables.Driver.DriveFacade-2.md#Tilia_Interactions_Controllables_Driver_DriveFacade_2_LinkedMaxReached
[DriveFacade<AngularDrive, AngularDriveFacade>.ValueChanged]: Tilia.Interactions.Controllables.Driver.DriveFacade-2.md#Tilia_Interactions_Controllables_Driver_DriveFacade_2_ValueChanged
[DriveFacade<AngularDrive, AngularDriveFacade>.StepValueChanged]: Tilia.Interactions.Controllables.Driver.DriveFacade-2.md#Tilia_Interactions_Controllables_Driver_DriveFacade_2_StepValueChanged
[DriveFacade<AngularDrive, AngularDriveFacade>.NormalizedValueChanged]: Tilia.Interactions.Controllables.Driver.DriveFacade-2.md#Tilia_Interactions_Controllables_Driver_DriveFacade_2_NormalizedValueChanged
[DriveFacade<AngularDrive, AngularDriveFacade>.InitialTargetValueReached]: Tilia.Interactions.Controllables.Driver.DriveFacade-2.md#Tilia_Interactions_Controllables_Driver_DriveFacade_2_InitialTargetValueReached
[DriveFacade<AngularDrive, AngularDriveFacade>.TargetValueReached]: Tilia.Interactions.Controllables.Driver.DriveFacade-2.md#Tilia_Interactions_Controllables_Driver_DriveFacade_2_TargetValueReached
[DriveFacade<AngularDrive, AngularDriveFacade>.StartedMoving]: Tilia.Interactions.Controllables.Driver.DriveFacade-2.md#Tilia_Interactions_Controllables_Driver_DriveFacade_2_StartedMoving
[DriveFacade<AngularDrive, AngularDriveFacade>.StoppedMoving]: Tilia.Interactions.Controllables.Driver.DriveFacade-2.md#Tilia_Interactions_Controllables_Driver_DriveFacade_2_StoppedMoving
[DriveFacade<AngularDrive, AngularDriveFacade>.DriveAxis]: Tilia.Interactions.Controllables.Driver.DriveFacade-2.md#Tilia_Interactions_Controllables_Driver_DriveFacade_2_DriveAxis
[DriveFacade<AngularDrive, AngularDriveFacade>.DriveSpeed]: Tilia.Interactions.Controllables.Driver.DriveFacade-2.md#Tilia_Interactions_Controllables_Driver_DriveFacade_2_DriveSpeed
[DriveFacade<AngularDrive, AngularDriveFacade>.UngrabbedDrag]: Tilia.Interactions.Controllables.Driver.DriveFacade-2.md#Tilia_Interactions_Controllables_Driver_DriveFacade_2_UngrabbedDrag
[DriveFacade<AngularDrive, AngularDriveFacade>.GrabbedDrag]: Tilia.Interactions.Controllables.Driver.DriveFacade-2.md#Tilia_Interactions_Controllables_Driver_DriveFacade_2_GrabbedDrag
[DriveFacade<AngularDrive, AngularDriveFacade>.StartAtInitialTargetValue]: Tilia.Interactions.Controllables.Driver.DriveFacade-2.md#Tilia_Interactions_Controllables_Driver_DriveFacade_2_StartAtInitialTargetValue
[DriveFacade<AngularDrive, AngularDriveFacade>.InitialTargetValue]: Tilia.Interactions.Controllables.Driver.DriveFacade-2.md#Tilia_Interactions_Controllables_Driver_DriveFacade_2_InitialTargetValue
[DriveFacade<AngularDrive, AngularDriveFacade>.MoveToTargetValue]: Tilia.Interactions.Controllables.Driver.DriveFacade-2.md#Tilia_Interactions_Controllables_Driver_DriveFacade_2_MoveToTargetValue
[DriveFacade<AngularDrive, AngularDriveFacade>.TargetValue]: Tilia.Interactions.Controllables.Driver.DriveFacade-2.md#Tilia_Interactions_Controllables_Driver_DriveFacade_2_TargetValue
[DriveFacade<AngularDrive, AngularDriveFacade>.StepRange]: Tilia.Interactions.Controllables.Driver.DriveFacade-2.md#Tilia_Interactions_Controllables_Driver_DriveFacade_2_StepRange
[DriveFacade<AngularDrive, AngularDriveFacade>.StepIncrement]: Tilia.Interactions.Controllables.Driver.DriveFacade-2.md#Tilia_Interactions_Controllables_Driver_DriveFacade_2_StepIncrement
[DriveFacade<AngularDrive, AngularDriveFacade>.SnapToStepOnRelease]: Tilia.Interactions.Controllables.Driver.DriveFacade-2.md#Tilia_Interactions_Controllables_Driver_DriveFacade_2_SnapToStepOnRelease
[DriveFacade<AngularDrive, AngularDriveFacade>.SetDriveAxis(Int32)]: Tilia.Interactions.Controllables.Driver.DriveFacade-2.md#Tilia_Interactions_Controllables_Driver_DriveFacade_2_SetDriveAxis_System_Int32_
[DriveFacade<AngularDrive, AngularDriveFacade>.SetStepRangeMinimum(Single)]: Tilia.Interactions.Controllables.Driver.DriveFacade-2.md#Tilia_Interactions_Controllables_Driver_DriveFacade_2_SetStepRangeMinimum_System_Single_
[DriveFacade<AngularDrive, AngularDriveFacade>.SetStepRangeMaximum(Single)]: Tilia.Interactions.Controllables.Driver.DriveFacade-2.md#Tilia_Interactions_Controllables_Driver_DriveFacade_2_SetStepRangeMaximum_System_Single_
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
[DriveFacade<AngularDrive, AngularDriveFacade>.OnAfterSnapToStepOnRelease()]: Tilia.Interactions.Controllables.Driver.DriveFacade-2.md#Tilia_Interactions_Controllables_Driver_DriveFacade_2_OnAfterSnapToStepOnRelease
[DriveFacade<AngularDrive, AngularDriveFacade>.OnAfterUngrabbedDragChange()]: Tilia.Interactions.Controllables.Driver.DriveFacade-2.md#Tilia_Interactions_Controllables_Driver_DriveFacade_2_OnAfterUngrabbedDragChange
[DriveFacade<AngularDrive, AngularDriveFacade>.OnAfterGrabbedDragChange()]: Tilia.Interactions.Controllables.Driver.DriveFacade-2.md#Tilia_Interactions_Controllables_Driver_DriveFacade_2_OnAfterGrabbedDragChange
[Tilia.Interactions.Controllables.AngularDriver]: README.md
[DriveLimit]: AngularDriveFacade.md#DriveLimit
[HingeLocation]: AngularDriveFacade.md#HingeLocation
[DriveLimit]: AngularDriveFacade.md#DriveLimit
[DriveLimit]: AngularDriveFacade.md#DriveLimit
[HingeLocation]: AngularDriveFacade.md#HingeLocation
[HingeLocation]: AngularDriveFacade.md#HingeLocation
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
[OnAfterDriveLimitChange()]: #OnAfterDriveLimitChange
[OnAfterHingeLocationChange()]: #OnAfterHingeLocationChange
[OnDrawGizmosSelected()]: #OnDrawGizmosSelected
[SetDriveLimitMaximum(Single)]: #SetDriveLimitMaximumSingle
[SetDriveLimitMinimum(Single)]: #SetDriveLimitMinimumSingle
[SetHingeLocationX(Single)]: #SetHingeLocationXSingle
[SetHingeLocationY(Single)]: #SetHingeLocationYSingle
[SetHingeLocationZ(Single)]: #SetHingeLocationZSingle
