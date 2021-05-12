[![Tilia logo][Tilia-Image]](#)

> ### Interactions -> Controllables for the Unity Software
> Mechanisms that provide physics based and non-physics based linear and angular interactable controls for the Unity software.

[![Release][Version-Release]][Releases]
[![License][License-Badge]][License]
[![Backlog][Backlog-Badge]][Backlog]

## Introduction

The controllable prefabs provide a way of creating an Interactable that is restricted to either a linear or angular motion and can either use [Unity] joints to work within the physics system or by simply updating the Interactable transform properties to not use any Unity physics at all. The four prefabs that are provided are:

* `Physics Joint` - Uses Unity joints for physics based interactions
  * `Linear Joint Drive` - Moves in a single axis direction along a configured Unity joint for a limited distance.
  * `Angular Joint Drive` - Rotates around a single axis around a Unity hinge joint for a limited angular distance.
* `Transform` - Directly manipulates the Transform position of the drive to move or rotate without being part of the Unity physics system.
  * `Linear Transform Drive` - Moves in a single axis direction for a limited distance.
  * `Angular Transform Drive` - Rotates around a single axis for a limited angular distance.

> **Requires** the Unity software version `2018.3.10f1` (or above).

## Getting Started

Please refer to the [installation] guide to install this package.

## Documentation

Please refer to the [How To Guides] for usage of this package.

Further documentation can be found within the [Documentation] directory and at https://academy.vrtk.io

## Contributing

Please refer to the Extend Reality [Contributing guidelines] and the [project coding conventions].

## Code of Conduct

Please refer to the Extend Reality [Code of Conduct].

## License

Code released under the [MIT License][License].

[License-Badge]: https://img.shields.io/github/license/ExtendRealityLtd/Tilia.Interactions.Controllables.Unity.svg
[Version-Release]: https://img.shields.io/github/release/ExtendRealityLtd/Tilia.Interactions.Controllables.Unity.svg
[project coding conventions]: https://github.com/ExtendRealityLtd/.github/blob/master/CONVENTIONS/UNITY3D.md

[Tilia-Image]: https://raw.githubusercontent.com/ExtendRealityLtd/related-media/main/github/readme/tilia.png
[License]: LICENSE.md
[Documentation]: Documentation/
[How To Guides]: Documentation/HowToGuides/
[Installation]: Documentation/HowToGuides/Installation/README.md
[Backlog]: http://tracker.vrtk.io
[Backlog-Badge]: https://img.shields.io/badge/project-backlog-78bdf2.svg
[Releases]: ../../releases
[Contributing guidelines]: https://github.com/ExtendRealityLtd/.github/blob/master/CONTRIBUTING.md
[Code of Conduct]: https://github.com/ExtendRealityLtd/.github/blob/master/CODE_OF_CONDUCT.md

[Unity]: https://unity3d.com/