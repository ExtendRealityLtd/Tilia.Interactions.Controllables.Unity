# Class DriveAxis

Denotes a world axis for the drive to operate on.

## Contents

* [Inheritance]
* [Namespace]
* [Syntax]
* [Methods]
  * [GetAxisDirection(DriveAxis.Axis, Boolean)]

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

[Tilia.Interactions.Controllables.Driver]: README.md
[DriveAxis]: DriveAxis.md
[DriveAxis.Axis]: DriveAxis.Axis.md
[Inheritance]: #Inheritance
[Namespace]: #Namespace
[Syntax]: #Syntax
[Methods]: #Methods
[GetAxisDirection(DriveAxis.Axis, Boolean)]: #GetAxisDirectionDriveAxis.Axis-Boolean
