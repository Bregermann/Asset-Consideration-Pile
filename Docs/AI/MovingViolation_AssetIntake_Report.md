# Moving Violation S/A asset intake

Intake status on 2026-11-19. The manifest has the requested 11 S and 60 A rows in priority order. This report records the last verified state of each package.

- Archive evidence for 38 of 71 packages, with 28,015,825,463 bytes in inventoried payloads before Unity sidecars.
- 2 packages recorded as active in the Pile, totaling 761,587,218 payload bytes.
- 4 confirmed asset checkpoints. They contain metadata only. Tracked vendor payload from this intake is 0 bytes.
- 15 inventoried files at or above 50 MiB. See [Local-only size exclusions](MovingViolation/LocalOnlyRestore.csv) for paths and sidecars.
- Isolated Unity 6000.3.6f1 URP baseline: exit code 0, refresh completed True, compiler errors 0. The live Pile had an existing Infinity PBR demo prefab error before this intake.

| Disposition | Packages |
| --- | ---: |
| `FAILED_RETRY_NEEDED` | 68 |
| `INCOMPATIBLE_ISOLATED` | 1 |
| `LOCAL_ONLY_LICENSE` | 2 |

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
| 01 | NWH Vehicle Physics 2 | [ab0cf76](https://github.com/Bregermann/Asset-Consideration-Pile/commit/ab0cf762d2b845f7a9eb66a49cf5cf64c5381c59) | 1,933 B |
| 02 | EasyRoads3D Pro v3 | [597aa23](https://github.com/Bregermann/Asset-Consideration-Pile/commit/597aa232cbc9928048db92d787f53dbcba1f502c) | 2,011 B |
| 04 | Urban Traffic System Full Pack | [4e1bb2d](https://github.com/Bregermann/Asset-Consideration-Pile/commit/4e1bb2d1ab1db535d2218d091015c570f16d880c) | 2,338 B |
| 05 | Dialogue System for Unity | [d76a62d](https://github.com/Bregermann/Asset-Consideration-Pile/commit/d76a62dcd161ae76353c04a686e941a741f45985) | 1,988 B |

## Outstanding work

- 03 **JU TPS 3 - Third Person Shooter GameKit + Vehicle Physics**. Run the one-package Unity smoke test, inspect dependencies and retain a separate copy if there are conflicts.
- 05 **Dialogue System for Unity**. Static preflight found 0 duplicate GUIDs within the archive, 0 duplicate C# file hashes and 0 source files without a shipped sidecar. Scanned text Unity assets refer to 8 GUIDs outside this package and the indexed project/registry packages. Built-in engine resources, binary serialized objects and runtime links require separate review. Highest-frequency unresolved GUIDs: `f5f67c52d1564df4a8936ccd202a3bd8` (23 files), `f70555f144d8491a825f0804e09c671c` (12 files), `29245abd9e583b5409a4aeadfdf5e11f` (1 files), `1fd0b032134ab05499b23cce5db54723` (1 files), `a16ee5c1720f2e8448354b194324b6e0` (1 files).
- 06 **Mobile Pedestrian System**. Run the one-package Unity smoke test, inspect dependencies and retain a separate copy if there are conflicts.
- 07 **Miami Vice City**. Complete the authenticated Package Manager download or restore the owned archive.
- 08 **Sundown:Shop/Store (Modular Shop, Supermarket, Convenience Store)**. Run the one-package Unity smoke test, inspect dependencies and retain a separate copy if there are conflicts.
- 09 **Love/Hate**. Run the one-package Unity smoke test, inspect dependencies and retain a separate copy if there are conflicts.
- 10 **Human Basic Motions**. Run the one-package Unity smoke test, inspect dependencies and retain a separate copy if there are conflicts.
- 11 **Scene Streamer**. Run the one-package Unity smoke test, inspect dependencies and retain a separate copy if there are conflicts.
- 12 **City / Street Environments Bundle (8 Packs)**. Run the one-package Unity smoke test, inspect dependencies and retain a separate copy if there are conflicts.
- 13 **Modern restaurant - building and interior**. Run the one-package Unity smoke test, inspect dependencies and retain a separate copy if there are conflicts.
- 14 **Retro Police Station Environment / Exterior + Interior**. Complete the authenticated Package Manager download or restore the owned archive.
- 15 **Compass Navigator Pro 4**. Run the one-package Unity smoke test, inspect dependencies and retain a separate copy if there are conflicts.
- 16 **Heat - Complete Modern UI**. Run the one-package Unity smoke test, inspect dependencies and retain a separate copy if there are conflicts.
- 17 **Advanced Helicopter Controller**. Run the one-package Unity smoke test, inspect dependencies and retain a separate copy if there are conflicts.
- 18 **Train Controller (Railroad System) ULTIMATE COLLECTION**. Validate the archive header and unpack using its shipped vendor paths.
- 19 **Weather Maker - Volumetric Clouds and Weather System for Unity**. Run the one-package Unity smoke test, inspect dependencies and retain a separate copy if there are conflicts.
- 20 **Cinemachine**. Validate the archive header and unpack using its shipped vendor paths. Unity also publishes the supported com.unity.cinemachine UPM package. Treat registry and legacy Asset Store releases separately.
- 21 **Controllable Forklift Free**. Run the one-package Unity smoke test, inspect dependencies and retain a separate copy if there are conflicts.
- 22 **Instant Destruction - Easy GPU Fracture**. Validate the archive header and unpack using its shipped vendor paths.
- 23 **Super Level Optimizer 2**. Complete the authenticated Package Manager download or restore the owned archive.
- 24 **Weatherade: Snow and Rain System**. Run the one-package Unity smoke test, inspect dependencies and retain a separate copy if there are conflicts.
- 25 **Mesh Demolisher**. Validate the archive header and unpack using its shipped vendor paths.
- 26 **Police Car & Helicopter**. Complete the authenticated Package Manager download or restore the owned archive.
- 27 **Core-Collapse**. Run the one-package Unity smoke test, inspect dependencies and retain a separate copy if there are conflicts.
- 28 **Customizable 3D Characters Complete Bundle**. Complete the authenticated Package Manager download or restore the owned archive.
- 29 **FlexibleGlassDestructor**. Complete the authenticated Package Manager download or restore the owned archive.
- 30 **Industrial Props Equipment Mega Bundle**. Complete the authenticated Package Manager download or restore the owned archive.
- 31 **POLYGON - Nightclubs Pack - Art by Synty**. Complete the authenticated Package Manager download or restore the owned archive.
- 32 **Vista Personal - Procedural Terrain Generator with Biomes**. Run the one-package Unity smoke test, inspect dependencies and retain a separate copy if there are conflicts.
- 33 **EmbersStorm - Free Piper M350 Plane**. Validate the archive header and unpack using its shipped vendor paths.
- 34 **Road Props Collection**. Run the one-package Unity smoke test, inspect dependencies and retain a separate copy if there are conflicts.
- 35 **Scriptable Sheets**. Run the one-package Unity smoke test, inspect dependencies and retain a separate copy if there are conflicts.
- 36 **Yue Destructible Objects Package Glass**. Validate the archive header and unpack using its shipped vendor paths.
- 37 **Garage Warehouse Environment ( Garage Warehouse , Modular Garage , Garage )**. Run the one-package Unity smoke test, inspect dependencies and retain a separate copy if there are conflicts.
- 38 **Human Melee Animations**. Complete the authenticated Package Manager download or restore the owned archive.
- 39 **MC Greet & Talk - Believable 3D Animations by MoCap Central**. Run the one-package Unity smoke test, inspect dependencies and retain a separate copy if there are conflicts.
- 40 **UI Navigation Wizard - Gamepad / Keyboard Navigation & Selection**. Complete the authenticated Package Manager download or restore the owned archive.
- 41 **Modular Burger Shop Environment**. Complete the authenticated Package Manager download or restore the owned archive.
- 42 **Modular Warehouse (Warehouse, Industrial Warehouse, Hangar, Factory, Warehouse)**. Run the one-package Unity smoke test, inspect dependencies and retain a separate copy if there are conflicts.
- 43 **Omni Animation - Core Locomotion Pack**. Complete the authenticated Package Manager download or restore the owned archive.
- 44 **Prefab World Builder**. Run the one-package Unity smoke test, inspect dependencies and retain a separate copy if there are conflicts.
- 45 **Ultimate Sound FX Bundle**. Validate representative audio assets in Unity and retain the local-only source scope.
- 46 **Procedural Cracks**. Complete the authenticated Package Manager download or restore the owned archive.
- 47 **Urban Abandoned District**. Complete the authenticated Package Manager download or restore the owned archive.
- 48 **Character Customizer**. Run the one-package Unity smoke test, inspect dependencies and retain a separate copy if there are conflicts.
- 49 **Complete Off-Road Racing (PC / Console) for URP**. Complete the authenticated Package Manager download or restore the owned archive.
- 50 **Military Cargo Aircraft**. Validate the archive header and unpack using its shipped vendor paths.
- 51 **Oceanis 2026 Pro URP Water Framework**. Complete the authenticated Package Manager download or restore the owned archive.
- 52 **Abandoned Factory (Factory, Warehouse, Industrial Factory, Industrial Warehouse)**. Complete the authenticated Package Manager download or restore the owned archive.
- 53 **Advanced Foliage Pack 2.0**. Run the one-package Unity smoke test, inspect dependencies and retain a separate copy if there are conflicts.
- 54 **Motion Warping: Climb & Interact**. Complete the authenticated Package Manager download or restore the owned archive.
- 55 **Procedural City Generator**. Complete the authenticated Package Manager download or restore the owned archive.
- 56 **Rigged Construction Truck Vehicle**. Complete the authenticated Package Manager download or restore the owned archive.
- 57 **Transport Helicopter**. Run the one-package Unity smoke test, inspect dependencies and retain a separate copy if there are conflicts.
- 58 **Game Action System - Gameplay Interaction Framework**. Complete the authenticated Package Manager download or restore the owned archive.
- 59 **Industrial Shipping Container Pack**. Run the one-package Unity smoke test, inspect dependencies and retain a separate copy if there are conflicts.
- 60 **Base Helicopter Controller**. Complete the authenticated Package Manager download or restore the owned archive.
- 61 **Easy Drone Controller**. Complete the authenticated Package Manager download or restore the owned archive.
- 62 **Free Fire VFX - URP**. Complete the authenticated Package Manager download or restore the owned archive.
- 63 **French Quarter Street Environment**. Complete the authenticated Package Manager download or restore the owned archive.
- 64 **GamePad and Keyboard Input Sprites for TextMesh Pro**. Complete the authenticated Package Manager download or restore the owned archive.
- 65 **Mall Environment**. Complete the authenticated Package Manager download or restore the owned archive.
- 66 **Midnight Downtown**. Complete the authenticated Package Manager download or restore the owned archive.
- 67 **Modern Guns: Handgun**. Complete the authenticated Package Manager download or restore the owned archive.
- 68 **Modern Weapons Pack**. Complete the authenticated Package Manager download or restore the owned archive.
- 69 **Outlaw Loops - Modern Western Music**. Complete the authenticated Package Manager download or restore the owned archive.
- 70 **Screen Damage**. Complete the authenticated Package Manager download or restore the owned archive.
- 71 **Trailer with Chassis Pack**. Complete the authenticated Package Manager download or restore the owned archive.
