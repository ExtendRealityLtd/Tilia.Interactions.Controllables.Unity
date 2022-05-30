# Class DriveAxis

Denotes a world axis for the drive to operate on.

## Contents

* [Inheritance]
* [Namespace]
* [Syntax]
* [Methods]
  * [GetAxisDirection(DriveAxis.Axis, Boolean)]
  * [GetAxisScale(DriveAxis.Axis, Transform, Boolean)]
  * [Overwrite(DriveAxis.Axis, Vector3, Vector3)]

## Details

##### Inheritance

* System.Object
* DriveAxis

##### Inherited Members

System.Object.ToString()

System.Object.Equals(System.Object)

System.Object.Equals(System.Object, System.Object)

System.Object.ReferenceEquals(System.Object, System.Object)

System.Object.GetHashCode()

System.Object.GetType()

System.Object.MemberwiseClone()

##### Namespace

* [Tilia.Interactions.Controllables.Driver]

##### Syntax

```
public static class DriveAxis
```

### Methods

#### GetAxisDirection(DriveAxis.Axis, Boolean)

Gets the axis direction for the given [DriveAxis].

##### Declaration

```
public static Vector3 GetAxisDirection(this DriveAxis.Axis axis, bool negativeDirection = false)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [DriveAxis.Axis] | axis | The desired world axis. |
| System.Boolean | negativeDirection | Whether to get the negative axis direction. |

##### Returns

| Type | Description |
| --- | --- |
| Vector3 | The direction of the drive axis. |

#### GetAxisScale(DriveAxis.Axis, Transform, Boolean)

Gets the scale on the given Transform for the specified [DriveAxis].

##### Declaration

```
public static float GetAxisScale(this DriveAxis.Axis axis, Transform source, bool useLocalScale = true)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [DriveAxis.Axis] | axis | The desired axis. |
| Transform | source | The source of the scale. |
| System.Boolean | useLocalScale | Whether to use the local scale of the Transform or the world scale. |

##### Returns

| Type | Description |
| --- | --- |
| System.Single | The scale of the source for a given axis. |

#### Overwrite(DriveAxis.Axis, Vector3, Vector3)

Overwrites the given source Vector3 over the given target Vector3.

##### Declaration

```
public static Vector3 Overwrite(this DriveAxis.Axis axis, Vector3 source, Vector3 target)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [DriveAxis.Axis] | axis | The axis to overwrite on. |
| Vector3 | source | The source data to overwrite from. |
| Vector3 | target | The target data to overwrite the source data to. |

##### Returns

| Type | Description |
| --- | --- |
| Vector3 | The overwritten result. |

[Tilia.Interactions.Controllables.Driver]: README.md
[DriveAxis]: DriveAxis.md
[DriveAxis.Axis]: DriveAxis.Axis.md
[Inheritance]: #Inheritance
[Namespace]: #Namespace
[Syntax]: #Syntax
[Methods]: #Methods
[GetAxisDirection(DriveAxis.Axis, Boolean)]: #GetAxisDirectionDriveAxis.Axis-Boolean
[GetAxisScale(DriveAxis.Axis, Transform, Boolean)]: #GetAxisScaleDriveAxis.Axis-Transform-Boolean
[Overwrite(DriveAxis.Axis, Vector3, Vector3)]: #OverwriteDriveAxis.Axis-Vector3-Vector3
