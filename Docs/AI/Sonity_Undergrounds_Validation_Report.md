# Sonity and Undergrounds validation

Moving Violation uses Unity 6000.4.10f1 and URP 17.4.0. The original Asset Consideration Pile shortlist remains in its existing manifest.

## Windows player

- Build status: Unity 6.4 Windows rebuild running.
- Build path: Pending the Unity 6.4 player.
- Platform: Windows x64 IL2CPP. Full paid Sonity 1.2.0.1, store ID 229857.
- Weather and engine state use the trial inputs. The new project has no production weather or driving system to migrate.
- The options menu uses the nine persisted mix controls. Several cues are trial substitutes documented in the event map.
- No other production project was edited.
- Local Undergrounds scene dependency closure: Modular Pipes & Vent Pack 175045, SM_vent_2_Rust.prefab and nine other dependency paths, 33,978,327 source bytes.

[Original adapter, event map, and listening checklist](SonityUndergrounds/Integration/README.md).

## Undergrounds

Unity Package Manager returned entitlement for the parent and all seven products. Child ownership was confirmed through parent 320220. Archive sizes and SHA-256 digests are in the manifest.
The overlap index compares 21 pairs using original Unity GUIDs and payload hashes. A shared GUID with different payload bytes needs a deliberate canonical pick. It must not be silently overwritten.

[Intake manifest](Sonity_Undergrounds_Intake_Manifest.csv) · [Overlap index](SonityUndergrounds/BundleOverlap.csv) · [Project fit and optional Sonity adoption](SonityUndergrounds/ProjectFit.md) · [Project disposition matrix](SonityUndergrounds/ProjectDispositions.csv).

- Industrial Props and Abandoned Shelter share 692 GUIDs. 355 also match payload bytes and 337 use different payload bytes.
- Industrial Props and Subway share 293 GUIDs. 118 also match payload bytes and 175 use different payload bytes.
- Pipes & Vent and Mini Bunker share 220 GUIDs. 66 also match payload bytes and 154 use different payload bytes.
- Off-Road Vehicle and Abandoned Shelter share 71 GUIDs. 37 also match payload bytes and 34 use different payload bytes.

| Product | Disposition | Remote checkpoint |
| --- | --- | --- |
| Sonity - Audio Middleware | ARCHIVE_VERIFIED | [b41855d](https://github.com/Bregermann/Asset-Consideration-Pile/commit/b41855d6513288f89949cfda91e32b25ce785476) |
| Modular Subway Tunnels | ARCHIVE_VERIFIED | Pending |
| Modular Abandoned Shelter | ARCHIVE_VERIFIED | Pending |
| Modular Mini Bunker | ARCHIVE_VERIFIED | Pending |
| CyberPunk Underpass | ARCHIVE_VERIFIED | Pending |
| Off-Road Vehicle | ISOLATED_URP_IMPORT_VALIDATED | [b86afa7](https://github.com/Bregermann/Asset-Consideration-Pile/commit/b86afa7fc0937f05b6a5dd51811aca838134354e) |
| Industrial Underground Props Pack | ARCHIVE_VERIFIED | Pending |
| Modular Pipes & Vent Pack | ISOLATED_URP_IMPORT_VALIDATED | [ec900cf](https://github.com/Bregermann/Asset-Consideration-Pile/commit/ec900cf89781854f139f1a141e312b860b74887a) |
| Undergrounds / Mega Bundle 7 in 1 | ISOLATED_URP_IMPORT_VALIDATED | [ad30409](https://github.com/Bregermann/Asset-Consideration-Pile/commit/ad3040990851445941235ddc2812c7ffc68750be) |

## Remaining validation

- Physical gamepad, human listening, and a longer session with simultaneous traffic, NPCs and combat remain outside the automated checks.
- Standalone review results cover only the imported scenes and sampled prefabs. Host-specific streaming, snow/wetness, occlusion, content budgets and production scene navigation require tests in each actual host.
- The licensed source files, Windows player, vendor textures and original archives remain local. The depot uses regular Git. Its individual asset checkpoint includes the size and full source-path inventory.
