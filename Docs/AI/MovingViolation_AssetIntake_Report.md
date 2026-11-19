# Moving Violation S/A asset intake

Intake status on 2026-11-19. The manifest has the requested 11 S and 60 A rows in priority order. This report records the last verified state of each package.

- Archive evidence for 63 of 71 packages, with 56,458,064,975 bytes in inventoried payloads before Unity sidecars.
- 5 packages recorded as active in the Pile, totaling 12,663,285,000 payload bytes.
- 10 confirmed asset metadata checkpoints. Tracked vendor payload totals 0 bytes of separately licensed media.
- 67 inventoried files at or above 50 MiB. See [Local-only size exclusions](MovingViolation/LocalOnlyRestore.csv) for paths and sidecars.
- Isolated Unity 6000.3.6f1 URP baseline: exit code 0, refresh completed True, compiler errors 0. The live Pile had an existing Infinity PBR demo prefab error before this intake.

| Disposition | Packages |
| --- | ---: |
| `ALREADY_PRESENT_VALIDATED` | 1 |
| `FAILED_RETRY_NEEDED` | 62 |
| `INCOMPATIBLE_ISOLATED` | 4 |
| `LOCAL_ONLY_LICENSE` | 4 |

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
| 08 | Sundown:Shop/Store (Modular Shop, Supermarket, Convenience Store) | [1bdf1c4](https://github.com/Bregermann/Asset-Consideration-Pile/commit/1bdf1c4b376a3bcd492508023195793a0b717f7d) | 2,037 B |
| 09 | Love/Hate | [7a40b24](https://github.com/Bregermann/Asset-Consideration-Pile/commit/7a40b24ed575354b893895685a820d3783fc6f94) | 1,889 B |
| 11 | Scene Streamer | [8610ec3](https://github.com/Bregermann/Asset-Consideration-Pile/commit/8610ec3715c8cc616b043fa9081a9e6417ec7318) | 1,704 B |
| 13 | Modern restaurant - building and interior | [f329851](https://github.com/Bregermann/Asset-Consideration-Pile/commit/f3298517a2b2d3cd491fd12f2b3839125ee3a5f9) | 2,002 B |
| 45 | Ultimate Sound FX Bundle | [ee3ec2d](https://github.com/Bregermann/Asset-Consideration-Pile/commit/ee3ec2d48b95bf6c52240447c5fb0256ea3c3fd1) | 1,584 B |

## Separately licensed media pushes


## Outstanding work

- 06 **Mobile Pedestrian System**. Run the one-package Unity smoke test, inspect dependencies and retain a separate copy if there are conflicts.
- 07 **Miami Vice City**. Run the one-package Unity smoke test, inspect dependencies and retain a separate copy if there are conflicts.
- 10 **Human Basic Motions**. Run the one-package Unity smoke test, inspect dependencies and retain a separate copy if there are conflicts.
- 12 **City / Street Environments Bundle (8 Packs)**. Run the one-package Unity smoke test, inspect dependencies and retain a separate copy if there are conflicts.
- 13 **Modern restaurant - building and interior**. Static preflight found 0 duplicate GUIDs within the archive, 0 duplicate C# file hashes and 0 source files without a shipped sidecar. Scanned text Unity assets refer to 8 GUIDs outside this package and the indexed project/registry packages. Built-in engine resources, binary serialized objects and runtime links require separate review. Highest-frequency unresolved GUIDs: `2d94245116ccc3d4ebc1d22a0dcdad50` (1 files), `9e98653779b302f4b8541b444993a920` (1 files), `adb84e30e02715445aeb9959894e3b4d` (1 files), `48a79b01ea5641d4aa6daa2e23605641` (1 files), `8e6292b2c06870d4495f009f912b9600` (1 files).
- 14 **Retro Police Station Environment / Exterior + Interior**. Run the one-package Unity smoke test, inspect dependencies and retain a separate copy if there are conflicts.
- 15 **Compass Navigator Pro 4**. Run the one-package Unity smoke test, inspect dependencies and retain a separate copy if there are conflicts.
- 16 **Heat - Complete Modern UI**. Run the one-package Unity smoke test, inspect dependencies and retain a separate copy if there are conflicts.
- 17 **Advanced Helicopter Controller**. Run the one-package Unity smoke test, inspect dependencies and retain a separate copy if there are conflicts.
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
- 46 **Procedural Cracks**. Complete the authenticated Package Manager download or restore the owned archive.
- 47 **Urban Abandoned District**. Complete the authenticated Package Manager download or restore the owned archive.
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
- 63 **French Quarter Street Environment**. Complete the authenticated Package Manager download or restore the owned archive.
- 64 **GamePad and Keyboard Input Sprites for TextMesh Pro**. Run the one-package Unity smoke test, inspect dependencies and retain a separate copy if there are conflicts.
- 65 **Mall Environment**. Run the one-package Unity smoke test, inspect dependencies and retain a separate copy if there are conflicts.
- 66 **Midnight Downtown**. Validate the archive header and unpack using its shipped vendor paths.
- 67 **Modern Guns: Handgun**. Complete the authenticated Package Manager download or restore the owned archive.
- 68 **Modern Weapons Pack**. Complete the authenticated Package Manager download or restore the owned archive.
- 69 **Outlaw Loops - Modern Western Music**. Complete the authenticated Package Manager download or restore the owned archive.
- 70 **Screen Damage**. Complete the authenticated Package Manager download or restore the owned archive.
- 71 **Trailer with Chassis Pack**. Complete the authenticated Package Manager download or restore the owned archive.
