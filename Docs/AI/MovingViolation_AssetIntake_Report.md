# Moving Violation S/A asset intake

Intake status on 2026-11-19. The manifest has the requested 11 S and 60 A rows in priority order. This report records the last verified state of each package.

- Archive evidence for 70 of 71 packages, with 69,062,721,720 bytes in inventoried payloads before Unity sidecars.
- 22 packages recorded as active in the Pile, totaling 21,029,227,096 payload bytes.
- 49 confirmed asset metadata checkpoints. Tracked vendor payload totals 34,352,710 bytes of separately licensed source and media.
- 82 inventoried files at or above 50 MiB. See [Local-only size exclusions](MovingViolation/LocalOnlyRestore.csv) for all local-only source paths and sidecars.
- Isolated Unity 6000.3.6f1 URP baseline: exit code 0, refresh completed True, compiler errors 0. The live Pile had an existing Infinity PBR demo prefab error before this intake.

| Disposition | Packages |
| --- | ---: |
| `ALREADY_PRESENT_VALIDATED` | 1 |
| `FAILED_RETRY_NEEDED` | 30 |
| `INCOMPATIBLE_ISOLATED` | 19 |
| `LOCAL_ONLY_LICENSE` | 21 |

## Evidence and rehydration

- [71-package manifest](MovingViolation_AssetIntake_Manifest.csv) tracks exact identity, activity, local source state, compatibility evidence, dependencies and verified checkpoint SHAs.
- [Local-only restore catalogue](MovingViolation/LocalOnlyRestore.csv) lists 45,442 source paths with exact package identity, restore location, local-only reason and dependency notes.
- [Local asset file index](MovingViolation/LocalAssetPaths.csv) lists verified file paths and their source package versions.
- [Bundle constituent catalogue](MovingViolation/BundleComponents.csv) records each separately distributed city, character and industrial product.
- [Weather foundation and open checks](MovingViolation/WeatherFoundation.md) maps the Interstate Hauler coordinator, Weather Maker and Weatherade.
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
| 12 | City / Street Environments Bundle (8 Packs) | [55db6d3](https://github.com/Bregermann/Asset-Consideration-Pile/commit/55db6d301f01851154476a9868a0e6a4b4fa6692) | 593 B |
| 13 | Modern restaurant - building and interior | [6cbf421](https://github.com/Bregermann/Asset-Consideration-Pile/commit/6cbf421000e8a6a3ad76e1ff976359bf88d6be7b) | 761 B |
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
| 26 | Police Car & Helicopter | [0cd45dc](https://github.com/Bregermann/Asset-Consideration-Pile/commit/0cd45dc5ff274abe7e84c62e15c99a7cab85be42) | 1,641 B |
| 27 | Core-Collapse | [c7a6ac1](https://github.com/Bregermann/Asset-Consideration-Pile/commit/c7a6ac1d1b8511d51722c7ed2e3b6be7cfb0070e) | 1,770 B |
| 28 | Customizable 3D Characters Complete Bundle | [7a5ee4d](https://github.com/Bregermann/Asset-Consideration-Pile/commit/7a5ee4d279a980ce24de0a27394ee26c52c0a7e7) | 924 B |
| 29 | FlexibleGlassDestructor | [d3414ee](https://github.com/Bregermann/Asset-Consideration-Pile/commit/d3414ee5bdece9e25086f5f80387b6ee9efda578) | 1,771 B |
| 30 | Industrial Props Equipment Mega Bundle | [68254a0](https://github.com/Bregermann/Asset-Consideration-Pile/commit/68254a01779cbbd239735da6469d21ed28b29ad9) | 992 B |
| 31 | POLYGON - Nightclubs Pack - Art by Synty | [561858d](https://github.com/Bregermann/Asset-Consideration-Pile/commit/561858d5e2bb9ab5c646385f412a8658262b3804) | 1,945 B |
| 32 | Vista Personal - Procedural Terrain Generator with Biomes | [5371989](https://github.com/Bregermann/Asset-Consideration-Pile/commit/5371989cf1b8299a3d7947a8ea9c9026eb0033ab) | 2,027 B |
| 33 | EmbersStorm - Free Piper M350 Plane | [e0f9f0f](https://github.com/Bregermann/Asset-Consideration-Pile/commit/e0f9f0f9a6fdb8a332206adf4579d9824a4c456f) | 1,605 B |
| 34 | Road Props Collection | [f812ebf](https://github.com/Bregermann/Asset-Consideration-Pile/commit/f812ebfde2e9a7d821072f52f8bbb41c3f572f76) | 1,767 B |
| 35 | Scriptable Sheets | [37fc576](https://github.com/Bregermann/Asset-Consideration-Pile/commit/37fc5762462c0809a8f297100b926dbfd1b215c5) | 1,801 B |
| 36 | Yue Destructible Objects Package Glass | [735f692](https://github.com/Bregermann/Asset-Consideration-Pile/commit/735f692cd57e9be53ce409a58d5ccb5f14393ba7) | 1,776 B |
| 37 | Garage Warehouse Environment ( Garage Warehouse , Modular Garage , Garage ) | [55bd494](https://github.com/Bregermann/Asset-Consideration-Pile/commit/55bd494fdb4c5f5069b107166fc80322d24c0f32) | 2,064 B |
| 38 | Human Melee Animations | [06ff8bb](https://github.com/Bregermann/Asset-Consideration-Pile/commit/06ff8bbf8bf24a3b719aa51cc7801d9011d3bbec) | 1,865 B |
| 39 | MC Greet & Talk - Believable 3D Animations by MoCap Central | [3922428](https://github.com/Bregermann/Asset-Consideration-Pile/commit/3922428a6086c5038686c3d4b4871fd5cf9f344e) | 1,728 B |
| 40 | UI Navigation Wizard - Gamepad / Keyboard Navigation & Selection | [9542c81](https://github.com/Bregermann/Asset-Consideration-Pile/commit/9542c81bd1be26a2b426b418130d8ebbcc11c6d6) | 1,864 B |
| 41 | Modular Burger Shop Environment | [c397494](https://github.com/Bregermann/Asset-Consideration-Pile/commit/c3974944e10b65f5914c2b3399c7979ebef7454e) | 1,839 B |
| 42 | Modular Warehouse (Warehouse, Industrial Warehouse, Hangar, Factory, Warehouse) | [f6d30ed](https://github.com/Bregermann/Asset-Consideration-Pile/commit/f6d30edb4b2d6ee2cae968004f54128a85aa790f) | 2,084 B |
| 43 | Omni Animation - Core Locomotion Pack | [f5136d3](https://github.com/Bregermann/Asset-Consideration-Pile/commit/f5136d3dc36b32be64cc4a0fc5b16e745fcf6337) | 2,009 B |
| 44 | Prefab World Builder | [60b925c](https://github.com/Bregermann/Asset-Consideration-Pile/commit/60b925ce688a0cc798ad46cad72c7b1a0da26a2f) | 1,564 B |
| 45 | Ultimate Sound FX Bundle | [ee3ec2d](https://github.com/Bregermann/Asset-Consideration-Pile/commit/ee3ec2d48b95bf6c52240447c5fb0256ea3c3fd1) | 1,584 B |
| 46 | Procedural Cracks | [4a5ee0f](https://github.com/Bregermann/Asset-Consideration-Pile/commit/4a5ee0f96eada3a3f28cd9c7ac05cc6f4c625bc7) | 1,580 B |
| 47 | Urban Abandoned District | [694754f](https://github.com/Bregermann/Asset-Consideration-Pile/commit/694754f4eeca99833900abf17095afe735182c9c) | 2,168 B |
| 48 | Character Customizer | [e45e026](https://github.com/Bregermann/Asset-Consideration-Pile/commit/e45e0267fe2b5f725f8aa9d517c305a8f3cabc2c) | 1,959 B |
| 68 | Modern Weapons Pack | [8862aeb](https://github.com/Bregermann/Asset-Consideration-Pile/commit/8862aeb6a281a35d0edfcec77efc47532b80c5c4) | 1,055 B |

## Separately licensed payload pushes

- 03 JU TPS 3 - Third Person Shooter GameKit + Vehicle Physics — 23,684,823 bytes. [Verified CC0 commit](https://github.com/Bregermann/Asset-Consideration-Pile/commit/71ecdc0b302b780aead512c32495e1e8ec17d36f)
- 22 Instant Destruction - Easy GPU Fracture — 838,162 bytes. [Verified CC0 commit](https://github.com/Bregermann/Asset-Consideration-Pile/commit/df9424887e25cd1ae07a4fa8154f7cf0fc69b479)
- 20 Cinemachine. [Verified Unity companion-licensed code commit](https://github.com/Bregermann/Asset-Consideration-Pile/commit/1e381b4a191f19ad8202971a5d2b8a7c8654a534)
- 05 Dialogue System for Unity. [Verified separately licensed subset](https://github.com/Bregermann/Asset-Consideration-Pile/commit/8ef0d2179d3f421f317dbefa113fa1884c4b6255)
- 40 UI Navigation Wizard - Gamepad / Keyboard Navigation & Selection. [Verified separately licensed subset](https://github.com/Bregermann/Asset-Consideration-Pile/commit/66387d3b7b92b19cb2f3c291aa867627e2076778)

## Outstanding work

- 12 **City / Street Environments Bundle (8 Packs)**. Static preflight found 0 duplicate GUIDs within the archive, 0 duplicate C# file hashes and 0 source files without a shipped sidecar. Scanned text Unity assets refer to 3 GUIDs outside this package and the indexed project/registry packages. Built-in engine resources, binary serialized objects and runtime links require separate review. Highest-frequency unresolved GUIDs: `441482e8936e35048a1dffac814e3ef8` (1 files), `7a68c43fe1f2a47cfa234b5eeaa98012` (1 files), `23c1ce4fb46143f46bc5cb5224c934f6` (1 files). City bundle component IDs: 290716, 315413, 272227, 303625, 228679, 357022, 252380 and 240150.
- 13 **Modern restaurant - building and interior**. Static preflight found 0 duplicate GUIDs within the archive, 0 duplicate C# file hashes and 0 source files without a shipped sidecar. Scanned text Unity assets refer to 8 GUIDs outside this package and the indexed project/registry packages. Built-in engine resources, binary serialized objects and runtime links require separate review. Highest-frequency unresolved GUIDs: `2d94245116ccc3d4ebc1d22a0dcdad50` (1 files), `9e98653779b302f4b8541b444993a920` (1 files), `c1cb7e9e120078f43bce4f0b1be547a7` (1 files), `7a34fa72bd4185749832024e9c8010bf` (1 files), `48a79b01ea5641d4aa6daa2e23605641` (1 files).
- 28 **Customizable 3D Characters Complete Bundle**. Vendor-listed constituent product IDs: 268078, 268079, 252324, 259337, 253976, 253977, 268076, 268077, 259335, 259336, 253975, 252325. Restore only confirmed owned downloads. The bundle parent remains pending until the constituent results are recorded.
- 30 **Industrial Props Equipment Mega Bundle**. Vendor-listed constituent product IDs: 259967, 261238, 293984, 294450, 294339, 295106, 294068, 291350, 291921, 291370, 292108, 291685, 292306, 291948, 293195, 291738, 294374, 364538, 292001, 314050, 291296. Restore only confirmed owned downloads. The bundle parent remains pending until the constituent results are recorded.
- 44 **Prefab World Builder**. Static preflight found 0 duplicate GUIDs within the archive, 7 duplicate C# file hashes and 0 source files without a shipped sidecar. Scanned text Unity assets refer to 2 GUIDs outside this package and the indexed project/registry packages. Built-in engine resources, binary serialized objects and runtime links require separate review. Highest-frequency unresolved GUIDs: `b51a78e223a2e504bb88a059b55229ea` (1 files), `2d08ce26990eb1a4a9177b860541e702` (1 files).
- 46 **Procedural Cracks**. Static preflight found 0 duplicate GUIDs within the archive, 0 duplicate C# file hashes and 0 source files without a shipped sidecar. Scanned text Unity assets refer to 0 GUIDs outside this package and the indexed project/registry packages. Built-in engine resources, binary serialized objects and runtime links require separate review.
- 48 **Character Customizer**. Static preflight found 0 duplicate GUIDs within the archive, 0 duplicate C# file hashes and 0 source files without a shipped sidecar. Scanned text Unity assets refer to 81 GUIDs outside this package and the indexed project/registry packages. Built-in engine resources, binary serialized objects and runtime links require separate review. Highest-frequency unresolved GUIDs: `da692e001514ec24dbc4cca1949ff7e8` (60 files), `93b18b8805345f949b2b816b36367cea` (8 files), `7d5d86426bdba414ab017ded309ca736` (6 files), `c374ac648d8927f4997431b3a097f0c3` (6 files), `68e6db2ebdc24f95958faec2be5558d6` (4 files).
- 49 **Complete Off-Road Racing (PC / Console) for URP**. Run the one-package Unity smoke test, inspect dependencies and retain a separate copy if there are conflicts.
- 50 **Military Cargo Aircraft**. Run the one-package Unity smoke test, inspect dependencies and retain a separate copy if there are conflicts.
- 51 **Oceanis 2026 Pro URP Water Framework**. Run the one-package Unity smoke test, inspect dependencies and retain a separate copy if there are conflicts.
- 52 **Abandoned Factory (Factory, Warehouse, Industrial Factory, Industrial Warehouse)**. Run the one-package Unity smoke test, inspect dependencies and retain a separate copy if there are conflicts.
- 53 **Advanced Foliage Pack 2.0**. Run the one-package Unity smoke test, inspect dependencies and retain a separate copy if there are conflicts.
- 54 **Motion Warping: Climb & Interact**. Run the one-package Unity smoke test, inspect dependencies and retain a separate copy if there are conflicts.
- 55 **Procedural City Generator**. Run the one-package Unity smoke test, inspect dependencies and retain a separate copy if there are conflicts.
- 56 **Rigged Construction Truck Vehicle**. Run the one-package Unity smoke test, inspect dependencies and retain a separate copy if there are conflicts.
- 57 **Transport Helicopter**. Run the one-package Unity smoke test, inspect dependencies and retain a separate copy if there are conflicts.
- 58 **Game Action System - Gameplay Interaction Framework**. Run the one-package Unity smoke test, inspect dependencies and retain a separate copy if there are conflicts.
- 59 **Industrial Shipping Container Pack**. Run the one-package Unity smoke test, inspect dependencies and retain a separate copy if there are conflicts.
- 60 **Base Helicopter Controller**. Run the one-package Unity smoke test, inspect dependencies and retain a separate copy if there are conflicts.
- 61 **Easy Drone Controller**. Run the one-package Unity smoke test, inspect dependencies and retain a separate copy if there are conflicts.
- 62 **Free Fire VFX - URP**. Run the one-package Unity smoke test, inspect dependencies and retain a separate copy if there are conflicts.
- 63 **French Quarter Street Environment**. Run the one-package Unity smoke test, inspect dependencies and retain a separate copy if there are conflicts.
- 64 **GamePad and Keyboard Input Sprites for TextMesh Pro**. Run the one-package Unity smoke test, inspect dependencies and retain a separate copy if there are conflicts.
- 65 **Mall Environment**. Run the one-package Unity smoke test, inspect dependencies and retain a separate copy if there are conflicts.
- 66 **Midnight Downtown**. Run the one-package Unity smoke test, inspect dependencies and retain a separate copy if there are conflicts.
- 67 **Modern Guns: Handgun**. Run the one-package Unity smoke test, inspect dependencies and retain a separate copy if there are conflicts.
- 68 **Modern Weapons Pack**. Retrieve the exact owned product from a recovered official Unity download or an existing licensed archive. Verify its publisher, version and GUIDs before importing it.
- 69 **Outlaw Loops - Modern Western Music**. Run the one-package Unity smoke test, inspect dependencies and retain a separate copy if there are conflicts.
- 70 **Screen Damage**. Run the one-package Unity smoke test, inspect dependencies and retain a separate copy if there are conflicts.
- 71 **Trailer with Chassis Pack**. Run the one-package Unity smoke test, inspect dependencies and retain a separate copy if there are conflicts.
