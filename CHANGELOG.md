# Changelog

## [1.1.0](https://github.com/ExtendRealityLtd/Tilia.Interactions.Controllables.Unity/compare/v1.0.2...v1.1.0) (2020-03-15)

#### Features

* **Drive:** provide initial target value for drive to start at ([fd6ef0d](https://github.com/ExtendRealityLtd/Tilia.Interactions.Controllables.Unity/commit/fd6ef0df8b73459c7e1ef9d9708f550400554bd4))
  > The Initial Target Value allows a drive to be given an initial normalized value to drive the control to when it is first enabled without any events being triggered.
  > 
  > This is useful for starting controls at a certain point as by default they all start in their central position due to the way Unity works out drive extends for joints.

#### Miscellaneous Chores

* **deps:** bump io.extendreality.tilia.interactions.interactables.unity ([5ed470b](https://github.com/ExtendRealityLtd/Tilia.Interactions.Controllables.Unity/commit/5ed470b062c8f6e3ab5b60e6a4e6fdf2f1d5477e))
  > Bumps [io.extendreality.tilia.interactions.interactables.unity](https://github.com/ExtendRealityLtd/Tilia.Interactions.Interactables.Unity) from 1.4.4 to 1.5.0. - [Release notes](https://github.com/ExtendRealityLtd/Tilia.Interactions.Interactables.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Tilia.Interactions.Interactables.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Tilia.Interactions.Interactables.Unity/compare/v1.4.4...v1.5.0)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.0.2](https://github.com/ExtendRealityLtd/Tilia.Interactions.Controllables.Unity/compare/v1.0.1...v1.0.2) (2020-03-05)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.tilia.interactions.interactables.unity ([6b2a512](https://github.com/ExtendRealityLtd/Tilia.Interactions.Controllables.Unity/commit/6b2a5121bdcbf3e093740b391390549e15b9ee4b))
  > Bumps [io.extendreality.tilia.interactions.interactables.unity](https://github.com/ExtendRealityLtd/Tilia.Interactions.Interactables.Unity) from 1.4.3 to 1.4.4. - [Release notes](https://github.com/ExtendRealityLtd/Tilia.Interactions.Interactables.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Tilia.Interactions.Interactables.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Tilia.Interactions.Interactables.Unity/compare/v1.4.3...v1.4.4)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.0.1](https://github.com/ExtendRealityLtd/Tilia.Interactions.Controllables.Unity/compare/v1.0.0...v1.0.1) (2020-03-05)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.12.0 to 1.14.0 ([b7ca58b](https://github.com/ExtendRealityLtd/Tilia.Interactions.Controllables.Unity/commit/b7ca58bef9b010c827e65bf09224f06d9bff4674))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.12.0 to 1.14.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.12.0...v1.14.0)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

## 1.0.0 (2020-02-26)

#### Features

* **structure:** port controllable prefabs ([4ce8318](https://github.com/ExtendRealityLtd/Tilia.Interactions.Controllables.Unity/commit/4ce83187fd111b8c419b42377b702f8b565411e1))
  > The controllable prefabs from VRTK.Prefabs have been ported over to their own Tilia repo and changed slightly to make new prefabs based on the new Tilia Interactable prefab.
  > 
  > The basic installation guide has been added as well.
