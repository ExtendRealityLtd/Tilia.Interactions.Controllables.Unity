# Class Drive<TFacade, TSelf>

The basis for a mechanism to drive motion on a control.

## Contents

* [Inheritance]
* [Namespace]
* [Syntax]
* [Fields]
  * [cachedDriveSpeed]
  * [cachedEmitEvents]
  * [cachedMoveToTargetValue]
  * [cachedTargetValue]
  * [isMoving]
  * [isMovingToInitialTargetValue]
  * [previousStepValue]
  * [previousTargetValueReached]
  * [previousValue]
  * [wasDisabled]
* [Properties]
  * [AxisDirection]
  * [DriveLimits]
  * [EmitEvents]
  * [EventOutputContainer]
  * [Facade]
  * [InitialValueDriveSpeed]
  * [NormalizedStepValue]
  * [NormalizedValue]
  * [ResetDriveOnSetup]
  * [ResetDriveOnSetupFirstTimeOnly]
  * [StepValue]
  * [TargetValueReachedThreshold]
  * [Value]
* [Methods]
  * [CalculateDriveAxis(DriveAxis.Axis)]
  * [CalculateDriveLimits(TFacade)]
  * [CalculateStepValue(TFacade)]
  * [CalculateValue(DriveAxis.Axis, FloatRange)]
  * [CanMoveToTargetValue()]
  * [ConfigureAutoDrive(Boolean)]
  * [EliminateDriveVelocity()]
  * [EmitNormalizedValueChanged()]
  * [EmitStartedMoving()]
  * [EmitStepValueChanged()]
  * [EmitStoppedMoving()]
  * [EmitTargetValueReached()]
  * [EmitValueChanged()]
  * [GetDriveTransform()]
  * [GetTargetValue()]
  * [MoveToInitialTargetValue()]
  * [OnDisable()]
  * [OnEnable()]
  * [Process()]
  * [ProcessDriveSpeed(Single, Boolean)]
  * [ResetDrive()]
  * [ResetToCacheAfterReachedInitialTargetValue()]
  * [SetAxisDirection()]
  * [SetDriveLimits()]
  * [SetDriveTargetValue(Vector3)]
  * [SetTargetValue(Single)]
  * [SetUp()]
  * [SetUpInternals()]
* [Implements]

## Details

##### Inheritance

* System.Object
* Drive<TFacade, TSelf>
* [AngularDrive]
* [LinearDrive]

##### Implements

IProcessable

##### Namespace

* [Tilia.Interactions.Controllables.Driver]

##### Syntax

```
public abstract class Drive<TFacade, TSelf> : MonoBehaviour, IProcessable where TFacade : DriveFacade<TSelf, TFacade> where TSelf : Drive<TFacade, TSelf>
```

##### Type Parameters

| Name | Description |
| --- | --- |
| TFacade | The [DriveFacade<TDrive, TSelf>] to be used with the drive. |
| TSelf | The actual concrete implementation of the drive being used. |

### Fields

#### cachedDriveSpeed

The cached value for DriveSpeed.

##### Declaration

```
protected float cachedDriveSpeed
```

#### cachedEmitEvents

The cached value for [EmitEvents].

##### Declaration

```
protected bool cachedEmitEvents
```

#### cachedMoveToTargetValue

The cached value for MoveToTargetValue.

##### Declaration

```
protected bool cachedMoveToTargetValue
```

#### cachedTargetValue

The cached value for TargetValue.

##### Declaration

```
protected float cachedTargetValue
```

#### isMoving

Whether the control is moving or not.

##### Declaration

```
protected bool isMoving
```

#### isMovingToInitialTargetValue

Whether the drive is moving to the initial target value.

##### Declaration

```
protected bool isMovingToInitialTargetValue
```

#### previousStepValue

The previous state of [StepValue].

##### Declaration

```
protected float previousStepValue
```

#### previousTargetValueReached

The previous state of whether the target value has been reached.

##### Declaration

```
protected bool previousTargetValueReached
```

#### previousValue

The previous state of [Value].

##### Declaration

```
protected float previousValue
```

#### wasDisabled

Whether this component has previously been disabled before the next process.

##### Declaration

```
protected bool wasDisabled
```

### Properties

#### AxisDirection

The calculated direction for the drive axis.

##### Declaration

```
public Vector3 AxisDirection { get; protected set; }
```

#### DriveLimits

The calculated limits for the drive.

##### Declaration

```
public FloatRange DriveLimits { get; protected set; }
```

#### EmitEvents

Determines whether to emit the drive events.

##### Declaration

```
public bool EmitEvents { get; set; }
```

#### EventOutputContainer

The GameObject containing the output event actions.

##### Declaration

```
public GameObject EventOutputContainer { get; protected set; }
```

#### Facade

The public interface facade.

##### Declaration

```
public TFacade Facade { get; protected set; }
```

#### InitialValueDriveSpeed

The value to set the drive speed to when driving the control to the initial start value.

##### Declaration

```
public float InitialValueDriveSpeed { get; set; }
```

#### NormalizedStepValue

The current normalized step value for the drive control between the set step range.

##### Declaration

```
public float NormalizedStepValue { get; }
```

#### NormalizedValue

The current normalized value for the drive control between the set limits.

##### Declaration

```
public float NormalizedValue { get; }
```

#### ResetDriveOnSetup

Whether to reset the drive data when [SetUp()] is executed.

##### Declaration

```
public bool ResetDriveOnSetup { get; set; }
```

#### ResetDriveOnSetupFirstTimeOnly

Whether to set the [ResetDriveOnSetup] property back to false after [SetUp()] has executed to prevent future automatic resets until the value is manually changed again.

##### Declaration

```
public bool ResetDriveOnSetupFirstTimeOnly { get; set; }
```

#### StepValue

The current step value for the drive control.

##### Declaration

```
public float StepValue { get; }
```

#### TargetValueReachedThreshold

The threshold that the current normalized value of the control can be within to consider the target value has been reached.

##### Declaration

```
public float TargetValueReachedThreshold { get; set; }
```

#### Value

The current raw value for the drive control.

##### Declaration

```
public float Value { get; }
```

### Methods

#### CalculateDriveAxis(DriveAxis.Axis)

Calculates the axis to drive the control on.

##### Declaration

```
public virtual Vector3 CalculateDriveAxis(DriveAxis.Axis driveAxis)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [DriveAxis.Axis] | driveAxis | The desired world axis. |

##### Returns

| Type | Description |
| --- | --- |
| Vector3 | The direction of the drive axis. |

#### CalculateDriveLimits(TFacade)

Calculates the limits of the drive.

##### Declaration

```
protected abstract FloatRange CalculateDriveLimits(TFacade facade)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| TFacade | facade | The facade containing the data for the calculation. |

##### Returns

| Type | Description |
| --- | --- |
| FloatRange | The minimum and maximum local space limit the drive can reach. |

#### CalculateStepValue(TFacade)

Calculates the current step value of the control.

##### Declaration

```
protected virtual float CalculateStepValue(TFacade facade)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| TFacade | facade | The facade containing the data for the calculation. |

##### Returns

| Type | Description |
| --- | --- |
| System.Single | The calculated step value. |

#### CalculateValue(DriveAxis.Axis, FloatRange)

Calculates the current value of the control.

##### Declaration

```
protected abstract float CalculateValue(DriveAxis.Axis axis, FloatRange limits)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [DriveAxis.Axis] | axis | The axis the drive is operating on. |
| FloatRange | limits | The limits of the drive. |

##### Returns

| Type | Description |
| --- | --- |
| System.Single | The calculated value. |

#### CanMoveToTargetValue()

Determines whether the drive can move the control to the target value.

##### Declaration

```
protected virtual bool CanMoveToTargetValue()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | Whether the drive can automatically move to the target value specified in the facade. |

#### ConfigureAutoDrive(Boolean)

Configures the ability to automatically drive the control.

##### Declaration

```
public virtual void ConfigureAutoDrive(bool autoDrive)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Boolean | autoDrive | Whether the drive can automatically drive the control. |

#### EliminateDriveVelocity()

Removes any velocity being applied to the drive.

##### Declaration

```
protected virtual void EliminateDriveVelocity()
```

#### EmitNormalizedValueChanged()

Emits the NormalizedValueChanged event.

##### Declaration

```
protected virtual void EmitNormalizedValueChanged()
```

#### EmitStartedMoving()

Emits the StartedMoving event.

##### Declaration

```
protected virtual void EmitStartedMoving()
```

#### EmitStepValueChanged()

Emits the StepValueChanged event.

##### Declaration

```
protected virtual void EmitStepValueChanged()
```

#### EmitStoppedMoving()

Emits the StoppedMoving event.

##### Declaration

```
protected virtual void EmitStoppedMoving()
```

#### EmitTargetValueReached()

Emits the TargetValueReached event.

##### Declaration

```
protected virtual void EmitTargetValueReached()
```

#### EmitValueChanged()

Emits the ValueChanged event.

##### Declaration

```
protected virtual void EmitValueChanged()
```

#### GetDriveTransform()

Gets the Transform that the drive is operating on.

##### Declaration

```
protected abstract Transform GetDriveTransform()
```

##### Returns

| Type | Description |
| --- | --- |
| Transform | The drive Transform. |

#### GetTargetValue()

Gets the drive control target value.

##### Declaration

```
protected virtual float GetTargetValue()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Single | The target value specified in the facade. |

#### MoveToInitialTargetValue()

Moves the drive to the initial target value.

##### Declaration

```
protected virtual void MoveToInitialTargetValue()
```

#### OnDisable()

##### Declaration

```
protected virtual void OnDisable()
```

#### OnEnable()

##### Declaration

```
protected virtual void OnEnable()
```

#### Process()

Processes the value changes and emits the appropriate events.

##### Declaration

```
public virtual void Process()
```

#### ProcessDriveSpeed(Single, Boolean)

Processes the speed in which the drive can affect the control.

##### Declaration

```
public virtual void ProcessDriveSpeed(float driveSpeed, bool moveToTargetValue)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | driveSpeed | The speed to drive the control at. |
| System.Boolean | moveToTargetValue | Whether to allow the drive to automatically move the control to the desired target value. |

#### ResetDrive()

Resets the drive back to any default settings.

##### Declaration

```
public virtual void ResetDrive()
```

#### ResetToCacheAfterReachedInitialTargetValue()

Resets the drive parameters to the cached values after the initial target value is reached.

##### Declaration

```
protected virtual void ResetToCacheAfterReachedInitialTargetValue()
```

#### SetAxisDirection()

Sets the [AxisDirection] based on the Facade.DriveAxis value.

##### Declaration

```
public virtual void SetAxisDirection()
```

#### SetDriveLimits()

Sets the [DriveLimits] based on the [Facade] drive limit settings.

##### Declaration

```
public virtual void SetDriveLimits()
```

#### SetDriveTargetValue(Vector3)

Sets the target value of the drive.

##### Declaration

```
protected virtual void SetDriveTargetValue(Vector3 targetValue)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| Vector3 | targetValue | The value to set the drive target to. |

#### SetTargetValue(Single)

Sets the target value of the drive to the given normalized value.

##### Declaration

```
public virtual void SetTargetValue(float normalizedValue)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | normalizedValue | The normalized value to set the Target Value to. |

#### SetUp()

Sets up the drive mechanism.

##### Declaration

```
public virtual void SetUp()
```

#### SetUpInternals()

Performs any required internal setup.

##### Declaration

```
protected virtual void SetUpInternals()
```

### Implements

IProcessable

[AngularDrive]: ../AngularDriver/AngularDrive.md
[LinearDrive]: ../LinearDriver/LinearDrive.md
[Tilia.Interactions.Controllables.Driver]: README.md
[DriveFacade<TDrive, TSelf>]: DriveFacade-2.md
[EmitEvents]: Drive-2.md#Tilia_Interactions_Controllables_Driver_Drive_2_EmitEvents
[StepValue]: Drive-2.md#Tilia_Interactions_Controllables_Driver_Drive_2_StepValue
[Value]: Drive-2.md#Tilia_Interactions_Controllables_Driver_Drive_2_Value
[SetUp()]: Drive-2.md#Tilia_Interactions_Controllables_Driver_Drive_2_SetUp
[ResetDriveOnSetup]: Drive-2.md#Tilia_Interactions_Controllables_Driver_Drive_2_ResetDriveOnSetup
[SetUp()]: Drive-2.md#Tilia_Interactions_Controllables_Driver_Drive_2_SetUp
[DriveAxis.Axis]: DriveAxis.Axis.md
[AxisDirection]: Drive-2.md#Tilia_Interactions_Controllables_Driver_Drive_2_AxisDirection
[DriveLimits]: Drive-2.md#Tilia_Interactions_Controllables_Driver_Drive_2_DriveLimits
[Facade]: Drive-2.md#Tilia_Interactions_Controllables_Driver_Drive_2_Facade
[Inheritance]: #Inheritance
[Namespace]: #Namespace
[Syntax]: #Syntax
[Fields]: #Fields
[cachedDriveSpeed]: #cachedDriveSpeed
[cachedEmitEvents]: #cachedEmitEvents
[cachedMoveToTargetValue]: #cachedMoveToTargetValue
[cachedTargetValue]: #cachedTargetValue
[isMoving]: #isMoving
[isMovingToInitialTargetValue]: #isMovingToInitialTargetValue
[previousStepValue]: #previousStepValue
[previousTargetValueReached]: #previousTargetValueReached
[previousValue]: #previousValue
[wasDisabled]: #wasDisabled
[Properties]: #Properties
[AxisDirection]: #AxisDirection
[DriveLimits]: #DriveLimits
[EmitEvents]: #EmitEvents
[EventOutputContainer]: #EventOutputContainer
[Facade]: #Facade
[InitialValueDriveSpeed]: #InitialValueDriveSpeed
[NormalizedStepValue]: #NormalizedStepValue
[NormalizedValue]: #NormalizedValue
[ResetDriveOnSetup]: #ResetDriveOnSetup
[ResetDriveOnSetupFirstTimeOnly]: #ResetDriveOnSetupFirstTimeOnly
[StepValue]: #StepValue
[TargetValueReachedThreshold]: #TargetValueReachedThreshold
[Value]: #Value
[Methods]: #Methods
[CalculateDriveAxis(DriveAxis.Axis)]: #CalculateDriveAxisDriveAxis.Axis
[CalculateDriveLimits(TFacade)]: #CalculateDriveLimitsTFacade
[CalculateStepValue(TFacade)]: #CalculateStepValueTFacade
[CalculateValue(DriveAxis.Axis, FloatRange)]: #CalculateValueDriveAxis.Axis-FloatRange
[CanMoveToTargetValue()]: #CanMoveToTargetValue
[ConfigureAutoDrive(Boolean)]: #ConfigureAutoDriveBoolean
[EliminateDriveVelocity()]: #EliminateDriveVelocity
[EmitNormalizedValueChanged()]: #EmitNormalizedValueChanged
[EmitStartedMoving()]: #EmitStartedMoving
[EmitStepValueChanged()]: #EmitStepValueChanged
[EmitStoppedMoving()]: #EmitStoppedMoving
[EmitTargetValueReached()]: #EmitTargetValueReached
[EmitValueChanged()]: #EmitValueChanged
[GetDriveTransform()]: #GetDriveTransform
[GetTargetValue()]: #GetTargetValue
[MoveToInitialTargetValue()]: #MoveToInitialTargetValue
[OnDisable()]: #OnDisable
[OnEnable()]: #OnEnable
[Process()]: #Process
[ProcessDriveSpeed(Single, Boolean)]: #ProcessDriveSpeedSingle-Boolean
[ResetDrive()]: #ResetDrive
[ResetToCacheAfterReachedInitialTargetValue()]: #ResetToCacheAfterReachedInitialTargetValue
[SetAxisDirection()]: #SetAxisDirection
[SetDriveLimits()]: #SetDriveLimits
[SetDriveTargetValue(Vector3)]: #SetDriveTargetValueVector3
[SetTargetValue(Single)]: #SetTargetValueSingle
[SetUp()]: #SetUp
[SetUpInternals()]: #SetUpInternals
[Implements]: #Implements
