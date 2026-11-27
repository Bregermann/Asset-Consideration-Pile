# Polyquest Worlds Full Pack Vol. 1

Luna Wolf Studios owns POLYBOX Asset Store product **74631**. Unity Package Manager verified the entitlement and downloaded version **13.0**. The source archive identifies Unity **6000.0.28f1**. The listing advertises Built-in and URP support on that editor, identifies an Extension Asset license and flags one Asset Store dependency. [Unity Asset Store listing](https://assetstore.unity.com/packages/3d/environments/polyquest-worlds-full-pack-vol-1-74631)

## Search the package

- [Asset directory](directory.csv) lists all 1,109 outer package entries, including folders, by name, type, path, GUID and search category.
- [Prefab directory](prefabs.csv) lists 304 prefabs with rendered bounds at the authored transform, material and shader slots, collider types and flags, and the recursive dependency paths Unity resolved. Bounds are Unity units. A blank collider field means Unity found no 3D collider in the prefab hierarchy.
- [Machine-readable manifest](manifest.json) combines archive identity and SHA-256, original paths and GUIDs, search terms, prefab evidence and scene inspection.
- [Scene audit](scenes.csv) covers the 107 included outer scenes. [Vendor captures](Media/Vendor%20Scenes) contains the corresponding 1280×720 Unity renders. The camera uses an enabled vendor camera where available and a geometry-framing camera otherwise. The audit reports material and missing-script evidence per scene.

Verified content includes cliff and mountain forms, canyon and desert scenes and palettes, natural rocks, boulders, stone spans, platform-shaped rocks, ground surfaces, oceans, skyboxes, and fog, flare and light effects. The stock geometry supports building stepping stones, island-like platforms and natural alcoves.

The outer package inventory yielded no clearly named standalone floating island, ancient monument or ruin kit, or dedicated beach/shoreline kit. Build those silhouettes from cliffs and platforms or bring dedicated architecture and coast assets from a separately owned pack. Its ocean presentation assets provide visual water. Swimming and traversal rules belong to the game.

## Canyon Traverse

Open **Assets → LunaWolf → PolyquestShowcase → Polyquest Canyon Traverse** and press Play. Use **WASD** to move, **Space** to jump, hold **right mouse** to orbit, and press **R** to return to the trailhead. Follow the stepping stones to the branch. The left path uses a natural span and cliff ledges. The right path climbs floating rocks. Both reach the summit beacon. A relic is tucked under the overhang near the start.

- [Floating route gameplay](Media/Floating%20Route.mp4) and [landing checks](floating-route-check.txt)
- [Natural bridge gameplay](Media/Natural%20Bridge%20Route.mp4) and [landing checks](bridge-route-check.txt)
- [Hidden alcove gameplay](Media/Hidden%20Alcove%20Route.mp4), [collectible check](alcove-route-check.txt) and [screenshot](Media/Hidden%20Alcove%20Gameplay.jpg)
- [Floating platforms screenshot](Media/Floating%20Platforms%20Gameplay.jpg) and [natural bridge screenshot](Media/Natural%20Bridge%20Gameplay.jpg)

The showcase uses nested vendor prefabs, dedicated URP Lit materials and fitted collision surfaces. The original materials keep their vendor shader assignments. The geometry assemblies can be imported independently of the player controller, relic objects and scene.

## Transfer to Rowan of Bramblebrook

1. Choose an individual source prefab from [prefabs.csv](prefabs.csv) or a module from Assets/LunaWolf/PolyquestShowcase/Modules.
2. Resolve its recursive dependency paths by GUID in the destination. Bring over absent paths with their matching .meta files from a licensed archive. Model prefabs can reference one shared FBX containing several meshes. Treat the entire FBX as the dependency and bring it over once. Keep a single GUID owner whenever a dependency is already installed.
3. Use the URP module materials directly or apply the Rowan PSX collection. Rowan's established shader is **LunaWolf/SeventhDay textured woodland**, under Assets/LunaWolf/Resources/Rendering/SeventhDayRetro.shader. Reuse the installed shader and includes in Rowan, preserving their GUIDs. The Rowan variants use vertex lighting, point sampling, world snapping, screen dithering and subtle affine distortion.
4. Resolve **URP** for the module materials. The playable showcase also uses Unity **Input System** and built-in physics. Unity's packages are resolved through UPM. Project-wide Graphics, Quality, input and lighting settings belong to each destination.

## Strongest pieces for original PS1-style levels

| Asset family | Best use | Authoring note |
| --- | --- | --- |
| Rock_Platform_A–D | Wide landing zones, route junctions and summit islands | Scale from the measured bounds. Check the readable landing surface separately from the silhouette. |
| Rock_Blocky_A–I | Precision jumps and modular climbing ledges | The varied profiles work well in a shared palette. Keep collider tops close to visible ground. |
| Rock_Bridge_A–C | Natural crossings and distant route cues | Align an authored walkable surface along the deck. Use the rocky underside as silhouette. |
| Cliff_A–W | Layered canyon walls, alcove screens and landmarks | Place distant silhouettes at dramatic scales. Use small cliff pieces around playable routes. |
| Big_Stone and Stone_Small | Landmark stones and scale cues near traversal | Leave smaller stones decorative around precision landing areas. |
| Gravel and Ground | Path edges and grounding under landmarks | Keep the player route clear. Match the dominant tint across adjacent surfaces. |

Use standard models first when building small transferable modules. The MultiMat variants are useful when a mesh needs independently shaded faces. Layered variants depend on their particular vendor shading and should be validated in the destination render pipeline.

## Compatibility and preservation

ACP declares Unity 6000.3.6f1 and URP 17.3.0. The working validation editor was Unity 6000.4.10f1 with URP 17.4.0. A separate smoke import using ACP's PC render asset and quality settings opened the showcase and resolved 61 objects, six materials, the player controller and the Desert audio clip. Unity 6.4 resolved URP 17.4.0 in that test. ACP runtime on 6000.3.6f1 remains untested. The outer package imported and all 107 scenes opened there. The included screenshots were rendered in Built-in. The [URP baseline](scenes-urp-baseline.csv) records the first pass in URP. A color audit found more than 1% magenta pixels in 96 of 107 URP baseline captures, compared with zero of 107 Built-in captures. Unity's shader support flag alone did not catch render-pipeline incompatibility.

The publisher supplies a separate URP project inside the archive. Its bundled guide instructs users to open that project separately, and its assets reuse 1,045 source GUIDs. See the [URP edition inventory](official-urp-directory.csv). Keep the two editions separate. The [publisher URP scene audit](scenes-publisher-urp.csv) and [its 108 renders](Media/Publisher%20URP%20Scenes) cover that edition, including SampleScene. All renders completed. Four scenes have missing script references and seven report missing material slots or unsupported shaders. No capture exceeded the 1% magenta threshold. ACP's showcase uses its own URP Lit material overrides. Five [GUID overlaps](acp-guid-overlaps.json) with the installed WeatherMaker pack resolve to WeatherMaker in ACP. All five exact Polyquest originals and their metadata are preserved in the downloaded archive and in the local overlap backup under UserSettings/MovingViolationIntake/PolyquestOriginalOverlap.

The vendor guide calls out the optional **Simple Pixelizer** camera effect, Asset Store ID **3579**, and the character silhouette pictured in marketing as separate content. This showcase uses an original simple player mesh and Rowan's existing shader approach. The scene also uses the installed studio-owned **Ultimate Sound FX Bundle**, product **151756**, for Desert.wav. Its GUID appears in the transfer table for the playable scene. The four reusable geometry modules carry no audio dependency.

The licensed source and the 1,058,378,325-byte bundled URP ZIP stay in the local Unity project or licensed cache. The repository contains the studio-authored assemblies, scene, PSX variants, catalogues and rendered evidence.

## Rowan transfer files

[RowanTransfer](RowanTransfer) contains four prefab variants and six PSX materials with their original generated sidecars. Copy the selected variant and its dependent materials into the same relative Assets paths in Rowan. Resolve the base showcase module, Polyquest geometry and material dependencies using [transfer-dependencies.tsv](transfer-dependencies.tsv). The existing SeventhDay shader and the listed include files resolve by their original Rowan paths. The [Rowan PSX preview](Media/Rowan%20PSX%20Preview.png) uses the established shader in Unity 6.4. The transfer collection lives outside ACP's Assets folder because it references Rowan's renderer.
