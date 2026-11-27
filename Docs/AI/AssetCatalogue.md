# Asset catalogue

Use this catalogue to find source assets for other Unity projects. Start with the pack that fits the sound or visual you need, then search [the file inventory](AssetInventory.txt) for an action, material, creature or style. Paths are relative to this repository. Suggested uses come from folder and file names. Audition clips before selecting them.

| Pack | Folder | Files | Audio clips | Suggested uses |
| --- | --- | ---: | ---: | --- |
| Complete UI SFX | `Assets/CelerisLab/` | 506 | 505 | Menu navigation, themed buttons, inventory, crafting, shop, social cues, warnings and success feedback. |
| Combat Magic Spells | `Assets/CombatMagicSpells/` | 600 | 600 | Combat spell effects across V1, V2 and Organic Magic Spells. Search by spell name and action. |
| Dialog Text SFX | `Assets/DialogTextSFX/` | 126 | 126 | Text reveal and dialogue blips, including retro tones, voice-like sounds, typewriters, pens and chalkboards. |
| Epic Positive Game Risers SFX | `Assets/Epic Positive Game Risers SFX/` | 48 | 47 | Positive ascending cues for rewards, unlocks and level-ups. |
| Do It Retro | `Assets/Modotool/` | 118 | 0 | Unity editor tools for producing retro sound effects and music, with example configurations and PDF manuals. |
| Monster Sounds Pack | `Assets/Monster Sounds Pack/` | 680 | 680 | Browse by creature family for demons, ghosts, zombies, ooze, large creatures, humanoids and ancient-language vocals. |
| Monsters SFX | `Assets/MonstersSFX/` | 1,105 | 1,105 | Browse cinematic monsters, enemies, ghosts and zombies, low voices and silly monsters. |

The inventory includes files under `Assets/` and omits Unity `.meta` sidecars. Copy a selected asset with its original sidecar when you need to preserve its Unity GUID and import settings. For Unity prefabs and scenes, include dependencies. Check the pack's usage terms for the destination project.

For each requested update, refresh this catalogue and inventory, then commit and push the new imports by pack. Use regular Git. Leave files over 99,000,000 bytes local, record their paths here and add exact ignore entries. Keep each commit below 1,000,000,000 bytes of source files, grouping assets with their sidecars.

## Moving Violation intake

The S/A intake adds a searchable audio index, exact Unity Store sources, and Unity compatibility and restore evidence. Search the clip and path columns for an action, material, vehicle or setting, then use the package manifest to check availability. [Additional audio assets](MovingViolation/AudioAssets.csv) and [71-package manifest](MovingViolation_AssetIntake_Manifest.csv).

The addendum adds Sonity and seven Undergrounds listings with archive evidence, source paths and Unity test results. [Sonity and Undergrounds inventory](Sonity_Undergrounds_Intake_Manifest.csv).

## Cinematics and marketing production

**S-tier voice production.** [DeepVoice Pro – Text to Voice](DeepVoicePro.md) is cataloged for Rowan of Bramblebrook and other Luna Wolf Studios projects. The studio owner confirmed ownership. Download and import await Unity account access or the original archive. Commercial output rights remain unverified.

Use the [cinematic production catalog](CinematicProduction.md) to choose a capture stack, find licensed source archives and check Unity 6 URP validation before importing into a Luna Wolf Studios project.

## Local files over 99 MB

None at this inventory snapshot.

## Polyquest environment and platforming assets

[Polyquest Worlds Full Pack Vol. 1](Polyquest/README.md) records the studio-owned POLYBOX package, searchable source and prefab inventories, canyon traversal showcase, capture evidence and selective transfer for Rowan of Bramblebrook.
