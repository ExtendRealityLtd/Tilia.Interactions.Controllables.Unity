# Creating A Lever

> * Level: Intermediate
>
> * Reading Time: 10 minutes
>
> * Checked with: Unity 2018.3.14f1

## Introduction

A lever control can be created by using a Angular Drive and rotating it around an offset hinge point. The lever control could be further improved to snap to specific positions or to reset itself back to the original position.

## Prerequisites

* [Add the Tilia.Interactions.Interactor.Unity] prefab to the scene Hierarchy.
* [Install the Tilia.Interactions.Controllables.Unity] package dependency in to your [Unity] project.

## Let's Start

### Step 1

Create a new `Empty` GameObject by selecting `Main Menu -> GameObject -> Create Empty` and rename it to `Lever`.

![Import Empty](assets/images/ImportEmpty.png)

### Step 2

Create a new `Sphere` 3D GameObject by selecting by selecting `Main Menu -> GameObject -> 3D Object -> Sphere` and make it a child of the `Lever` GameObject and delete the `Sphere Collider` component.

![Remove Sphere Collider](assets/images/RemoveSphereCollider.png)

Change the transform properties of the `Sphere` GameObject to:

*  Scale: ` X = 0.2, Y = 0.2, Z = 0.2`

![ChangeSphereSize](assets/images/ChangeSphereSize.png)
 
 Rename the `Sphere` GameObject to `Base`.
 
 ### Step 3
 
 Grab the `Tilia Interactions Controllables Unity -> Runtime -> Prefabs -> PhysicsJoint -> Interactions.AngularJointDrive` GameObject and put it as a child of the `Lever` GameObject.

![Import AngularJointDrive](assets/images/ImportAngularJointDrive.png)

> The Interactions.AngularJointDrive prefab uses Unity joints and therefore works within the Unity physics system, however the Interactions.AngularTransformDrive is an angular drive that does not utilize joints or physics and can easily be swapped in place at this step if required.

Change the transform properties of the `Interactions.AngularJointDrive` GameObject to:

*  Position: ` X = 0, Y = 0.2, Z = 0`

![Change AngularJointDrive Position](assets/images/ChangeAngularJointDrivePosition.png)

### Step 4

Select the `Interactions.AngularJointDrive` GameObject from the Unity Hierarchy and on the `Angular Drive Facade` component set the following properties to:

* Start At Initial Target Value: `checked`
* Initial Target Value: `1`
* Drive Limit: `-45` - `45`
* Hinge Location: ` X = 0, Y = -0.2, Z = 0`

![Configure AngularJointDrive](assets/images/ConfigureAngularJointDrive.png)

### Step 5

Select the `Lever -> Interactions.AngularJointDrive -> Internal -> JointContainer -> Joint -> Interactions.Interactable -> MeshContainer -> Cube` GameObject and change the transform properties to:

* Scale ` X = 0.05, Y = 0.4, Z = 0.05`

![Change Mesh Container](assets/images/ChangeMeshContainer.png)

### Done

Play the Unity scene you should notice the Lever go into its start position using the controller you will be able to move it between its on and off positions.

![Done](assets/images/Done.png)

[Unity]: https://unity3d.com/
[Add the Tilia.Interactions.Interactor.Unity]: https://github.com/ExtendRealityLtd/Tilia.Interactions.Interactables.Unity/tree/master/Documentation/HowToGuides/AddingAnInteractor
[Install the Tilia.Interactions.Controllables.Unity]: ../Installation/README.md
