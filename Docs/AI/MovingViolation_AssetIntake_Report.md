# Moving Violation S/A asset intake

Intake status on 2026-11-19. The manifest has the requested 11 S and 60 A rows in priority order. This report records the last verified state of each package.

- Archive evidence for 70 of 71 packages, with 69,062,721,720 bytes in inventoried payloads before Unity sidecars.
- 56 packages recorded as active in the Pile, totaling 43,233,298,600 payload bytes.
- 71 confirmed asset metadata checkpoints. Tracked vendor payload totals 64,532,053 bytes of separately licensed source and media.
- 82 inventoried files at or above 50 MiB. See [Local-only size exclusions](MovingViolation/LocalOnlyRestore.csv) for all local-only source paths and sidecars.
- Isolated Unity 6000.3.6f1 URP baseline: exit code 0, refresh completed True, compiler errors 0. The live Pile had an existing Infinity PBR demo prefab error before this intake.

| Disposition | Packages |
| --- | ---: |
| `ALREADY_PRESENT_VALIDATED` | 1 |
| `FAILED_RETRY_NEEDED` | 3 |
| `INCOMPATIBLE_ISOLATED` | 12 |
| `LOCAL_ONLY_LICENSE` | 55 |

## Evidence and rehydration

- [71-package manifest](MovingViolation_AssetIntake_Manifest.csv) tracks exact identity, activity, local source state, compatibility evidence, dependencies and verified checkpoint SHAs.
- [Local-only restore catalogue](MovingViolation/LocalOnlyRestore.csv) lists 45,442 source paths with exact package identity, restore location, local-only reason and dependency notes.
- [Tested pipeline and package variants](MovingViolation/PipelineVariants.csv) records 9,259 source paths from the tested scoped editions.
- [Local asset file index](MovingViolation/LocalAssetPaths.csv) lists verified file paths and their source package versions.
- [Bundle constituent catalogue](MovingViolation/BundleComponents.csv) records each separately distributed city, character and industrial product.
- [Bundle local-only restore catalogue](MovingViolation/BundleLocalOnlyRestore.csv) lists original file paths, source versions and sidecars for the independently archived constituents.
- [Audio asset catalogue](MovingViolation/AudioAssets.csv) identifies 10,106 source clips by exact filename and path. Audition clips and confirm destination-project usage rights before copying.
- [Weather foundation and open checks](MovingViolation/WeatherFoundation.md) maps the Interstate Hauler coordinator, Weather Maker and Weatherade.
- The live Unity project has local registry entries for `com.unity.editorcoroutines 1.1.0`, `com.unity.shadergraph 17.3.0`. The prior package versions were preserved.
- Local Standalone scripting defines added during import include `EASYROADS3D_PRO`, `NWH_NVP2`, `NWH_WC3D`, `WEATHER_MAKER_PRESENT`.
- Restore in Unity 6000.3.6f1 with URP 17.3.0. Match the package title, publisher, ID and source version in the manifest. Use the selected URP edition where the package evidence names a nested vendor archive.
- A licensed developer can retrieve packages through Unity Package Manager → My Assets using each row’s title, publisher and ID. Match the recorded archive version. Store archives outside Git and import validated assets with original vendor paths and .meta GUIDs. Review isolated candidates in a test copy.
- A missing archive in the manifest represents a retrieval or verification gap. A positive purchase record by itself supplies no local package bytes.
- The public repository may carry licence-compatible metadata and original integration work. Unity’s standard Asset Store EULA permits distribution of licensed assets as embedded in a licensed product under its terms. [Unity Asset Store EULA](https://unity.com/legal/as-terms)

## Verified pushes

| Priority | Package | GitHub commit | Outbound pack |
| --- | --- | --- | ---: |
| 01 | NWH Vehicle Physics 2 | [b8cea65](https://github.com/Bregermann/Asset-Consideration-Pile/commit/b8cea65bea2fa5ff49ed6e6f5b59f9d3d6be5fb7) | 1,737 B |
| 02 | EasyRoads3D Pro v3 | [597aa23](https://github.com/Bregermann/Asset-Consideration-Pile/commit/597aa232cbc9928048db92d787f53dbcba1f502c) | 2,011 B |
| 03 | JU TPS 3 - Third Person Shooter GameKit + Vehicle Physics | [7df2243](https://github.com/Bregermann/Asset-Consideration-Pile/commit/7df2243e9eeed36d9e66b9b779e8e6ce26ea56aa) | 2,306 B |
| 04 | Urban Traffic System Full Pack | [4e1bb2d](https://github.com/Bregermann/Asset-Consideration-Pile/commit/4e1bb2d1ab1db535d2218d091015c570f16d880c) | 2,338 B |
| 05 | Dialogue System for Unity | [b99f84c](https://github.com/Bregermann/Asset-Consideration-Pile/commit/b99f84c41c1f744a8da22d500598e6c97b088e7c) | 772 B |
| 06 | Mobile Pedestrian System | [fe1b7c3](https://github.com/Bregermann/Asset-Consideration-Pile/commit/fe1b7c3c8f64c4f3d13946d734966bc489b09fcf) | 1,869 B |
| 07 | Miami Vice City | [5f834f7](https://github.com/Bregermann/Asset-Consideration-Pile/commit/5f834f7ed11a76dd7034fe61cafbe95a924baa7b) | 751 B |
| 08 | Sundown:Shop/Store (Modular Shop, Supermarket, Convenience Store) | [9ba0e52](https://github.com/Bregermann/Asset-Consideration-Pile/commit/9ba0e52bb70c48e743bf37a053f585fe6a949f0f) | 805 B |
| 09 | Love/Hate | [7a40b24](https://github.com/Bregermann/Asset-Consideration-Pile/commit/7a40b24ed575354b893895685a820d3783fc6f94) | 1,889 B |
| 10 | Human Basic Motions | [c91e8ab](https://github.com/Bregermann/Asset-Consideration-Pile/commit/c91e8ab41fd85d195a9b2df1ec8af9c3e57cc1c8) | 1,857 B |
| 11 | Scene Streamer | [e175898](https://github.com/Bregermann/Asset-Consideration-Pile/commit/e1758980fd1e6b493792084b33ee8cc5ba8d1be6) | 774 B |
| 12 | City / Street Environments Bundle (8 Packs) | [9ba069f](https://github.com/Bregermann/Asset-Consideration-Pile/commit/9ba069f00588f89425601067328e80907644e65a) | 801 B |
| 13 | Modern restaurant - building and interior | [88c692f](https://github.com/Bregermann/Asset-Consideration-Pile/commit/88c692fcdbfea157eeac6025c5bdfb34225a2a67) | 845 B |
| 14 | Retro Police Station Environment / Exterior + Interior | [60b7f39](https://github.com/Bregermann/Asset-Consideration-Pile/commit/60b7f39d9b08a0decfb40e3c429a576b4b9fdbfb) | 1,093 B |
| 15 | Compass Navigator Pro 4 | [dcf2379](https://github.com/Bregermann/Asset-Consideration-Pile/commit/dcf2379bde7d6bc39f9aad9063c0fb34022d5c4e) | 789 B |
| 16 | Heat - Complete Modern UI | [f601477](https://github.com/Bregermann/Asset-Consideration-Pile/commit/f6014772683deec1c0853b6dc5bb63f9143f2a70) | 1,918 B |
| 17 | Advanced Helicopter Controller | [8ccb841](https://github.com/Bregermann/Asset-Consideration-Pile/commit/8ccb8411f0b9e0d3fe422d592452d1a53f7cd9f5) | 1,671 B |
| 18 | Train Controller (Railroad System) ULTIMATE COLLECTION | [11ecf75](https://github.com/Bregermann/Asset-Consideration-Pile/commit/11ecf754e62cfb6ad0fc3235ccf258bf37c3f014) | 2,394 B |
| 19 | Weather Maker - Volumetric Clouds and Weather System for Unity | [691f498](https://github.com/Bregermann/Asset-Consideration-Pile/commit/691f498904a89edff6730cb0d20258e76b7b0939) | 1,941 B |
| 20 | Cinemachine | [87487b2](https://github.com/Bregermann/Asset-Consideration-Pile/commit/87487b242d6ee62f3644d23fdb2aacb74b381b94) | 1,618 B |
| 21 | Controllable Forklift Free | [0fa122a](https://github.com/Bregermann/Asset-Consideration-Pile/commit/0fa122afa26ec62eefb26bdee8e3a9b74d3ac76f) | 1,777 B |
| 22 | Instant Destruction - Easy GPU Fracture | [3fa11a0](https://github.com/Bregermann/Asset-Consideration-Pile/commit/3fa11a0d64ae3bf804eed3e15e22c22726268e66) | 1,732 B |
| 23 | Super Level Optimizer 2 | [29ccf20](https://github.com/Bregermann/Asset-Consideration-Pile/commit/29ccf209f32bce7189e7b268b547ae10c982b698) | 2,024 B |
| 24 | Weatherade: Snow and Rain System | [f877c57](https://github.com/Bregermann/Asset-Consideration-Pile/commit/f877c5784ddc5e0f02365b1ad9ba74e0b19aed08) | 2,370 B |
| 25 | Mesh Demolisher | [63894ed](https://github.com/Bregermann/Asset-Consideration-Pile/commit/63894ed49ea4c8bdd559772705e6cbc2c4c748d5) | 1,760 B |
| 26 | Police Car & Helicopter | [2e44388](https://github.com/Bregermann/Asset-Consideration-Pile/commit/2e44388e3bf91c7b2480121a2759ca7d0805b058) | 829 B |
| 27 | Core-Collapse | [c7a6ac1](https://github.com/Bregermann/Asset-Consideration-Pile/commit/c7a6ac1d1b8511d51722c7ed2e3b6be7cfb0070e) | 1,770 B |
| 28 | Customizable 3D Characters Complete Bundle | [e7aad21](https://github.com/Bregermann/Asset-Consideration-Pile/commit/e7aad21b51639bd6b4538756b97613bd2db0ae8c) | 809 B |
| 29 | FlexibleGlassDestructor | [d3414ee](https://github.com/Bregermann/Asset-Consideration-Pile/commit/d3414ee5bdece9e25086f5f80387b6ee9efda578) | 1,771 B |
| 30 | Industrial Props Equipment Mega Bundle | [6ec5c8b](https://github.com/Bregermann/Asset-Consideration-Pile/commit/6ec5c8b4ac34e1b0d24592f6bb8552ff65f9502a) | 796 B |
| 31 | POLYGON - Nightclubs Pack - Art by Synty | [561858d](https://github.com/Bregermann/Asset-Consideration-Pile/commit/561858d5e2bb9ab5c646385f412a8658262b3804) | 1,945 B |
| 32 | Vista Personal - Procedural Terrain Generator with Biomes | [c1fd053](https://github.com/Bregermann/Asset-Consideration-Pile/commit/c1fd053c8fa223c93a7d79375d51a01b05db5b52) | 748 B |
| 33 | EmbersStorm - Free Piper M350 Plane | [33f51a4](https://github.com/Bregermann/Asset-Consideration-Pile/commit/33f51a43abddc18562f85295da3a2d5a3edd61b3) | 829 B |
| 34 | Road Props Collection | [143e8b6](https://github.com/Bregermann/Asset-Consideration-Pile/commit/143e8b6f7e55cf8992a94df8b7d84f8359b0c936) | 839 B |
| 35 | Scriptable Sheets | [37fc576](https://github.com/Bregermann/Asset-Consideration-Pile/commit/37fc5762462c0809a8f297100b926dbfd1b215c5) | 1,801 B |
| 36 | Yue Destructible Objects Package Glass | [735f692](https://github.com/Bregermann/Asset-Consideration-Pile/commit/735f692cd57e9be53ce409a58d5ccb5f14393ba7) | 1,776 B |
| 37 | Garage Warehouse Environment ( Garage Warehouse , Modular Garage , Garage ) | [fb4be36](https://github.com/Bregermann/Asset-Consideration-Pile/commit/fb4be3694dcae71aa14aabfb1e2496b273eb65f1) | 815 B |
| 38 | Human Melee Animations | [06ff8bb](https://github.com/Bregermann/Asset-Consideration-Pile/commit/06ff8bbf8bf24a3b719aa51cc7801d9011d3bbec) | 1,865 B |
| 39 | MC Greet & Talk - Believable 3D Animations by MoCap Central | [13445de](https://github.com/Bregermann/Asset-Consideration-Pile/commit/13445de49a555ec8e43636d0c1885d29afea7598) | 862 B |
| 40 | UI Navigation Wizard - Gamepad / Keyboard Navigation & Selection | [f8f3d2d](https://github.com/Bregermann/Asset-Consideration-Pile/commit/f8f3d2d2ddf6c7e9ddaf6810ca2e2b3487234705) | 848 B |
| 41 | Modular Burger Shop Environment | [3678731](https://github.com/Bregermann/Asset-Consideration-Pile/commit/36787317ad878e327a8762fe4f910511df904ec0) | 809 B |
| 42 | Modular Warehouse (Warehouse, Industrial Warehouse, Hangar, Factory, Warehouse) | [afa4569](https://github.com/Bregermann/Asset-Consideration-Pile/commit/afa4569bc2ee792df252e0a61cae3a453238c117) | 893 B |
| 43 | Omni Animation - Core Locomotion Pack | [f5136d3](https://github.com/Bregermann/Asset-Consideration-Pile/commit/f5136d3dc36b32be64cc4a0fc5b16e745fcf6337) | 2,009 B |
| 44 | Prefab World Builder | [d7ba931](https://github.com/Bregermann/Asset-Consideration-Pile/commit/d7ba93141f2bc1b33f2a2d7564c27db2915a2793) | 816 B |
| 45 | Ultimate Sound FX Bundle | [ee3ec2d](https://github.com/Bregermann/Asset-Consideration-Pile/commit/ee3ec2d48b95bf6c52240447c5fb0256ea3c3fd1) | 1,584 B |
| 46 | Procedural Cracks | [c22d62b](https://github.com/Bregermann/Asset-Consideration-Pile/commit/c22d62b87db32cf9249dac7638a4adc7462f7ccc) | 796 B |
| 47 | Urban Abandoned District | [4884a90](https://github.com/Bregermann/Asset-Consideration-Pile/commit/4884a904956a939dc34b069be0f4a6d2d427c042) | 943 B |
| 48 | Character Customizer | [cd3dc90](https://github.com/Bregermann/Asset-Consideration-Pile/commit/cd3dc90df8f24a7a87d983215a564f9e6cd2bcc1) | 805 B |
| 49 | Complete Off-Road Racing (PC / Console) for URP | [d9c8315](https://github.com/Bregermann/Asset-Consideration-Pile/commit/d9c831549b7c303eed8fe9ce1cf916fb6642236a) | 948 B |
| 50 | Military Cargo Aircraft | [f261714](https://github.com/Bregermann/Asset-Consideration-Pile/commit/f2617147066700d6c2200a3ca2ff7214e74fa675) | 787 B |
| 51 | Oceanis 2026 Pro URP Water Framework | [532e7ab](https://github.com/Bregermann/Asset-Consideration-Pile/commit/532e7abc17823738d62fb653b0c810bb085be413) | 907 B |
| 52 | Abandoned Factory (Factory, Warehouse, Industrial Factory, Industrial Warehouse) | [0eed646](https://github.com/Bregermann/Asset-Consideration-Pile/commit/0eed6466089adc3694a5ae7148e74fab707cd4e8) | 2,132 B |
| 53 | Advanced Foliage Pack 2.0 | [bb4dd5f](https://github.com/Bregermann/Asset-Consideration-Pile/commit/bb4dd5f01373a9b5064a87d5b12896f81aaaa18d) | 1,871 B |
| 54 | Motion Warping: Climb & Interact | [b2bcc60](https://github.com/Bregermann/Asset-Consideration-Pile/commit/b2bcc60bb5d918c50a57da576ac0cf109a7e06f1) | 1,593 B |
| 55 | Procedural City Generator | [1632cfa](https://github.com/Bregermann/Asset-Consideration-Pile/commit/1632cfa4c7a4167d981fc1125a6a013d9500fa36) | 1,750 B |
| 56 | Rigged Construction Truck Vehicle | [f1e5302](https://github.com/Bregermann/Asset-Consideration-Pile/commit/f1e530227b35aef383ce644972fc0c101d3a24d1) | 830 B |
| 57 | Transport Helicopter | [ca966b4](https://github.com/Bregermann/Asset-Consideration-Pile/commit/ca966b4ba6c2ae375960939b4e5455157f90d2d7) | 827 B |
| 58 | Game Action System - Gameplay Interaction Framework | [c5560c1](https://github.com/Bregermann/Asset-Consideration-Pile/commit/c5560c198405e3770ab72d9fc3b35eabe35489f9) | 1,848 B |
| 59 | Industrial Shipping Container Pack | [ef1ef54](https://github.com/Bregermann/Asset-Consideration-Pile/commit/ef1ef5416fa55104f91d572c15ad8661ac9fd6fb) | 829 B |
| 60 | Base Helicopter Controller | [6ade1d3](https://github.com/Bregermann/Asset-Consideration-Pile/commit/6ade1d35c7b4c7008f0b5979d879778a6e784f7c) | 1,725 B |
| 61 | Easy Drone Controller | [35e145b](https://github.com/Bregermann/Asset-Consideration-Pile/commit/35e145b3afaf6e92454525b2845535430b675003) | 746 B |
| 62 | Free Fire VFX - URP | [8751946](https://github.com/Bregermann/Asset-Consideration-Pile/commit/8751946fe23172acebbd0d857c3442cb4a1d5016) | 1,924 B |
| 63 | French Quarter Street Environment | [73b7abc](https://github.com/Bregermann/Asset-Consideration-Pile/commit/73b7abc897ae93bfc3254524d5ee016c71016969) | 952 B |
| 64 | GamePad and Keyboard Input Sprites for TextMesh Pro | [dc04733](https://github.com/Bregermann/Asset-Consideration-Pile/commit/dc0473300f5ebac622acc378f084d484454f4733) | 776 B |
| 65 | Mall Environment | [14ef62e](https://github.com/Bregermann/Asset-Consideration-Pile/commit/14ef62e37d77d514fff6253d1c004f7b86ca8d73) | 758 B |
| 66 | Midnight Downtown | [05df11d](https://github.com/Bregermann/Asset-Consideration-Pile/commit/05df11d27a52356e454d71092a982d57eb62f997) | 1,941 B |
| 67 | Modern Guns: Handgun | [f285014](https://github.com/Bregermann/Asset-Consideration-Pile/commit/f285014b27c97b416a45bbc68dba97c35503ce1c) | 1,886 B |
| 68 | Modern Weapons Pack | [8862aeb](https://github.com/Bregermann/Asset-Consideration-Pile/commit/8862aeb6a281a35d0edfcec77efc47532b80c5c4) | 1,055 B |
| 69 | Outlaw Loops - Modern Western Music | [0d58853](https://github.com/Bregermann/Asset-Consideration-Pile/commit/0d58853521fa8d1b6b4ef1aff0b72d038b327b5e) | 748 B |
| 70 | Screen Damage | [2efffde](https://github.com/Bregermann/Asset-Consideration-Pile/commit/2efffdec0b9d95c8953c63223f8f6d5ad45c65b9) | 1,724 B |
| 71 | Trailer with Chassis Pack | [b3d5e3a](https://github.com/Bregermann/Asset-Consideration-Pile/commit/b3d5e3a59c22f8c92221fb998f39cdb953186ed6) | 751 B |

## Separately licensed payload pushes

- 03 JU TPS 3 - Third Person Shooter GameKit + Vehicle Physics — 23,684,823 bytes. [Verified CC0 commit](https://github.com/Bregermann/Asset-Consideration-Pile/commit/71ecdc0b302b780aead512c32495e1e8ec17d36f)
- 22 Instant Destruction - Easy GPU Fracture — 838,162 bytes. [Verified CC0 commit](https://github.com/Bregermann/Asset-Consideration-Pile/commit/df9424887e25cd1ae07a4fa8154f7cf0fc69b479)
- 51 Oceanis 2026 Pro URP Water Framework — 13,080,478 bytes. [Verified CC0 commit](https://github.com/Bregermann/Asset-Consideration-Pile/commit/932ea07ab2f195fb1374255f9522b9fff4bc23fd)
- 20 Cinemachine. [Verified Unity companion-licensed code commit](https://github.com/Bregermann/Asset-Consideration-Pile/commit/1e381b4a191f19ad8202971a5d2b8a7c8654a534)
- 01 NWH Vehicle Physics 2. [Verified separately licensed subset](https://github.com/Bregermann/Asset-Consideration-Pile/commit/85a24e1e25084d9720045a1d16854038abdaced4)
- 05 Dialogue System for Unity. [Verified separately licensed subset](https://github.com/Bregermann/Asset-Consideration-Pile/commit/8ef0d2179d3f421f317dbefa113fa1884c4b6255)
- 40 UI Navigation Wizard - Gamepad / Keyboard Navigation & Selection. [Verified separately licensed subset](https://github.com/Bregermann/Asset-Consideration-Pile/commit/66387d3b7b92b19cb2f3c291aa867627e2076778)
- 51 Oceanis 2026 Pro URP Water Framework. [Verified separately licensed subset](https://github.com/Bregermann/Asset-Consideration-Pile/commit/779db921791615361265c496ab5284ae53ea94b7)
- 53 Advanced Foliage Pack 2.0. [Verified separately licensed subset](https://github.com/Bregermann/Asset-Consideration-Pile/commit/5808cc4f0256cc92551cf9b9c232a19a1ce869b7)
- 58 Game Action System - Gameplay Interaction Framework. [Verified separately licensed subset](https://github.com/Bregermann/Asset-Consideration-Pile/commit/ad879c2da24e32c7ded74599fd05798ffdfbb543)
- 51 Oceanis 2026 Pro URP Water Framework. [Verified additional MIT subset](https://github.com/Bregermann/Asset-Consideration-Pile/commit/b311cd92e476063413009f5006aceea3516d61a5)

## Outstanding work

- 12 **City / Street Environments Bundle (8 Packs)**. The Unity 6 URP smoke test passed for the documentation wrapper. All 8 constituent archives were verified and individually tested. [Restore notes](MovingViolation/Packages/12.md)
- 28 **Customizable 3D Characters Complete Bundle**. The Unity 6 URP smoke test passed for the documentation wrapper. The 12 constituent products use separate Asset Store entitlements and were unavailable in the signed-in Unity account. [Restore notes](MovingViolation/Packages/28.md)
- 68 **Modern Weapons Pack**. Unity’s signed-in Package Manager returned an ownership record for product 14233. The native download was requested on three occasions and returned AssetStoreOperationError on both observed retries. Neither verified cache held a complete matching archive, so no source import or Unity smoke could run. [Restore notes](MovingViolation/Packages/68.md)

## Isolated compatibility results

- 03 **JU TPS 3 - Third Person Shooter GameKit + Vehicle Physics**. Isolated Unity 6000.3.6f1 URP smoke yielded exit 0, refresh completed True, 11 C# error lines and 0 matched asset/dependency import errors. First compiler diagnostic: Assets\Julhiecio TPS Controller\Scripts\Effects\BodyLeanInert.cs(38,31): error CS0619: 'AnimatorUpdateMode.AnimatePhysics' is obsolete: 'Enum member AnimatorUpdateMode.AnimatePhysics has been deprecated. Use AnimatorUpdateMode.Fixed to evaluate in FixedUpdate time and Animator.animatePhysics to sync transforms for physics. (UnityUpgradable) -> Fixed'. [Package evidence](MovingViolation/Packages/03.md)
- 04 **Urban Traffic System Full Pack**. Isolated Unity 6000.3.6f1 URP smoke: process exit 0; Asset Database refresh completed: True; 0 C# error lines and 0 matched asset/dependency import errors. Central integration was deferred because the archive ships project-scope paths or overlaps existing content. [Package evidence](MovingViolation/Packages/04.md)
- 05 **Dialogue System for Unity**. Isolated Unity 6000.3.6f1 URP smoke yielded exit 0, refresh completed True, 0 C# error lines and 0 matched asset/dependency import errors. The isolated archive remains available for a scoped merge. Existing path has different content: Assets/Gizmos.meta. [Package evidence](MovingViolation/Packages/05.md)
- 16 **Heat - Complete Modern UI**. Isolated Unity 6000.3.6f1 URP smoke yielded exit 1, refresh completed False, 3 C# error lines and 0 matched asset/dependency import errors. First compiler diagnostic: Assets\Heat - Complete Modern UI\Scripts\Panels\SettingsDescription.cs(23,27): error CS1501: No overload for method 'FindObjectsByType' takes 0 arguments. [Package evidence](MovingViolation/Packages/16.md)
- 18 **Train Controller (Railroad System) ULTIMATE COLLECTION**. Isolated Unity 6000.3.6f1 URP smoke yielded exit 0, refresh completed True, 0 C# error lines and 0 matched asset/dependency import errors. Central integration was deferred because the archive ships project-scope paths or overlaps existing content. [Package evidence](MovingViolation/Packages/18.md)
- 21 **Controllable Forklift Free**. Isolated Unity 6000.3.6f1 URP smoke yielded exit 0, refresh completed True, 0 C# error lines and 1 matched asset/dependency import errors. First import diagnostic: Start importing Assets/FreeForkLift/Prefabs/Main Camera.prefab using Guid(a806d004969b3054db4834b58b102064) (PrefabImporter)Problem detected while importing the Prefab file: 'Assets/FreeForkLift/Prefabs/Main Camera.prefab'.. [Package evidence](MovingViolation/Packages/21.md)
- 24 **Weatherade: Snow and Rain System**. Isolated Unity 6000.3.6f1 URP smoke yielded exit 1, refresh completed False, 175 C# error lines and 0 matched asset/dependency import errors. First compiler diagnostic: Assets\NOT_Lonely\FirstPersonController\NL_Footsteps.cs(15,20): error CS0619: 'PhysicMaterial' is obsolete: 'PhysicMaterial has been renamed to PhysicsMaterial. Please use PhysicsMaterial instead. (UnityUpgradable) -> PhysicsMaterial'. [Package evidence](MovingViolation/Packages/24.md)
- 27 **Core-Collapse**. Isolated Unity 6000.3.6f1 URP smoke yielded exit 0, refresh completed True, 0 C# error lines and 0 matched asset/dependency import errors. Central integration was deferred because the archive ships project-scope paths or overlaps existing content. [Package evidence](MovingViolation/Packages/27.md)
- 30 **Industrial Props Equipment Mega Bundle**. The Unity 6 URP smoke test passed for the documentation wrapper. All 21 constituent archives were verified and individually tested. [Package evidence](MovingViolation/Packages/30.md)
- 38 **Human Melee Animations**. Isolated Unity 6000.3.6f1 URP smoke yielded exit 0, refresh completed True, 0 C# error lines and 0 matched asset/dependency import errors. The isolated archive remains available for a scoped merge. Existing path has different content: Assets/Kevin Iglesias/Human Animations/Animations/Female/Combat/HumanF@Stun01.fbx. [Package evidence](MovingViolation/Packages/38.md)
- 49 **Complete Off-Road Racing (PC / Console) for URP**. Retested the original vendor Assets in a separate Unity project without the template sample scene, Settings assets or input asset. Isolated Unity 6000.3.6f1 URP smoke yielded exit 1, refresh completed False, 36 C# error lines and 0 matched asset/dependency import errors. First compiler diagnostic: Assets\Off_Road_Racing\Scripts\AI\Race_Manager.cs(259,51): error CS1501: No overload for method 'FindObjectsByType' takes 0 arguments. [Package evidence](MovingViolation/Packages/49.md)
- 60 **Base Helicopter Controller**. Isolated Unity 6000.3.6f1 URP smoke yielded exit 1, refresh completed False, 3 C# error lines and 0 matched asset/dependency import errors. First compiler diagnostic: Assets\Helicopter\Scripts\CheckpointController.cs(4,23): error CS0234: The type or namespace name 'Policy' does not exist in the namespace 'System.Security' (are you missing an assembly reference?). [Package evidence](MovingViolation/Packages/60.md)
