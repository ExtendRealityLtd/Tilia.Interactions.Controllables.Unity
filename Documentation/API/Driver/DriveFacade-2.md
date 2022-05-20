# Class DriveFacade<TDrive, TSelf>

The basis of the public interface that will drive a control in relation to a specified world axis.

## Contents

* [Inheritance]
* [Namespace]
* [Syntax]
* [Fields]
  * [InitialTargetValueReached]
  * [NormalizedValueChanged]
  * [StartedMoving]
  * [StepValueChanged]
  * [StoppedMoving]
  * [TargetValueReached]
  * [ValueChanged]
* [Properties]
  * [Drive]
  * [DriveAxis]
  * [DriveSpeed]
  * [GrabbedDrag]
  * [InitialTargetValue]
  * [LinkedInteractableFacade]
  * [LinkedMaxReached]
  * [LinkedMidReached]
  * [LinkedMinReached]
  * [MoveToTargetValue]
  * [SnapToStepOnRelease]
  * [StartAtInitialTargetValue]
  * [StepIncrement]
  * [StepRange]
  * [TargetValue]
  * [UngrabbedDrag]
* [Methods]
  * [CalculateDriveAxis(DriveAxis.Axis)]
  * [ForceSnapToStepValue(Single)]
  * [OnAfterDriveAxisChange()]
  * [OnAfterDriveSpeedChange()]
  * [OnAfterGrabbedDragChange()]
  * [OnAfterMoveToTargetValueChange()]
  * [OnAfterSnapToStepOnRelease()]
  * [OnAfterStepIncrementChange()]
  * [OnAfterStepRangeChange()]
  * [OnAfterTargetValueChange()]
  * [OnAfterUngrabbedDragChange()]
  * [ProcessAutoDrive(Boolean)]
  * [ProcessDriveSpeed(Single, Boolean)]
  * [SetDriveAxis(Int32)]
  * [SetStepRangeMaximum(Single)]
  * [SetStepRangeMinimum(Single)]
  * [SetTargetValue(Single)]
  * [SetTargetValueByStepValue()]
  * [SetTargetValueByStepValue(Single)]

## Details

##### Inheritance

* System.Object
* DriveFacade<TDrive, TSelf>
* [AngularDriveFacade]
* [LinearDriveFacade]

##### Namespace

* [Tilia.Interactions.Controllables.Driver]

##### Syntax

```
public abstract class DriveFacade<TDrive, TSelf> : MonoBehaviour where TDrive : Drive<TSelf, TDrive> where TSelf : DriveFacade<TDrive, TSelf>
```

##### Type Parameters

| Name | Description |
| --- | --- |
| TDrive | The [Drive<TFacade, TSelf>] to operate with the facade. |
| TSelf | The actual concrete implementation of the drive facade being used. |

### Fields

#### InitialTargetValueReached

Emitted when [InitialTargetValue] has been reached by the control.

##### Declaration

```
public DriveUnityEvent InitialTargetValueReached
```

#### NormalizedValueChanged

Emitted when the normalized value changes with the normalized value data.

##### Declaration

```
public DriveUnityEvent NormalizedValueChanged
```

#### StartedMoving

Emitted when the drive starts moving the control.

##### Declaration

```
public DriveUnityEvent StartedMoving
```

#### StepValueChanged

Emitted when the step value changes with the step value data.

##### Declaration

```
public DriveUnityEvent StepValueChanged
```

#### StoppedMoving

Emitted when the drive is no longer moving the control and it is stationary.

##### Declaration

```
public DriveUnityEvent StoppedMoving
```

#### TargetValueReached

Emitted when [TargetValue] has been reached by the control.

##### Declaration

```
public DriveUnityEvent TargetValueReached
```

#### ValueChanged

Emitted when the raw value changes with the raw value data.

##### Declaration

```
public DriveUnityEvent ValueChanged
```

### Properties

#### Drive

The linked TDrive

##### Declaration

```
public TDrive Drive { get; protected set; }
```

#### DriveAxis

The axis to operate the drive motion on.

##### Declaration

```
public DriveAxis.Axis DriveAxis { get; set; }
```

#### DriveSpeed

The speed in which the drive will attempt to move the control to the desired value.

##### Declaration

```
public float DriveSpeed { get; set; }
```

#### GrabbedDrag

The drag to apply when the control is grabbed.

##### Declaration

```
public float GrabbedDrag { get; set; }
```

#### InitialTargetValue

The normalized value to attempt to drive the control to when it is first enabled.

##### Declaration

```
public float InitialTargetValue { get; set; }
```

#### LinkedInteractableFacade

The GameObject reference for the nested Interactable.

##### Declaration

```
public ObjectReference LinkedInteractableFacade { get; protected set; }
```

#### LinkedMaxReached

The GameObject reference for the nested max value reached event.

##### Declaration

```
public ObjectReference LinkedMaxReached { get; protected set; }
```

#### LinkedMidReached

The GameObject reference for the nested mid point value reached event.

##### Declaration

```
public ObjectReference LinkedMidReached { get; protected set; }
```

#### LinkedMinReached

The GameObject reference for the nested minimum value reached event.

##### Declaration

```
public ObjectReference LinkedMinReached { get; protected set; }
```

#### MoveToTargetValue

Determines if the drive should move the element to the set [TargetValue].

##### Declaration

```
public bool MoveToTargetValue { get; set; }
```

#### SnapToStepOnRelease

Attempt to snap to the step value upon releasing the control.

##### Declaration

```
public bool SnapToStepOnRelease { get; set; }
```

#### StartAtInitialTargetValue

Determines if the drive should start the control at the [InitialTargetValue] when it is first enabled (no events will be emitted).

##### Declaration

```
public bool StartAtInitialTargetValue { get; set; }
```

#### StepIncrement

The increment to increase the steps in value by.

##### Declaration

```
public float StepIncrement { get; set; }
```

#### StepRange

The range of step values to use.

##### Declaration

```
public FloatRange StepRange { get; set; }
```

#### TargetValue

The normalized value to attempt to drive the control to if the [MoveToTargetValue] is set to true.

##### Declaration

```
public float TargetValue { get; set; }
```

#### UngrabbedDrag

The drag to apply when the control is ungrabbed.

##### Declaration

```
public float UngrabbedDrag { get; set; }
```

### Methods

#### CalculateDriveAxis(DriveAxis.Axis)

Calculates the axis to use for the given [DriveAxis.Axis].

##### Declaration

```
protected virtual void CalculateDriveAxis(DriveAxis.Axis driveAxis)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [DriveAxis.Axis] | driveAxis | The new value. |

#### ForceSnapToStepValue(Single)

Forces the drive to move to the current step value at the given speed.

##### Declaration

```
public virtual void ForceSnapToStepValue(float driveSpeed)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | driveSpeed | The speed the drive will move the control at. |

#### OnAfterDriveAxisChange()

Called after [DriveAxis] has been changed.

##### Declaration

```
protected virtual void OnAfterDriveAxisChange()
```

#### OnAfterDriveSpeedChange()

Called after [DriveSpeed] has been changed.

##### Declaration

```
protected virtual void OnAfterDriveSpeedChange()
```

#### OnAfterGrabbedDragChange()

Called after [GrabbedDrag] has been changed.

##### Declaration

```
protected virtual void OnAfterGrabbedDragChange()
```

#### OnAfterMoveToTargetValueChange()

Called after [MoveToTargetValue] has been changed.

##### Declaration

```
protected virtual void OnAfterMoveToTargetValueChange()
```

#### OnAfterSnapToStepOnRelease()

Called after [SnapToStepOnRelease] has been changed.

##### Declaration

```
protected virtual void OnAfterSnapToStepOnRelease()
```

#### OnAfterStepIncrementChange()

Called after [StepIncrement] has been changed.

##### Declaration

```
protected virtual void OnAfterStepIncrementChange()
```

#### OnAfterStepRangeChange()

Called after [StepRange] has been changed.

##### Declaration

```
protected virtual void OnAfterStepRangeChange()
```

#### OnAfterTargetValueChange()

Called after [TargetValue] has been changed.

##### Declaration

```
protected virtual void OnAfterTargetValueChange()
```

#### OnAfterUngrabbedDragChange()

Called after [UngrabbedDrag] has been changed.

##### Declaration

```
protected virtual void OnAfterUngrabbedDragChange()
```

#### ProcessAutoDrive(Boolean)

Processes the drive's ability to automatically drive the control.

##### Declaration

```
protected virtual void ProcessAutoDrive(bool autoDrive)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Boolean | autoDrive | Whether the drive can automatically drive the control. |

#### ProcessDriveSpeed(Single, Boolean)

Processes the changes to the [DriveSpeed].

##### Declaration

```
protected virtual void ProcessDriveSpeed(float driveSpeed, bool moveToTargetValue)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | driveSpeed | The new value. |
| System.Boolean | moveToTargetValue | Whether the new value should be processed. |

#### SetDriveAxis(Int32)

Sets [DriveAxis].

##### Declaration

```
public virtual void SetDriveAxis(int axisIndex)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | axisIndex | The index of the [DriveAxis.Axis]. |

#### SetStepRangeMaximum(Single)

Sets the [StepRange] maximum value.

##### Declaration

```
public virtual void SetStepRangeMaximum(float value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | value | The new maximum value. |

#### SetStepRangeMinimum(Single)

Sets the [StepRange] minimum value.

##### Declaration

```
public virtual void SetStepRangeMinimum(float value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | value | The new minimum value. |

#### SetTargetValue(Single)

Sets the new [TargetValue].

##### Declaration

```
protected virtual void SetTargetValue(float targetValue)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | targetValue | The new value. |

#### SetTargetValueByStepValue()

Sets the [TargetValue] to the position that the current step value represents.

##### Declaration

```
public virtual void SetTargetValueByStepValue()
```

#### SetTargetValueByStepValue(Single)

Sets the [TargetValue] to the position that the given step value represents.

##### Declaration

```
public virtual void SetTargetValueByStepValue(float stepValue)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | stepValue | The step value that represents the new target value. |

[AngularDriveFacade]: ../AngularDriver/AngularDriveFacade.md
[LinearDriveFacade]: ../LinearDriver/LinearDriveFacade.md
[Tilia.Interactions.Controllables.Driver]: README.md
[Drive<TFacade, TSelf>]: Drive-2.md
[InitialTargetValue]: DriveFacade-2.md#Tilia_Interactions_Controllables_Driver_DriveFacade_2_InitialTargetValue
[TargetValue]: DriveFacade-2.md#Tilia_Interactions_Controllables_Driver_DriveFacade_2_TargetValue
[DriveUnityEvent]: DriveUnityEvent.md
[TargetValue]: DriveFacade-2.md#Tilia_Interactions_Controllables_Driver_DriveFacade_2_TargetValue
[InitialTargetValue]: DriveFacade-2.md#Tilia_Interactions_Controllables_Driver_DriveFacade_2_InitialTargetValue
[MoveToTargetValue]: DriveFacade-2.md#Tilia_Interactions_Controllables_Driver_DriveFacade_2_MoveToTargetValue
[DriveAxis]: DriveFacade-2.md#Tilia_Interactions_Controllables_Driver_DriveFacade_2_DriveAxis
[DriveSpeed]: DriveFacade-2.md#Tilia_Interactions_Controllables_Driver_DriveFacade_2_DriveSpeed
[GrabbedDrag]: DriveFacade-2.md#Tilia_Interactions_Controllables_Driver_DriveFacade_2_GrabbedDrag
[MoveToTargetValue]: DriveFacade-2.md#Tilia_Interactions_Controllables_Driver_DriveFacade_2_MoveToTargetValue
[SnapToStepOnRelease]: DriveFacade-2.md#Tilia_Interactions_Controllables_Driver_DriveFacade_2_SnapToStepOnRelease
[StepIncrement]: DriveFacade-2.md#Tilia_Interactions_Controllables_Driver_DriveFacade_2_StepIncrement
[StepRange]: DriveFacade-2.md#Tilia_Interactions_Controllables_Driver_DriveFacade_2_StepRange
[TargetValue]: DriveFacade-2.md#Tilia_Interactions_Controllables_Driver_DriveFacade_2_TargetValue
[UngrabbedDrag]: DriveFacade-2.md#Tilia_Interactions_Controllables_Driver_DriveFacade_2_UngrabbedDrag
[DriveSpeed]: DriveFacade-2.md#Tilia_Interactions_Controllables_Driver_DriveFacade_2_DriveSpeed
[DriveAxis]: DriveFacade-2.md#Tilia_Interactions_Controllables_Driver_DriveFacade_2_DriveAxis
[DriveAxis.Axis]: DriveAxis.Axis.md
[StepRange]: DriveFacade-2.md#Tilia_Interactions_Controllables_Driver_DriveFacade_2_StepRange
[StepRange]: DriveFacade-2.md#Tilia_Interactions_Controllables_Driver_DriveFacade_2_StepRange
[TargetValue]: DriveFacade-2.md#Tilia_Interactions_Controllables_Driver_DriveFacade_2_TargetValue
[TargetValue]: DriveFacade-2.md#Tilia_Interactions_Controllables_Driver_DriveFacade_2_TargetValue
[TargetValue]: DriveFacade-2.md#Tilia_Interactions_Controllables_Driver_DriveFacade_2_TargetValue
[Inheritance]: #Inheritance
[Namespace]: #Namespace
[Syntax]: #Syntax
[Fields]: #Fields
[InitialTargetValueReached]: #InitialTargetValueReached
[NormalizedValueChanged]: #NormalizedValueChanged
[StartedMoving]: #StartedMoving
[StepValueChanged]: #StepValueChanged
[StoppedMoving]: #StoppedMoving
[TargetValueReached]: #TargetValueReached
[ValueChanged]: #ValueChanged
[Properties]: #Properties
[Drive]: #Drive
[DriveAxis]: #DriveAxis
[DriveSpeed]: #DriveSpeed
[GrabbedDrag]: #GrabbedDrag
[InitialTargetValue]: #InitialTargetValue
[LinkedInteractableFacade]: #LinkedInteractableFacade
[LinkedMaxReached]: #LinkedMaxReached
[LinkedMidReached]: #LinkedMidReached
[LinkedMinReached]: #LinkedMinReached
[MoveToTargetValue]: #MoveToTargetValue
[SnapToStepOnRelease]: #SnapToStepOnRelease
[StartAtInitialTargetValue]: #StartAtInitialTargetValue
[StepIncrement]: #StepIncrement
[StepRange]: #StepRange
[TargetValue]: #TargetValue
[UngrabbedDrag]: #UngrabbedDrag
[Methods]: #Methods
[CalculateDriveAxis(DriveAxis.Axis)]: #CalculateDriveAxisDriveAxis.Axis
[ForceSnapToStepValue(Single)]: #ForceSnapToStepValueSingle
[OnAfterDriveAxisChange()]: #OnAfterDriveAxisChange
[OnAfterDriveSpeedChange()]: #OnAfterDriveSpeedChange
[OnAfterGrabbedDragChange()]: #OnAfterGrabbedDragChange
[OnAfterMoveToTargetValueChange()]: #OnAfterMoveToTargetValueChange
[OnAfterSnapToStepOnRelease()]: #OnAfterSnapToStepOnRelease
[OnAfterStepIncrementChange()]: #OnAfterStepIncrementChange
[OnAfterStepRangeChange()]: #OnAfterStepRangeChange
[OnAfterTargetValueChange()]: #OnAfterTargetValueChange
[OnAfterUngrabbedDragChange()]: #OnAfterUngrabbedDragChange
[ProcessAutoDrive(Boolean)]: #ProcessAutoDriveBoolean
[ProcessDriveSpeed(Single, Boolean)]: #ProcessDriveSpeedSingle-Boolean
[SetDriveAxis(Int32)]: #SetDriveAxisInt32
[SetStepRangeMaximum(Single)]: #SetStepRangeMaximumSingle
[SetStepRangeMinimum(Single)]: #SetStepRangeMinimumSingle
[SetTargetValue(Single)]: #SetTargetValueSingle
[SetTargetValueByStepValue()]: #SetTargetValueByStepValue
[SetTargetValueByStepValue(Single)]: #SetTargetValueByStepValueSingle
