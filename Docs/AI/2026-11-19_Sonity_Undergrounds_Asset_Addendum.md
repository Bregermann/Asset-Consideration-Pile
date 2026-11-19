# CODEX / CLAUDE CONTINUATION — SONITY + UNDERGROUNDS BUNDLE

**Date:** 2026-11-19  
**Owner:** Goose Knuckle Games / Luna Wolf Studios  
**Primary asset-depot repository:** `https://github.com/Bregermann/Asset-Consideration-Pile`  
**Prior directive:** `Docs/AI/MovingViolation_SA_Asset_Intake_Directive.md`  
**Primary production game:** `Moving Violation` (Unity 6 URP, Windows x64)  
**Related projects to evaluate, not blindly modify:** Interstate: Hauler, Truck Taxi, Truck Sports: Party!, Cartastrophe, Rest Stop Racket, Rowan of Bramblebrook, Dead Air / horror prototypes, Lifeline, other accessible relevant games.

## ACTUAL EXECUTION REQUIRED

This directive **adds** to, rather than replaces, the previous S/A asset-intake work. Do the work; do not stop after producing a design document. Process the seven newly owned Undergrounds / Mega Bundle 7 in 1 components as **user-confirmed owned via the bundle**. Record the parent entitlement Asset Store ID **320220**, publisher **AW Abandoned World**, and each child listing ID; don't claim the seven were independently purchased. **Sonity is mandatory to prioritize and integrate**, but first establish which Sonity package/version and paid-license entitlement are locally accessible. The seven items were explicitly confirmed owned; paid Sonity entitlement was not independently verified by this directive. Use the full paid Sonity package for shipped builds; the free trial has build limitations. If no paid Sonity license/package is accessible, complete non-licensable preparation, report the blocker precisely, and do not claim that Sonity is shipping in the Windows build.

### Authoritative tier and evaluation decisions

| Priority | Asset — Unity Asset Store ID | Size shown on listing | Practical use | Projects | Ownership / overlap |
|---|---|---:|---|---|---|
| **S — mandatory** | **Sonity — Audio Middleware**, Sonigon, **229857** | **55.7 MB** | Canonical gameplay audio events, spatial ambience, dynamic sound parameters, music, indoor/outdoor transitions; live audio debug | Moving Violation **must integrate**; recommend staged adapters for Interstate, Truck Taxi, Truck Sports, Rowan, and horror | **Paid entitlement/package to verify** before installation. Integrate against exact available Sonity version, preserve existing games' audio |
| **A** | **Modular Subway Tunnels**, AW Abandoned World, **317175** | **1.3 GB** | Abandoned subway, service corridors, underground network, maintenance rooms, technical train | Moving Violation, horror/Dead Air; niche Interstate/Truck Taxi metro roads | Owned via 320220. Strong scene/environment, not a fully simulated train system |
| **A** | **Modular Abandoned Shelter**, AW Abandoned World, **311075** | **2.4 GB** | Doomsday hideout, abandoned shelter, interiors, prepper base, survival/horror missions | Moving Violation, horror/Dead Air, Interstate / Rest Stop Racket | Owned via 320220; much of props pack and off-road car art overlap |
| **A** | **Modular Mini Bunker**, AW Abandoned World, **317481** | **2.6 GB** | Secret bunker, guarded hideout, underground quest hub, horror safehouse, mission space | Moving Violation, horror/Dead Air, niche Interstate | Owned via 320220; multiple substantial meshes/prefabs; isolate first |
| **A — conditional fit** | **CyberPunk Underpass**, AW Abandoned World, **318615** | **2.5 GB** | Run-down underpass, graffiti/street-racing area, underground club/makeshift market; regrade lighting and remove overtly futuristic dressing to fit contemporary US setting | Moving Violation, horror; Interstate only if visually adjusted | Owned via 320220. Large package; don't drop whole scene into production |
| **A** | **Off-Road Vehicle**, AW Abandoned World, **304609** | **157.2 MB** | Old off-road utility/military-style 4x4, stolen vehicle, mud/snow rally, recovery/tow target | Moving Violation, Interstate, Truck Taxi, Truck Sports, Cartastrophe | Owned via 320220; **art model only**, no movement setup or bones, separated wheels; adapt to existing NWH VP2 instead of replacing physics |
| **B — selective** | **Industrial Underground Props Pack**, AW Abandoned World, **143712** | **1.6 GB** | Control panels, generators, clutter, boxes, work lights, tools, abandoned utilities | All realistic contemporary/industrial games, strongest MV/horror/Interstate | Owned via 320220; publisher states **almost entirely included** in Modular Abandoned Shelter. Deduplicate shared meshes/materials/GUIDs |
| **B — selective** | **Modular Pipes & Vent Pack**, AW Abandoned World, **175045** | **361.9 MB** | Pipes, ducts, hidden maintenance passage dressing, service corridors | MV, Interstate, horror, Rest Stop Racket; low Rowan fit | Owned via 320220; also included in other bundle scenes. Avoid duplicate import |

**Parent bundle:** `Undergrounds / Mega Bundle 7 in 1`, Unity Asset ID `320220`, 4 modular underground environments plus 3 prop sets. Its store wrapper is 53.8 KB; that does **not** mean the actual constituent content is lightweight. Official description: 1,172 meshes, 1,998 prefabs, 496 PBR materials, 751 textures across combined content. Do not sum sizes or duplicate packages into production; the seven packages overlap.

### Source IDs / official listings

- Sonity: https://assetstore.unity.com/packages/tools/audio/sonity-audio-middleware-229857
- Sonity documentation: https://sonity.gitbook.io/docs
- Parent bundle: https://assetstore.unity.com/packages/3d/environments/industrial/undergrounds-mega-bundle-7-in-1-320220
- Modular Abandoned Shelter: https://assetstore.unity.com/packages/3d/environments/industrial/modular-abandoned-shelter-311075
- Modular Subway Tunnels: https://assetstore.unity.com/packages/3d/environments/industrial/modular-subway-tunnels-317175
- CyberPunk Underpass: https://assetstore.unity.com/packages/3d/environments/urban/cyberpunk-underpass-318615
- Modular Mini Bunker: https://assetstore.unity.com/packages/3d/environments/industrial/modular-mini-bunker-317481
- Industrial Underground Props Pack: https://assetstore.unity.com/packages/3d/props/industrial/industrial-underground-props-pack-143712
- Modular Pipes & Vent Pack: https://assetstore.unity.com/packages/3d/props/industrial/modular-pipes-vent-pack-175045
- Off-Road Vehicle: https://assetstore.unity.com/packages/3d/vehicles/off-road-vehicle-304609

## 1. Sonity — actual high-priority integration

1. Inventory local Unity Asset Store cache, the Asset Consideration Pile, existing game projects, and licensed Sonity package. Verify paid version (Sonity 1.2.0.1 as listed on 2026-11-19 or the installed later compatible version), exact source folder, seat entitlement, and Unity 6 URP build compatibility. Do not introduce trial-only audio as production-ready; free-trial listing says sound does not ship in built players.
2. Build a **single, modular Sonity audio adapter layer** for Moving Violation that listens to gameplay events without replacing source gameplay systems or generating double audio. Prefer a small interface so other projects can opt in later. Treat Sonity as sound-event/mix middleware, **not** an audio-content library or procedural music generator.
3. Define categories: Master, Music, SFX, Dialogue/Voice, UI, Ambience, Vehicles, Weather, and optional Police Radio. Expose controller-navigable audio options with saved volumes. Validate persistence after quit/relaunch.
4. Wire working SoundEvents / SoundParameters to at least: on-foot surface footsteps (wet asphalt, snow, indoor tile, gravel), punch/impact, firearm, police siren/radio, NPC voice bark, vehicle idle/RPM/throttle/speed/engine stop, collision, rainfall/wind/snow ambience, subterranean echoes and muffled cross-room transitions, nightclub music fading from indoor to street, menus/UI, and quest success/failure music. Add spatial distance attenuation and appropriate concurrency limits. Sound should originate from world emitters and be heard in Windows builds, not merely Unity Editor.
5. Coordinate with the shared Weather Maker + Weatherade framework and existing footstep audio/events rather than duplicate precipitation simulation. Weather state drives live sound parameters (rain intensity, wind speed, snowfall muffling). Snow footsteps require the existing snow surface/footprint mechanics from the Moving Violation master prompt.
6. Provide a compact test scene with surface zones, nearby/distant traffic, interior door, corridor, underground room, weather transition and controllable vehicle. Test with controller and Windows IL2CPP build. Output event-to-sound map and listening checklist.
7. For Interstate, Truck Taxi, Truck Sports, Rowan, and horror games: produce a project-specific **optional adoption plan** pointing at existing sound authorities/conflicts. Do not hot-swap working audio controllers or mass-edit other game repos without a separate approved migration.

## 2. Inspect and catalog all seven newly owned components

1. Add parent 320220 and all seven child IDs to local master inventory. Child ownership should read `Confirmed owned via parent Undergrounds bundle 320220 (user statement)`, original seller/publisher `AW Abandoned World`, Unity page URL, current listing size/version, duplicates, Unity/URP test status and exact imported asset paths.
2. Before downloading, find actual Unity Asset Store account downloads/cache and any existing local copies. Fetch missing legitimate owned files through normal authenticated Unity tools. Keep original archives locally; do not add `.unitypackage` files to Git.
3. Import each item into an **isolated Unity 6 URP review project or disposable test copy** first. Test materials/shader graphs, navmesh/colliders, modular snap alignment, doors/entries, LODs/occlusion, lighting, NPC movement, Addressables/streaming, snow/wetness shader compatibility, controller navigation and memory impact. Verify no GUID collisions and no duplicate vendor assemblies.
4. De-duplicate common assets. Publisher states the Industrial Underground Props Pack is almost entirely within the Modular Abandoned Shelter and some elements appear in Subway Tunnels. Pipes & Vent is also included in other environments. The off-road vehicle art appears in the Abandoned Shelter. Avoid shipping multiple copies of the same models, 4K textures, materials or prefab GUIDs.
5. **Moving Violation**: evaluate one connected underground maintenance area beneath the dense slice district; one believable bunker/hideout; a grungy underpass for racing/escape. Reuse selected small prefabs and sensible LODs, not all full demo scenes. The off-road vehicle gets NWH vehicle physics and robust gamepad handling if selected.
6. **Interstate: Hauler / Truck Taxi**: use a bunker/old highway maintenance depot as a secret location, a plow or salvage side job, off-road recovery driving, and industrial underpasses if matching the actual route geography. Do not transplant Soviet signage wholesale into contemporary US environments; retexture/rebrand where necessary.
7. **Truck Sports: Party!**: assess only the off-road vehicle and a few underpass industrial props for potential race/obstacle arena. Reject full 2.5 GB environment imports to a small local multiplayer sports build.
8. **Cartastrophe / Rest Stop Racket**: consider pallet scavenging, underground storage/power rooms, an industrial contraband depot, utility repair, and a beat-up off-road delivery vehicle; do not assert these game projects already exist.
9. **Rowan of Bramblebrook**: generally mark modern industrial/Soviet/cyberpunk art **poor fit**. Do not import the bundles into the fantasy game merely because they're owned. Sonity may be excellent as an optional sound middleware upgrade after regression testing.
10. **Dead Air / horror / Lifeline**: prioritize modular subway, bunker, shelter and props as high-value thriller/horror spaces. Consider flashlight exploration, salvage, abandoned utilities, claustrophobic pursuit, and weathered shelter stories.
11. Record `RECOMMENDED FOR PRODUCTION`, `DEPOT ONLY`, `DEDUPLICATED INTO ANOTHER PACK`, or `NOT SUITABLE` per project, with justification, screenshot and real test evidence.

## 3. New activity candidates worth prototyping

- **Underground courier:** use subway maintenance corridors for risky package deliveries, timed escape and alternate exits.
- **The Bunker Job:** discover a sealed bunker and obtain loot/records through exploration, dialogue, keys and environmental puzzles.
- **Storm Shelter:** severe snowstorm sends NPCs to a municipal shelter; interact with staffing, stranded motorists, supply deliveries and evolving crowd routines.
- **Underpass Midnight:** unsanctioned street races and stunt challenges under the elevated roadway.
- **Salvage Shift:** forklift and tow/truck missions retrieving generator parts, abandoned vehicles and scrap.
- **Snowbound Recovery:** launch a utility 4x4 to rescue or repossess vehicles on icy dirt roads; use NWH tire surfaces and visible tracks.
- **Tunnel Tagging:** graffiti/tagging contests and changing neighborhood/faction recognition, without mandatory quests.
- **Dead Signal:** investigate a closed service tunnel with flickering lighting, radio interference, weather seepage and Sonity acoustic effects.
- **Blackout City:** damaged underground electrical room cascades into localized power outages, shop closures and new stealth opportunities.
- **Prepper Compound:** bunker owner/faction trades supplies, jobs and secrets, with persistent world state.

These are **candidates**, not automatically assigned as all-required first-slice scope. Prioritize one finished playable underground activity and one weather-related driving challenge only after the base game is functional.

## 4. Git + repo workflow — preserve prior rules

- The user explicitly keeps `Bregermann/Asset-Consideration-Pile` public. **Do not change repository visibility** or use publicity as a blocker to local asset intake.
- Follow existing repo `.gitignore` and `.gitattributes`, **no Git LFS**, preserve tracked/ignored files. The prior directive excludes single files **>=50 MiB** and `.unitypackage` archives; update manifests for excluded local files. Do not insert broken prefab references into the committed Unity project. **Never use LFS pointers.**
- Stage/commit **by asset**, with no more than **750 MiB staged** in a single commit and actual push payload **strictly below 1 GiB**. Smaller chunks are preferred. Verify each remote commit SHA and halt/repartition a push if nearing the limit. Do not force push.
- Preserve all local licensed files even if they cannot be committed under configured Git/asset-redistribution rules. Record original cache paths, hashes, import recipes, missing dependencies, and status; do not claim remote presence where only local presence exists.
- Make sure the production Moving Violation game only references assets available when another agent clones/builds that project. Keep the asset depot separate from production and package selection curated.
- Each asset should be recorded in `Docs/AI/Sonity_Undergrounds_Intake_Manifest.csv` with source, parent bundle, size, owner, exact importer outcome, deduplication, tests, project fit, and commit SHA. Maintain `Docs/AI/Sonity_Undergrounds_Validation_Report.md` with measured build results.
- The prior 71 S/A list remains intact. This addendum proposes **Sonity as one new S**, **five new A** (Subway, Abandoned Shelter, Mini Bunker, CyberPunk Underpass conditional, Off-Road Vehicle), and **two B** (Industrial Props, Pipes/Vent). Do **not** blindly change master tier counts until the agent reconciles duplicates with actual master inventory.

## 5. Acceptance criteria

- All eight requested asset names plus parent bundle appear with verified source IDs and statuses in the updated asset index.
- Sonity is **actually integrated** and audible in a Windows x64 Moving Violation build with adjustable/saved volumes and working runtime weather/vehicle/interior examples, or the report explicitly states what paid entitlement or Unity build blocker prevents honest completion.
- Every component has a grounded project-by-project assessment and an ownership/download/import status.
- At least one underground area can be entered/exited in the Moving Violation test branch without broken camera/navmesh; improve production only after the initial tests pass.
- The Off-Road Vehicle is identified as art-only; if selected as drivable, it uses the game's existing chosen vehicle physics controller and gamepad controls.
- No duplicate assets are imported unnecessarily, no damage to existing games, no broken GUID references, no LFS pointers, and every Git push is under 1 GiB.
- End with build path, tests run, actual files/commits, package handling results, project-by-project adoption advice, and a precise list of any blockers.

**Start by auditing the repo and local packages; then implement Sonity and test the bundle in isolation. Do not stop after drafting a plan.**