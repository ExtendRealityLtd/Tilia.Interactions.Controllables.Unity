# Changelog

### [1.9.8](https://github.com/ExtendRealityLtd/Tilia.Interactions.Controllables.Unity/compare/v1.9.7...v1.9.8) (2020-07-30)

#### Bug Fixes

* **Drive:** expose initial drive value speed as public property ([da2c338](https://github.com/ExtendRealityLtd/Tilia.Interactions.Controllables.Unity/commit/da2c33815aecbe07bc3b4fa3396debd96776319d))
  > The IntialDriveValueSpeed is now a public changable property rather than a protected constant field so it can be adapted to suit different requirements.
  > 
  > The AngularTransformDrive did not work well at such a high speed so it has now been reduced to make it work correctly using this new ability to publicly set the initial speed of the drive.

### [1.9.7](https://github.com/ExtendRealityLtd/Tilia.Interactions.Controllables.Unity/compare/v1.9.6...v1.9.7) (2020-07-28)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.tilia.interactions.interactables.unity ([7e5d07a](https://github.com/ExtendRealityLtd/Tilia.Interactions.Controllables.Unity/commit/7e5d07a72b42c5f2b1daec158a77e2cb6c6d99b2))
  > Bumps [io.extendreality.tilia.interactions.interactables.unity](https://github.com/ExtendRealityLtd/Tilia.Interactions.Interactables.Unity) from 1.12.0 to 1.12.2. - [Release notes](https://github.com/ExtendRealityLtd/Tilia.Interactions.Interactables.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Tilia.Interactions.Interactables.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Tilia.Interactions.Interactables.Unity/compare/v1.12.0...v1.12.2)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.9.6](https://github.com/ExtendRealityLtd/Tilia.Interactions.Controllables.Unity/compare/v1.9.5...v1.9.6) (2020-07-28)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.20.0 to 1.21.0 ([0fb9dd7](https://github.com/ExtendRealityLtd/Tilia.Interactions.Controllables.Unity/commit/0fb9dd7eb91c90f7ac5d406cd1ba2c3732b1fe11))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.20.0 to 1.21.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.20.0...v1.21.0)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.9.5](https://github.com/ExtendRealityLtd/Tilia.Interactions.Controllables.Unity/compare/v1.9.4...v1.9.5) (2020-07-22)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.tilia.interactions.interactables.unity ([03aba78](https://github.com/ExtendRealityLtd/Tilia.Interactions.Controllables.Unity/commit/03aba780f839932914add7b9b8f32eeb9c85b51d))
  > Bumps [io.extendreality.tilia.interactions.interactables.unity](https://github.com/ExtendRealityLtd/Tilia.Interactions.Interactables.Unity) from 1.11.1 to 1.12.0. - [Release notes](https://github.com/ExtendRealityLtd/Tilia.Interactions.Interactables.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Tilia.Interactions.Interactables.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Tilia.Interactions.Interactables.Unity/compare/v1.11.1...v1.12.0)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.9.4](https://github.com/ExtendRealityLtd/Tilia.Interactions.Controllables.Unity/compare/v1.9.3...v1.9.4) (2020-07-11)

#### Bug Fixes

* **Facade:** use extension method to set enum value ([02ad5b9](https://github.com/ExtendRealityLtd/Tilia.Interactions.Controllables.Unity/commit/02ad5b92de2ebd4f0dcc8a91b6db0ea3da683571))
  > The SetDriveAxis method now uses the Zinnia EnumExtensions helper method to set the value of the enum by the index instead of repeating the same logic.

### [1.9.3](https://github.com/ExtendRealityLtd/Tilia.Interactions.Controllables.Unity/compare/v1.9.2...v1.9.3) (2020-07-11)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.tilia.interactions.interactables.unity ([5955915](https://github.com/ExtendRealityLtd/Tilia.Interactions.Controllables.Unity/commit/5955915e418bd639e8ff7696cfeec1d0498bee94))
  > Bumps [io.extendreality.tilia.interactions.interactables.unity](https://github.com/ExtendRealityLtd/Tilia.Interactions.Interactables.Unity) from 1.11.0 to 1.11.1. - [Release notes](https://github.com/ExtendRealityLtd/Tilia.Interactions.Interactables.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Tilia.Interactions.Interactables.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Tilia.Interactions.Interactables.Unity/compare/v1.11.0...v1.11.1)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.9.2](https://github.com/ExtendRealityLtd/Tilia.Interactions.Controllables.Unity/compare/v1.9.1...v1.9.2) (2020-07-11)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.19.0 to 1.20.0 ([83ca6c4](https://github.com/ExtendRealityLtd/Tilia.Interactions.Controllables.Unity/commit/83ca6c42f4f46a574d5e5884f1d3406db52ce387))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.19.0 to 1.20.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.19.0...v1.20.0)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.9.1](https://github.com/ExtendRealityLtd/Tilia.Interactions.Controllables.Unity/compare/v1.9.0...v1.9.1) (2020-07-08)

#### Bug Fixes

* **Drive:** rework the drive reset functionality ([e6a7aa8](https://github.com/ExtendRealityLtd/Tilia.Interactions.Controllables.Unity/commit/e6a7aa87ddd5855abf779f58f2b6958df8cd3338))
  > The AngularDrive ResetRotations was causing the MoveToTargetValue functionality to break because it was always resetting the drive everytime the target value changed. This has been fixed by reworking the Reset concept into the core Drive class and having the ability of only calling ResetDrive the first time SetUp is called and then it won't call Reset again until a manual intervention occurs.

## [1.9.0](https://github.com/ExtendRealityLtd/Tilia.Interactions.Controllables.Unity/compare/v1.8.2...v1.9.0) (2020-07-07)

#### Features

* **Driver:** add methods for properties in UnityEvents ([7a93c4e](https://github.com/ExtendRealityLtd/Tilia.Interactions.Controllables.Unity/commit/7a93c4e37c450418f7955d79dcbbd1dd55277388))
  > A number of properties cannot be changed via UnityEvents because they are non-standard data types, so methods have been added that allow for these data types to be changed.
  > 
  > A small fix for the DriveLimits not being updated has been added and the Setup code has been refactored so the individual setup elements can now be run individually if need be.
  > 
  > Also, now when the DriveAxis is changed, it will reset the rotation on the axis as otherwise the rotations cause adverse effects. It needs looking into further in the future to see if the rotational data can be kept when switching axes as this would be a nice feature.

#### Bug Fixes

* **dependabot:** remove bddckr from default reviewer ([7c7a812](https://github.com/ExtendRealityLtd/Tilia.Interactions.Controllables.Unity/commit/7c7a8124c00d41006943a2e08b51284dcc34ad95))
  > Only need one reviewer in the dependabot config.

### [1.8.2](https://github.com/ExtendRealityLtd/Tilia.Interactions.Controllables.Unity/compare/v1.8.1...v1.8.2) (2020-07-07)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.tilia.interactions.interactables.unity ([f558bbd](https://github.com/ExtendRealityLtd/Tilia.Interactions.Controllables.Unity/commit/f558bbd6c85cf1f16afdf73ff7ab4761bd86526b))
  > Bumps [io.extendreality.tilia.interactions.interactables.unity](https://github.com/ExtendRealityLtd/Tilia.Interactions.Interactables.Unity) from 1.10.1 to 1.11.0. - [Release notes](https://github.com/ExtendRealityLtd/Tilia.Interactions.Interactables.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Tilia.Interactions.Interactables.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Tilia.Interactions.Interactables.Unity/compare/v1.10.1...v1.11.0)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.8.1](https://github.com/ExtendRealityLtd/Tilia.Interactions.Controllables.Unity/compare/v1.8.0...v1.8.1) (2020-07-05)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.tilia.interactions.interactables.unity ([d2c34a6](https://github.com/ExtendRealityLtd/Tilia.Interactions.Controllables.Unity/commit/d2c34a6bd5a113cb9606b024565e3f814c86043d))
  > Bumps [io.extendreality.tilia.interactions.interactables.unity](https://github.com/ExtendRealityLtd/Tilia.Interactions.Interactables.Unity) from 1.10.0 to 1.10.1. - [Release notes](https://github.com/ExtendRealityLtd/Tilia.Interactions.Interactables.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Tilia.Interactions.Interactables.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Tilia.Interactions.Interactables.Unity/compare/v1.10.0...v1.10.1)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

## [1.8.0](https://github.com/ExtendRealityLtd/Tilia.Interactions.Controllables.Unity/compare/v1.7.14...v1.8.0) (2020-07-03)

#### Features

* **API:** add auto-generated API documentation ([40e4e9a](https://github.com/ExtendRealityLtd/Tilia.Interactions.Controllables.Unity/commit/40e4e9aab0726f74f254f231cd43614ba3f2567b))
  > The API documentation is auto generated with docfx and converted to markdown via turndown in a custom nodejs script.

#### Bug Fixes

* **package.json:** add docfx.json file ([6ebcd16](https://github.com/ExtendRealityLtd/Tilia.Interactions.Controllables.Unity/commit/6ebcd1685f03dd72c59e891eaaf0adc99ec793c2))
  > The docfx.json file was missing from the package.json causing the build process to fail. It has now been added.

#### Miscellaneous Chores

* **deps:** bump io.extendreality.tilia.interactions.interactables.unity ([71fa274](https://github.com/ExtendRealityLtd/Tilia.Interactions.Controllables.Unity/commit/71fa274b6d8491deab6f5c3f75a2e2366437ee50))
  > Bumps [io.extendreality.tilia.interactions.interactables.unity](https://github.com/ExtendRealityLtd/Tilia.Interactions.Interactables.Unity) from 1.9.0 to 1.10.0. - [Release notes](https://github.com/ExtendRealityLtd/Tilia.Interactions.Interactables.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Tilia.Interactions.Interactables.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Tilia.Interactions.Interactables.Unity/compare/v1.9.0...v1.10.0)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.7.14](https://github.com/ExtendRealityLtd/Tilia.Interactions.Controllables.Unity/compare/v1.7.13...v1.7.14) (2020-06-27)

#### Bug Fixes

* **Interactables:** update Interactables namespace to latest ([4eb88fa](https://github.com/ExtendRealityLtd/Tilia.Interactions.Controllables.Unity/commit/4eb88fa6e31e634da3e4aaba51e65da365545ac3))
  > The Interactables namespace changed in version 1.9.0 of the Interactables package, so it has been updated accordingly.

### [1.7.13](https://github.com/ExtendRealityLtd/Tilia.Interactions.Controllables.Unity/compare/v1.7.12...v1.7.13) (2020-06-08)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.tilia.interactions.interactables.unity ([df53832](https://github.com/ExtendRealityLtd/Tilia.Interactions.Controllables.Unity/commit/df53832d30fe756b3a9951f5a82b8dff1aa895a4))
  > Bumps [io.extendreality.tilia.interactions.interactables.unity](https://github.com/ExtendRealityLtd/Tilia.Interactions.Interactables.Unity) from 1.8.0 to 1.8.1. - [Release notes](https://github.com/ExtendRealityLtd/Tilia.Interactions.Interactables.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Tilia.Interactions.Interactables.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Tilia.Interactions.Interactables.Unity/compare/v1.8.0...v1.8.1)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.7.12](https://github.com/ExtendRealityLtd/Tilia.Interactions.Controllables.Unity/compare/v1.7.11...v1.7.12) (2020-06-08)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.18.0 to 1.19.0 ([0e527f2](https://github.com/ExtendRealityLtd/Tilia.Interactions.Controllables.Unity/commit/0e527f2d4dcf70666b2f34e002fed8baa9dca1af))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.18.0 to 1.19.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.18.0...v1.19.0)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.7.11](https://github.com/ExtendRealityLtd/Tilia.Interactions.Controllables.Unity/compare/v1.7.10...v1.7.11) (2020-05-31)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.tilia.interactions.interactables.unity ([6c7bf73](https://github.com/ExtendRealityLtd/Tilia.Interactions.Controllables.Unity/commit/6c7bf73005ecad5cc66d5f0a80d0fc52071263df))
  > Bumps [io.extendreality.tilia.interactions.interactables.unity](https://github.com/ExtendRealityLtd/Tilia.Interactions.Interactables.Unity) from 1.7.4 to 1.8.0. - [Release notes](https://github.com/ExtendRealityLtd/Tilia.Interactions.Interactables.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Tilia.Interactions.Interactables.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Tilia.Interactions.Interactables.Unity/compare/v1.7.4...v1.8.0)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.7.10](https://github.com/ExtendRealityLtd/Tilia.Interactions.Controllables.Unity/compare/v1.7.9...v1.7.10) (2020-05-31)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.tilia.interactions.interactables.unity ([2d1c1c6](https://github.com/ExtendRealityLtd/Tilia.Interactions.Controllables.Unity/commit/2d1c1c636a020d60011721a0c2b6d282b7e78608))
  > Bumps [io.extendreality.tilia.interactions.interactables.unity](https://github.com/ExtendRealityLtd/Tilia.Interactions.Interactables.Unity) from 1.7.3 to 1.7.4. - [Release notes](https://github.com/ExtendRealityLtd/Tilia.Interactions.Interactables.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Tilia.Interactions.Interactables.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Tilia.Interactions.Interactables.Unity/compare/v1.7.3...v1.7.4)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.7.9](https://github.com/ExtendRealityLtd/Tilia.Interactions.Controllables.Unity/compare/v1.7.8...v1.7.9) (2020-05-31)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.17.1 to 1.18.0 ([580263d](https://github.com/ExtendRealityLtd/Tilia.Interactions.Controllables.Unity/commit/580263d9011ac19feb152c5c7ae41931176f14dc))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.17.1 to 1.18.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.17.1...v1.18.0)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.7.8](https://github.com/ExtendRealityLtd/Tilia.Interactions.Controllables.Unity/compare/v1.7.7...v1.7.8) (2020-05-22)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.tilia.interactions.interactables.unity ([6e93b64](https://github.com/ExtendRealityLtd/Tilia.Interactions.Controllables.Unity/commit/6e93b6490e6d960632d8ca6283e4af34f228673b))
  > Bumps [io.extendreality.tilia.interactions.interactables.unity](https://github.com/ExtendRealityLtd/Tilia.Interactions.Interactables.Unity) from 1.7.2 to 1.7.3. - [Release notes](https://github.com/ExtendRealityLtd/Tilia.Interactions.Interactables.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Tilia.Interactions.Interactables.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Tilia.Interactions.Interactables.Unity/compare/v1.7.2...v1.7.3)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.7.7](https://github.com/ExtendRealityLtd/Tilia.Interactions.Controllables.Unity/compare/v1.7.6...v1.7.7) (2020-05-22)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.17.0 to 1.17.1 ([b007fa7](https://github.com/ExtendRealityLtd/Tilia.Interactions.Controllables.Unity/commit/b007fa7a8e48985a88e3cdb11234aaa49da48db3))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.17.0 to 1.17.1. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.17.0...v1.17.1)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.7.6](https://github.com/ExtendRealityLtd/Tilia.Interactions.Controllables.Unity/compare/v1.7.5...v1.7.6) (2020-05-22)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.tilia.interactions.interactables.unity ([7cf41be](https://github.com/ExtendRealityLtd/Tilia.Interactions.Controllables.Unity/commit/7cf41bec0ba89812778c6cc8709e47d2905269e2))
  > Bumps [io.extendreality.tilia.interactions.interactables.unity](https://github.com/ExtendRealityLtd/Tilia.Interactions.Interactables.Unity) from 1.7.1 to 1.7.2. - [Release notes](https://github.com/ExtendRealityLtd/Tilia.Interactions.Interactables.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Tilia.Interactions.Interactables.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Tilia.Interactions.Interactables.Unity/compare/v1.7.1...v1.7.2)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.7.5](https://github.com/ExtendRealityLtd/Tilia.Interactions.Controllables.Unity/compare/v1.7.4...v1.7.5) (2020-05-22)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.16.0 to 1.17.0 ([811d56f](https://github.com/ExtendRealityLtd/Tilia.Interactions.Controllables.Unity/commit/811d56f2e3c40abab8e11d830cb07adfdb954a8e))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.16.0 to 1.17.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.16.0...v1.17.0)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.7.4](https://github.com/ExtendRealityLtd/Tilia.Interactions.Controllables.Unity/compare/v1.7.3...v1.7.4) (2020-04-21)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.tilia.interactions.interactables.unity ([ee281b1](https://github.com/ExtendRealityLtd/Tilia.Interactions.Controllables.Unity/commit/ee281b1fb9da79eb01fc67a9e0fc5bd43dee42c4))
  > Bumps [io.extendreality.tilia.interactions.interactables.unity](https://github.com/ExtendRealityLtd/Tilia.Interactions.Interactables.Unity) from 1.7.0 to 1.7.1. - [Release notes](https://github.com/ExtendRealityLtd/Tilia.Interactions.Interactables.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Tilia.Interactions.Interactables.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Tilia.Interactions.Interactables.Unity/compare/v1.7.0...v1.7.1)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.7.3](https://github.com/ExtendRealityLtd/Tilia.Interactions.Controllables.Unity/compare/v1.7.2...v1.7.3) (2020-04-21)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.15.0 to 1.16.0 ([0c283e0](https://github.com/ExtendRealityLtd/Tilia.Interactions.Controllables.Unity/commit/0c283e02c51cfc84fdd69bd973c391bb50824fa1))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.15.0 to 1.16.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.15.0...v1.16.0)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.7.2](https://github.com/ExtendRealityLtd/Tilia.Interactions.Controllables.Unity/compare/v1.7.1...v1.7.2) (2020-04-14)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.tilia.interactions.interactables.unity ([675adc1](https://github.com/ExtendRealityLtd/Tilia.Interactions.Controllables.Unity/commit/675adc19d4d26ee98b2d3d7755fc5289a9f1c703))
  > Bumps [io.extendreality.tilia.interactions.interactables.unity](https://github.com/ExtendRealityLtd/Tilia.Interactions.Interactables.Unity) from 1.6.1 to 1.7.0. - [Release notes](https://github.com/ExtendRealityLtd/Tilia.Interactions.Interactables.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Tilia.Interactions.Interactables.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Tilia.Interactions.Interactables.Unity/compare/v1.6.1...v1.7.0)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.7.1](https://github.com/ExtendRealityLtd/Tilia.Interactions.Controllables.Unity/compare/v1.7.0...v1.7.1) (2020-04-14)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.14.1 to 1.15.0 ([cca5c94](https://github.com/ExtendRealityLtd/Tilia.Interactions.Controllables.Unity/commit/cca5c949a95b4923a11072243a1efd99409fb744))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.14.1 to 1.15.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.14.1...v1.15.0)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

## [1.7.0](https://github.com/ExtendRealityLtd/Tilia.Interactions.Controllables.Unity/compare/v1.6.0...v1.7.0) (2020-04-09)

#### Features

* **HowToGuides:** add guide showing how to create a wheel ([61e9d1e](https://github.com/ExtendRealityLtd/Tilia.Interactions.Controllables.Unity/commit/61e9d1efb590f9d683fbb4a7e50d56e9c56c1d47))
  > Added a guide demonstrating how to create a wheel.

## [1.6.0](https://github.com/ExtendRealityLtd/Tilia.Interactions.Controllables.Unity/compare/v1.5.3...v1.6.0) (2020-04-09)

#### Features

* **HowToGuides:** add guide showing how to create a lever ([f48649c](https://github.com/ExtendRealityLtd/Tilia.Interactions.Controllables.Unity/commit/f48649c7fba6e5ea227a8a8de5a78c5fb8c8d8e6))
  > Added guide showing how to create a lever.

### [1.5.3](https://github.com/ExtendRealityLtd/Tilia.Interactions.Controllables.Unity/compare/v1.5.2...v1.5.3) (2020-04-08)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.tilia.interactions.interactables.unity ([5124148](https://github.com/ExtendRealityLtd/Tilia.Interactions.Controllables.Unity/commit/5124148e08eeaa462a7719eb381ec888b7b0b1c3))
  > Bumps [io.extendreality.tilia.interactions.interactables.unity](https://github.com/ExtendRealityLtd/Tilia.Interactions.Interactables.Unity) from 1.6.0 to 1.6.1. - [Release notes](https://github.com/ExtendRealityLtd/Tilia.Interactions.Interactables.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Tilia.Interactions.Interactables.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Tilia.Interactions.Interactables.Unity/compare/v1.6.0...v1.6.1)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.5.2](https://github.com/ExtendRealityLtd/Tilia.Interactions.Controllables.Unity/compare/v1.5.1...v1.5.2) (2020-04-07)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.tilia.interactions.interactables.unity ([8fbded2](https://github.com/ExtendRealityLtd/Tilia.Interactions.Controllables.Unity/commit/8fbded279e95cc7bf45e8133eb778327a7c37e28))
  > Bumps [io.extendreality.tilia.interactions.interactables.unity](https://github.com/ExtendRealityLtd/Tilia.Interactions.Interactables.Unity) from 1.5.1 to 1.6.0. - [Release notes](https://github.com/ExtendRealityLtd/Tilia.Interactions.Interactables.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Tilia.Interactions.Interactables.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Tilia.Interactions.Interactables.Unity/compare/v1.5.1...v1.6.0)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.5.1](https://github.com/ExtendRealityLtd/Tilia.Interactions.Controllables.Unity/compare/v1.5.0...v1.5.1) (2020-04-06)

#### Bug Fixes

* **HowToGuides:** move page links to bottom of page ([7eecd84](https://github.com/ExtendRealityLtd/Tilia.Interactions.Controllables.Unity/commit/7eecd84cdd9915e9ecacc98ece1f8a99b811100d))
  > The page links on the Creating A Slider guide were in the wrong place and have now been moved to the bottom.
* **HowToGuides:** remove erroneous image ([64e8602](https://github.com/ExtendRealityLtd/Tilia.Interactions.Controllables.Unity/commit/64e86022d34cd196b2bb9a88784282003e1c52b8))
  > There was an image for the Creating A Physics Button guide that was not being used. It has now been deleted.

## [1.5.0](https://github.com/ExtendRealityLtd/Tilia.Interactions.Controllables.Unity/compare/v1.4.1...v1.5.0) (2020-04-06)

#### Features

* **HowToGuides:** add guide to show how to create a physics button ([1c75c02](https://github.com/ExtendRealityLtd/Tilia.Interactions.Controllables.Unity/commit/1c75c026004a97eb722cae939078bf72b0751d7f))
  > Added a guide demonstrating how to make a physics button.

### [1.4.1](https://github.com/ExtendRealityLtd/Tilia.Interactions.Controllables.Unity/compare/v1.4.0...v1.4.1) (2020-04-05)

#### Bug Fixes

* **Drive:** use actual value for initial start drive speed ([f317c95](https://github.com/ExtendRealityLtd/Tilia.Interactions.Controllables.Unity/commit/f317c9560cb7f980f3e3c5f7a988fdc338ca24d1))
  > Using a drive speed that is too high causes problems with Unity joints and can cause them to break their restrictions.
  > 
  > Instead of using a float max value, it now uses just a high value that is fast enough to not notice but not fast enough to break the Unity joints system.
  > 
  > Whilst 5000f seems like a magic number, it's just a number that was decided that fell into the category of not breaking things but being fast enough to not notice.

## [1.4.0](https://github.com/ExtendRealityLtd/Tilia.Interactions.Controllables.Unity/compare/v1.3.1...v1.4.0) (2020-04-03)

#### Features

* **HowToGuides:** add guide on how to create a door ([9e450ef](https://github.com/ExtendRealityLtd/Tilia.Interactions.Controllables.Unity/commit/9e450ef02625ee1746a194232b27f3591ca8002d))
  > The Angular Drive has been used to create an interactable door.

#### Miscellaneous Chores

* **deps:** bump io.extendreality.tilia.interactions.interactables.unity ([f520070](https://github.com/ExtendRealityLtd/Tilia.Interactions.Controllables.Unity/commit/f52007085d8d43603d42f39bbef69bf286717ba7))
  > Bumps [io.extendreality.tilia.interactions.interactables.unity](https://github.com/ExtendRealityLtd/Tilia.Interactions.Interactables.Unity) from 1.5.0 to 1.5.1. - [Release notes](https://github.com/ExtendRealityLtd/Tilia.Interactions.Interactables.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Tilia.Interactions.Interactables.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Tilia.Interactions.Interactables.Unity/compare/v1.5.0...v1.5.1)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.3.1](https://github.com/ExtendRealityLtd/Tilia.Interactions.Controllables.Unity/compare/v1.3.0...v1.3.1) (2020-04-03)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.14.0 to 1.14.1 ([905e057](https://github.com/ExtendRealityLtd/Tilia.Interactions.Controllables.Unity/commit/905e0579f32fb0a9fa5510f60bcdd263d92156cc))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.14.0 to 1.14.1. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.14.0...v1.14.1)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

## [1.3.0](https://github.com/ExtendRealityLtd/Tilia.Interactions.Controllables.Unity/compare/v1.2.0...v1.3.0) (2020-03-19)

#### Features

* **HowToGuides:** add documentation for creating a slider ([bbd9e21](https://github.com/ExtendRealityLtd/Tilia.Interactions.Controllables.Unity/commit/bbd9e21fe1bf7b30881fa8887a0084ebb0108927))
  > A guide that shows how to create a slider utilizing the linear drive from the controllables.
* **HowToGuides:** add guide for creating interactable drawer ([4c813e3](https://github.com/ExtendRealityLtd/Tilia.Interactions.Controllables.Unity/commit/4c813e3e6dd2c18b73e60209b9c0f23e1a727845))
  > Added a guide to show how to make an interactable drawer.

## [1.2.0](https://github.com/ExtendRealityLtd/Tilia.Interactions.Controllables.Unity/compare/v1.1.0...v1.2.0) (2020-03-16)

#### Features

* **Drive:** emit event when the initial target value is reached ([3975153](https://github.com/ExtendRealityLtd/Tilia.Interactions.Controllables.Unity/commit/3975153244b2ff7f363b727f892096422e80273c))
  > The new InitialTargetValueReached event is emitted when the initial target value is reached and is useful for setting up initial configuration as by default the initial target value process will not emit any events even when the target value is reached so this new InitialTargetValueReached event can be used to set up any initial state required by the control.

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
