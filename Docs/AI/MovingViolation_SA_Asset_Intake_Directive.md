# CODEX EXECUTION DIRECTIVE — Goose Knuckle Games / Moving Violation S+A Asset Intake

**Target repository:** `https://github.com/Bregermann/Asset-Consideration-Pile`  
**Target:** the **existing Unity Asset Consideration Pile project**, *not* the production `Moving Violation` project.  
**Purpose:** retrieve, inventory, inspect, import/test, and Git-commit the full 71-package S/A shortlist below, without disrupting the existing Unity project or inadvertently importing everything into the future game.  
**Execution mode:** work autonomously, batch by package, validate, checkpoint, continue. Do not stop after writing a plan.  
**Do not change repository visibility.** The repository is intentionally public.

## Hard requirements

1. **Inventory first.** Locate the actual local clone and current `Assets/`, `Packages/`, `ProjectSettings/`; use `git status`, confirm `origin`, current branch, Unity Editor version, and test a clean baseline. Record existing asset GUIDs, package IDs and paths. Do not assume a drive path. Back up/branch any uncommitted user work instead of discarding it.
2. **Use only legitimately accessible owned downloads.** Inspect Unity's existing Asset Store cache, local `.unitypackage` archives, Unity Package Manager caches and existing Unity project copies before downloading anything. For missing packages, use the user's normal authenticated Unity access. Never fabricate IDs, scrape credentials, bypass licensing, or claim a download succeeded without actual bytes.
3. **No bulk-import chaos.** Import and validate one package at a time. Create Unity test copies when tools conflict, so the central Pile stays compile-clean. Preserve `.meta` GUID relationships, original vendor paths when required, asmdefs, dependencies, and package metadata. Do not blindly reparent files or import vendor demo projects into startup scenes.
4. **Exactly the full 71 priority assets.** Work through the ordered S/A checklist below. Each row must become one of `ALREADY_PRESENT_VALIDATED`, `IMPORTED_AND_PUSHED`, `PARTIAL_PUSH_SIZE_LIMIT`, `LOCAL_ONLY_LICENSE`, `LOCAL_ONLY_GIT_LIMIT`, `NOT_AVAILABLE_IN_ACCOUNT`, `INCOMPATIBLE_ISOLATED`, or `FAILED_RETRY_NEEDED`, with evidence. Do not silently skip anything.
5. **No Git LFS.** Do not run `git lfs track`, commit LFS pointer files, or modify `.gitattributes` to introduce LFS. Respect the repository's current Unity `.gitignore`/`.gitattributes`. Asset Store `.unitypackage` downloads, archive backups, generated imports and binary release/build artifacts must stay out of Git. Do not use `git add -f` to override relevant ignore rules. Files of **50 MiB or more** are excluded proactively (GitHub hard-rejects a blob at 100 MiB; 50 MiB is our operational ceiling). Exclude the `.meta` for any excluded source file, and record references at risk of breaking.
6. **Public distribution constraint.** A package being owned does not automatically grant redistribution rights in a public repository. For each third-party asset, check redistribution rights. Commit actual third-party binaries to this public repo **only if that license allows public redistribution**. Otherwise keep the imported asset in the local Pile and commit only non-proprietary manifests, source links, local restore instructions, inventories and integration code. Never publish restricted package source files to GitHub. This is not a request to change the repo to private or to abandon local import.
7. **Commit by asset; push in chunks <= 1 GiB.** At most one selected asset/package per commit except necessary project-level config changes. If an eligible package exceeds the limit, use separately labeled package-specific `part-01`, `part-02`, etc. commits. **Commit and push immediately after each asset or part** so unpublished commits cannot accumulate. Cap staged eligible content at **750 MiB** per commit/push, and verify actual outbound new Git object data remains **strictly below 1 GiB** before each push. If near limit, split smaller. Zero force-pushes, rebases that discard work, giant `git add .`, or unrelated-file commits.
8. **Keep project lean despite an asset warehouse.** Maintain a manifest/search index covering package ID, exact owner/publisher, version, file paths, actual prefabs/models/animations/rigs/systems, Unity 6/URP compatibility, dependency closure, licensing status, status and commit SHA. Use scoped folders/mapping without breaking vendor GUIDs. Keep demos/test scenes away from startup content. Mark incompatible frameworks as reference/test-only.
9. **Preserve the existing weather stack.** Integrate or catalog Weather Maker and Weatherade as the central weather foundation; inspect reusable weather state/coordinators from `Bregermann/Interstate-Hauler-Trucking-Simulator`, including `Assets/LWS/InterstateHauler/Weather/LwsWeather.cs`, `LwsWeatherMakerAdapter.cs`, and `LwsWeatherPresetDefinition.cs`. Do not overwrite the other game's working weather components. Track remaining needs for snow accumulation, bootprints, tire tracks, wetness, wind, fog, plowing, traction, and persistent weather transitions. Reuse existing approved code only with appropriate project/license permissions.
10. **No game architecture takeover.** JU TPS 3, Mobile Pedestrian System, NWH, Urban Traffic, multiple helicopter controllers, and multiple destruction solutions must be tested as separate candidates with adapters; do not make each package the runtime authority. Prefer NWH for vehicle physics, the verified existing weather coordinator for clock/weather, and a single chosen player controller once evaluated. Do not automatically replace working systems.
11. **Safety checks before each commit:** Unity project load/compile or isolated smoke test, GUID collision scan, duplicate asset/script scan, missing dependencies scan, `git status --short`, staged file-size audit, `git check-attr filter` (ensure no LFS), `git diff --cached --stat`, push, then verify remote commit SHA. Verify any quoted vendor metadata/inventory matches actual files.
12. **Progress reports.** After each 5 assets, report done, skipped and why, local disk footprint, tracked Git footprint, push SHA(s), missing dependencies and any blocked package. Continue without waiting unless authentication, storage, a licensing issue, or destructive merge needs explicit owner action. Produce one final `Docs/AI/MovingViolation_AssetIntake_Report.md` and `Docs/AI/MovingViolation_AssetIntake_Manifest.csv` tracking all 71 assets. The manifest may commit regardless of whether binaries are publishable.

## Ordered 71-package manifest (11 S + 60 A)

Do not substitute similarly titled products. Match using the exact title **and publisher**; use recorded Asset IDs where available. `No recorded ID` is not proof the asset is unavailable.
01. **[S] NWH Vehicle Physics 2** — NWH Coding — Unity Asset ID 166252 — Vehicles / Driving
02. **[S] EasyRoads3D Pro v3** — AndaSoft — Unity Asset ID 469 — Roads / Navigation
03. **[S] JU TPS 3 - Third Person Shooter GameKit + Vehicle Physics** — JU GameDev — Unity Asset ID 251334 — Player / Combat
04. **[S] Urban Traffic System Full Pack** — AGLOBEX — Unity Asset ID 166688 — Traffic / Pursuits
05. **[S] Dialogue System for Unity** — Pixel Crushers — Unity Asset ID 11672 — Quests / Dialogue
06. **[S] Mobile Pedestrian System** — Gley — Unity Asset ID 203706 — NPC AI / Factions
07. **[S] Miami Vice City** — Leartes Studios — Unity Asset ID 357022 — Urban Exteriors
08. **[S] Sundown:Shop/Store (Modular Shop, Supermarket, Convenience Store)** — Hivemind — Unity Asset ID 338930 — Interiors / Businesses
09. **[S] Love/Hate** — Pixel Crushers — Unity Asset ID 33063 — NPC AI / Factions
10. **[S] Human Basic Motions** — Kevin Iglesias — Unity Asset ID 157744 — Animation / Ragdolls
11. **[S] Scene Streamer** — Pixel Crushers — Unity Asset ID 38168 — World Streaming / Optimization
12. **[A] City / Street Environments Bundle (8 Packs)** — Leartes Studios — Unity Asset ID 363798 — Urban Exteriors
13. **[A] Modern restaurant - building and interior** — Mixall — Unity Asset ID 210254 — Interiors / Businesses
14. **[A] Retro Police Station Environment / Exterior + Interior** — Leartes Studios — Unity Asset ID 303629 — Police / Wanted / Justice
15. **[A] Compass Navigator Pro 4** — Kronnect — Unity Asset ID 388824 — Roads / Navigation
16. **[A] Heat - Complete Modern UI** — Michsky — Unity Asset ID 264857 — UI / Input
17. **[A] Advanced Helicopter Controller** — alelavoie — Unity Asset ID not recorded—match exact title/publisher to owned account — Aircraft / Drones
18. **[A] Train Controller (Railroad System) ULTIMATE COLLECTION** — WSM Game Studio — Unity Asset ID 138534 — Trains / Freight
19. **[A] Weather Maker - Volumetric Clouds and Weather System for Unity** — Digital Ruby (Jeff Johnson) — Unity Asset ID 60955 — Weather / Terrain
20. **[A] Cinemachine** — Unity Technologies — Unity Asset ID 79898 — Cinematics / Cameras
21. **[A] Controllable Forklift Free** — IKupreev — Unity Asset ID 80275 — Jobs / Delivery / Logistics
22. **[A] Instant Destruction - Easy GPU Fracture** — Rebush — Unity Asset ID not recorded—match exact title/publisher to owned account — Damage / Destruction
23. **[A] Super Level Optimizer 2** — New Game Studio — Unity Asset ID 319098 — World Streaming / Optimization
24. **[A] Weatherade: Snow and Rain System** — NOT_Lonely — Unity Asset ID 275622 — Weather / Terrain
25. **[A] Mesh Demolisher** — Hanzzz — Unity Asset ID not recorded—match exact title/publisher to owned account — Damage / Destruction
26. **[A] Police Car & Helicopter** — SICS Games — Unity Asset ID 52496 — Police / Wanted / Justice
27. **[A] Core-Collapse** — Juan Rodriguez — Unity Asset ID not recorded—match exact title/publisher to owned account — Damage / Destruction
28. **[A] Customizable 3D Characters Complete Bundle** — Artlix Studios — Unity Asset ID 295594 — NPC / Characters
29. **[A] FlexibleGlassDestructor** — Rebush — Unity Asset ID not recorded—match exact title/publisher to owned account — Damage / Destruction
30. **[A] Industrial Props Equipment Mega Bundle** — EVOLVE Studio LTD — Unity Asset ID 369388 — Interiors / Businesses
31. **[A] POLYGON - Nightclubs Pack - Art by Synty** — Synty Studios — Unity Asset ID 216721 — Interiors / Businesses
32. **[A] Vista Personal - Procedural Terrain Generator with Biomes** — Pinwheel Studio — Unity Asset ID 297327 — Weather / Terrain
33. **[A] EmbersStorm - Free Piper M350 Plane** — EmbersStorm — Unity Asset ID not recorded—match exact title/publisher to owned account — Aircraft / Drones
34. **[A] Road Props Collection** — EVOLVE Studio LTD — Unity Asset ID 292001 — Urban Exteriors
35. **[A] Scriptable Sheets** — Luna Wolf Studios LLC — Unity Asset ID 284559 — Persistence / World State
36. **[A] Yue Destructible Objects Package Glass** — Yuetility-Studios — Unity Asset ID not recorded—match exact title/publisher to owned account — Damage / Destruction
37. **[A] Garage Warehouse Environment ( Garage Warehouse , Modular Garage , Garage )** — Leartes Studios — Unity Asset ID 261110 — Interiors / Businesses
38. **[A] Human Melee Animations** — Kevin Iglesias — Unity Asset ID 151650 — Animation / Ragdolls
39. **[A] MC Greet & Talk - Believable 3D Animations by MoCap Central** — Mocap Central — Unity Asset ID 288923 — Animation / Ragdolls
40. **[A] UI Navigation Wizard - Gamepad / Keyboard Navigation & Selection** — KAMGAM — Unity Asset ID 284552 — UI / Input
41. **[A] Modular Burger Shop Environment** — SQUID — Unity Asset ID 329847 — Interiors / Businesses
42. **[A] Modular Warehouse (Warehouse, Industrial Warehouse, Hangar, Factory, Warehouse)** — Hivemind — Unity Asset ID 341146 — Interiors / Businesses
43. **[A] Omni Animation - Core Locomotion Pack** — Opsive — Unity Asset ID 286945 — Animation / Ragdolls
44. **[A] Prefab World Builder** — Plugin Master — Unity Asset ID 185406 — Editor / QA
45. **[A] Ultimate Sound FX Bundle** — Sidearm Studios — Unity Asset ID 151756 — Audio / Radio
46. **[A] Procedural Cracks** — Triple Axis — Unity Asset ID not recorded—match exact title/publisher to owned account — Damage / Destruction
47. **[A] Urban Abandoned District** — ScansFactory — Unity Asset ID 256451 — Side-story / Horror
48. **[A] Character Customizer** — Jordbugg — Unity Asset ID 241861 — NPC / Characters
49. **[A] Complete Off-Road Racing (PC / Console) for URP** — ALIyerEdon — Unity Asset ID 344358 — Racing / Vehicle Sports
50. **[A] Military Cargo Aircraft** — AC Game Assets — Unity Asset ID not recorded—match exact title/publisher to owned account — Aircraft / Drones
51. **[A] Oceanis 2026 Pro URP Water Framework** — ARTnGAME — Unity Asset ID 289926 — Boats / Water
52. **[A] Abandoned Factory (Factory, Warehouse, Industrial Factory, Industrial Warehouse)** — Hivemind — Unity Asset ID 268120 — Interiors / Businesses
53. **[A] Advanced Foliage Pack 2.0** — NatureManufacture — Unity Asset ID 103151 — Wildlife / Rural
54. **[A] Motion Warping: Climb & Interact** — KINEMATION — Unity Asset ID 270046 — Animation / Ragdolls
55. **[A] Procedural City Generator** — Ugur Yucel — Unity Asset ID 330140 — Urban Exteriors
56. **[A] Rigged Construction Truck Vehicle** — EVOLVE Studio LTD — Unity Asset ID 364538 — Vehicles / Driving
57. **[A] Transport Helicopter** — Duane's Mind — Unity Asset ID not recorded—match exact title/publisher to owned account — Aircraft / Drones
58. **[A] Game Action System - Gameplay Interaction Framework** — Ilumisoft — Unity Asset ID 248290 — Persistence / World State
59. **[A] Industrial Shipping Container Pack** — EVOLVE Studio LTD — Unity Asset ID 291948 — Trains / Freight
60. **[A] Base Helicopter Controller** — SunCube — Unity Asset ID 40107 — Aircraft / Drones
61. **[A] Easy Drone Controller** — RageRun Games — Unity Asset ID 272037 — Aircraft / Drones
62. **[A] Free Fire VFX - URP** — Vefects — Unity Asset ID 266226 — VFX / Lighting
63. **[A] French Quarter Street Environment** — Leartes Studios — Unity Asset ID 303625 — Urban Exteriors
64. **[A] GamePad and Keyboard Input Sprites for TextMesh Pro** — Alan Robinson — Unity Asset ID 310114 — UI / Input
65. **[A] Mall Environment** — Nimikko — Unity Asset ID 261944 — Interiors / Businesses
66. **[A] Midnight Downtown** — Neo Star — Unity Asset ID 315347 — Urban Exteriors
67. **[A] Modern Guns: Handgun** — Nokobot — Unity Asset ID 129821 — Weapons / Equipment
68. **[A] Modern Weapons Pack** — 7XF Design — Unity Asset ID 14233 — Weapons / Equipment
69. **[A] Outlaw Loops - Modern Western Music** — Josh Lim — Unity Asset ID 309577 — Audio / Radio
70. **[A] Screen Damage** — Pathiral — Unity Asset ID not recorded—match exact title/publisher to owned account — VFX / Lighting
71. **[A] Trailer with Chassis Pack** — EVOLVE Studio LTD — Unity Asset ID 291296 — Vehicles / Driving
## File-size and Git execution algorithm

For each package, before staging: (a) calculate its actual imported file inventory; (b) keep ignored archives, caches, backups, build outputs, `.unitypackage`, and other excluded formats out of Git; (c) exclude any file >=50 MiB and its companion `.meta` and note any prefab/scene dependencies; (d) exclude files whose license forbids public distribution; (e) stage **only** the current asset-scoped, eligible paths plus manifest/config changes; (f) stop accumulating at 750 MiB of new eligible data; (g) commit with `assets(<ID-or-name>): import <vendor package> [part X/Y]`; (h) inspect outbound pack/data; (i) `git push origin <current-branch>` and record SHA immediately; (j) verify clean expected state; (k) go to the next part or next asset. Do not create Git LFS pointers or use a remote other than the verified `origin`.

For files excluded by the Git or license rules, retain local copies only and create an explicit `LocalOnlyRestore` inventory (package source, exact version, Unity account retrieval path, file path, reason, missing-dependency impact). Do not mark a package completely integrated into a Git clone if tracked dependencies are missing. Build a reproducible local rehydration workflow for the actual licensed owner. Do not copy third-party proprietary source to a publicly reachable alternate host as a workaround.

## Asset pile folder conventions

- Existing Unity project remains the authority: `Assets/`, `Packages/`, and `ProjectSettings/` are preserved.
- Non-proprietary metadata goes under `Docs/AI/MovingViolation/` for master manifest, package reports, source citations, ownership/compatibility metadata, thumbnails only when redistributable, and side-activity recommendations.
- Add test or adapter code under a clearly named workspace that will not collide with vendor namespaces.
- Use vendor folder paths as originally shipped when a package depends on them; create logical catalog tags instead of moving those files unsafely.
- Do **not** add bulk assets to the eventual `Moving Violation` production Unity project. That project receives only explicitly approved, dependency-complete packages after isolated tests.

## Completion criteria

- Every listed asset has a definitive recorded disposition, download/import evidence where available, license status, total imported bytes, tracked Git bytes, excluded bytes, Unity/editor compatibility notes, and any required dependency actions.
- Every legally redistributable Git-eligible asset file is committed in asset-specific, sub-1-GiB verified pushes with no LFS; no package is silently omitted.
- The local Asset Consideration Pile contains the licensed, available S/A packages, subject to compatibility and capacity. Project retains previous functionality.
- An activity mapping identifies how each candidate supports Moving Violation (crime sandbox, law response, NPCs, economy, vehicles, aircraft, snow/weather, destruction, interiors, audio, UI, heists, jobs, minigames).
- Final report includes pushed commit SHAs, skipped/unavailable assets, outstanding compatibility issues, and exactly which local content another developer must rehydrate after cloning.

**Start executing. Do not stop at proposal stage.**