# Moving Violation S/A asset intake

Intake status on 2026-11-19. The manifest has the requested 11 S and 60 A rows in priority order. This report records the last verified state of each package.

- Archive evidence for 70 of 71 packages, with 69,061,890,903 bytes in inventoried payloads before Unity sidecars.
- 10 packages recorded as active in the Pile, totaling 18,105,752,442 payload bytes.
- 18 confirmed asset metadata checkpoints. Tracked vendor payload totals 23,684,823 bytes of separately licensed media.
- 82 inventoried files at or above 50 MiB. See [Local-only size exclusions](MovingViolation/LocalOnlyRestore.csv) for paths and sidecars.
- Isolated Unity 6000.3.6f1 URP baseline: exit code 0, refresh completed True, compiler errors 0. The live Pile had an existing Infinity PBR demo prefab error before this intake.

| Disposition | Packages |
| --- | ---: |
| `ALREADY_PRESENT_VALIDATED` | 1 |
| `FAILED_RETRY_NEEDED` | 57 |
| `INCOMPATIBLE_ISOLATED` | 4 |
| `LOCAL_ONLY_LICENSE` | 9 |

## Evidence and rehydration

- [71-package manifest](MovingViolation_AssetIntake_Manifest.csv) tracks exact identity, activity, local source state, compatibility evidence, dependencies and verified checkpoint SHAs.
- [Local asset file index](MovingViolation/LocalAssetPaths.csv) lists verified file paths and their source package versions.
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
| 12 | City / Street Environments Bundle (8 Packs) | [46e81cf](https://github.com/Bregermann/Asset-Consideration-Pile/commit/46e81cfe77d83190a457f044dcbb79029bce39dc) | 1,772 B |
| 13 | Modern restaurant - building and interior | [6cbf421](https://github.com/Bregermann/Asset-Consideration-Pile/commit/6cbf421000e8a6a3ad76e1ff976359bf88d6be7b) | 761 B |
| 14 | Retro Police Station Environment / Exterior + Interior | [d79e1b2](https://github.com/Bregermann/Asset-Consideration-Pile/commit/d79e1b2915b7d0635480ff50cfc73256aa97ca14) | 2,242 B |
| 15 | Compass Navigator Pro 4 | [0375f11](https://github.com/Bregermann/Asset-Consideration-Pile/commit/0375f1108104279119a9d1032fc7566fe96dd11e) | 1,911 B |
| 16 | Heat - Complete Modern UI | [f601477](https://github.com/Bregermann/Asset-Consideration-Pile/commit/f6014772683deec1c0853b6dc5bb63f9143f2a70) | 1,918 B |
| 17 | Advanced Helicopter Controller | [8ccb841](https://github.com/Bregermann/Asset-Consideration-Pile/commit/8ccb8411f0b9e0d3fe422d592452d1a53f7cd9f5) | 1,671 B |
| 45 | Ultimate Sound FX Bundle | [ee3ec2d](https://github.com/Bregermann/Asset-Consideration-Pile/commit/ee3ec2d48b95bf6c52240447c5fb0256ea3c3fd1) | 1,584 B |

## Separately licensed media pushes

- 03 JU TPS 3 - Third Person Shooter GameKit + Vehicle Physics — 23,684,823 bytes. [Verified CC0 commit](https://github.com/Bregermann/Asset-Consideration-Pile/commit/71ecdc0b302b780aead512c32495e1e8ec17d36f)

## Outstanding work

- 12 **City / Street Environments Bundle (8 Packs)**. Static preflight found 0 duplicate GUIDs within the archive, 0 duplicate C# file hashes and 0 source files without a shipped sidecar. Scanned text Unity assets refer to 3 GUIDs outside this package and the indexed project/registry packages. Built-in engine resources, binary serialized objects and runtime links require separate review. Highest-frequency unresolved GUIDs: `7a68c43fe1f2a47cfa234b5eeaa98012` (1 files), `23c1ce4fb46143f46bc5cb5224c934f6` (1 files), `441482e8936e35048a1dffac814e3ef8` (1 files). City bundle component IDs: 290716, 315413, 272227, 303625, 228679, 357022, 252380 and 240150.
- 13 **Modern restaurant - building and interior**. Static preflight found 0 duplicate GUIDs within the archive, 0 duplicate C# file hashes and 0 source files without a shipped sidecar. Scanned text Unity assets refer to 8 GUIDs outside this package and the indexed project/registry packages. Built-in engine resources, binary serialized objects and runtime links require separate review. Highest-frequency unresolved GUIDs: `2d94245116ccc3d4ebc1d22a0dcdad50` (1 files), `9e98653779b302f4b8541b444993a920` (1 files), `c1cb7e9e120078f43bce4f0b1be547a7` (1 files), `7a34fa72bd4185749832024e9c8010bf` (1 files), `48a79b01ea5641d4aa6daa2e23605641` (1 files).
- 14 **Retro Police Station Environment / Exterior + Interior**. Static preflight found 0 duplicate GUIDs within the archive, 0 duplicate C# file hashes and 0 source files without a shipped sidecar. Scanned text Unity assets refer to 93 GUIDs outside this package and the indexed project/registry packages. Built-in engine resources, binary serialized objects and runtime links require separate review. Highest-frequency unresolved GUIDs: `da692e001514ec24dbc4cca1949ff7e8` (225 files), `6e4ae4064600d784cac1e41a9e6f2e59` (19 files), `7a68c43fe1f2a47cfa234b5eeaa98012` (4 files), `0d7593b3a9277ac4696b20006c21dde2` (3 files), `4b8bcdf71d7fafa419fca1ed162f5fc9` (3 files).
- 15 **Compass Navigator Pro 4**. Static preflight found 0 duplicate GUIDs within the archive, 0 duplicate C# file hashes and 0 source files without a shipped sidecar. Scanned text Unity assets refer to 11 GUIDs outside this package and the indexed project/registry packages. Built-in engine resources, binary serialized objects and runtime links require separate review. Highest-frequency unresolved GUIDs: `dd89cf5b9246416f84610a006f916af7` (2 files), `46328ae7462854e029d028cf838727a1` (2 files), `624d8ceb46d0543f19ff28c48ea38bd0` (2 files), `e6fa1a4fd31164876a1cf0d185e282c7` (2 files), `3315e28a11c7e4975a7e937bcda98936` (1 files).
- 18 **Train Controller (Railroad System) ULTIMATE COLLECTION**. Run the one-package Unity smoke test, inspect dependencies and retain a separate copy if there are conflicts.
- 19 **Weather Maker - Volumetric Clouds and Weather System for Unity**. Run the one-package Unity smoke test, inspect dependencies and retain a separate copy if there are conflicts.
- 20 **Cinemachine**. Run the one-package Unity smoke test, inspect dependencies and retain a separate copy if there are conflicts. Unity also publishes the supported com.unity.cinemachine UPM package. Treat registry and legacy Asset Store releases separately.
- 21 **Controllable Forklift Free**. Run the one-package Unity smoke test, inspect dependencies and retain a separate copy if there are conflicts.
- 22 **Instant Destruction - Easy GPU Fracture**. Run the one-package Unity smoke test, inspect dependencies and retain a separate copy if there are conflicts.
- 23 **Super Level Optimizer 2**. Run the one-package Unity smoke test, inspect dependencies and retain a separate copy if there are conflicts.
- 24 **Weatherade: Snow and Rain System**. Run the one-package Unity smoke test, inspect dependencies and retain a separate copy if there are conflicts.
- 25 **Mesh Demolisher**. Run the one-package Unity smoke test, inspect dependencies and retain a separate copy if there are conflicts.
- 26 **Police Car & Helicopter**. Run the one-package Unity smoke test, inspect dependencies and retain a separate copy if there are conflicts.
- 27 **Core-Collapse**. Run the one-package Unity smoke test, inspect dependencies and retain a separate copy if there are conflicts.
- 28 **Customizable 3D Characters Complete Bundle**. Run the one-package Unity smoke test, inspect dependencies and retain a separate copy if there are conflicts.
- 29 **FlexibleGlassDestructor**. Run the one-package Unity smoke test, inspect dependencies and retain a separate copy if there are conflicts.
- 30 **Industrial Props Equipment Mega Bundle**. Run the one-package Unity smoke test, inspect dependencies and retain a separate copy if there are conflicts.
- 31 **POLYGON - Nightclubs Pack - Art by Synty**. Run the one-package Unity smoke test, inspect dependencies and retain a separate copy if there are conflicts.
- 32 **Vista Personal - Procedural Terrain Generator with Biomes**. Run the one-package Unity smoke test, inspect dependencies and retain a separate copy if there are conflicts.
- 33 **EmbersStorm - Free Piper M350 Plane**. Run the one-package Unity smoke test, inspect dependencies and retain a separate copy if there are conflicts.
- 34 **Road Props Collection**. Run the one-package Unity smoke test, inspect dependencies and retain a separate copy if there are conflicts.
- 35 **Scriptable Sheets**. Run the one-package Unity smoke test, inspect dependencies and retain a separate copy if there are conflicts.
- 36 **Yue Destructible Objects Package Glass**. Run the one-package Unity smoke test, inspect dependencies and retain a separate copy if there are conflicts.
- 37 **Garage Warehouse Environment ( Garage Warehouse , Modular Garage , Garage )**. Run the one-package Unity smoke test, inspect dependencies and retain a separate copy if there are conflicts.
- 38 **Human Melee Animations**. Run the one-package Unity smoke test, inspect dependencies and retain a separate copy if there are conflicts.
- 39 **MC Greet & Talk - Believable 3D Animations by MoCap Central**. Run the one-package Unity smoke test, inspect dependencies and retain a separate copy if there are conflicts.
- 40 **UI Navigation Wizard - Gamepad / Keyboard Navigation & Selection**. Run the one-package Unity smoke test, inspect dependencies and retain a separate copy if there are conflicts.
- 41 **Modular Burger Shop Environment**. Run the one-package Unity smoke test, inspect dependencies and retain a separate copy if there are conflicts.
- 42 **Modular Warehouse (Warehouse, Industrial Warehouse, Hangar, Factory, Warehouse)**. Run the one-package Unity smoke test, inspect dependencies and retain a separate copy if there are conflicts.
- 43 **Omni Animation - Core Locomotion Pack**. Run the one-package Unity smoke test, inspect dependencies and retain a separate copy if there are conflicts.
- 44 **Prefab World Builder**. Run the one-package Unity smoke test, inspect dependencies and retain a separate copy if there are conflicts.
- 46 **Procedural Cracks**. Run the one-package Unity smoke test, inspect dependencies and retain a separate copy if there are conflicts.
- 47 **Urban Abandoned District**. Run the one-package Unity smoke test, inspect dependencies and retain a separate copy if there are conflicts.
- 48 **Character Customizer**. Run the one-package Unity smoke test, inspect dependencies and retain a separate copy if there are conflicts.
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
- 68 **Modern Weapons Pack**. Complete the authenticated Package Manager download or restore the owned archive.
- 69 **Outlaw Loops - Modern Western Music**. Run the one-package Unity smoke test, inspect dependencies and retain a separate copy if there are conflicts.
- 70 **Screen Damage**. Run the one-package Unity smoke test, inspect dependencies and retain a separate copy if there are conflicts.
- 71 **Trailer with Chassis Pack**. Run the one-package Unity smoke test, inspect dependencies and retain a separate copy if there are conflicts.
