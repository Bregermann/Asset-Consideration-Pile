# Moving Violation audio validation slice

The slice uses the full paid Sonity 1.2.0.1 package, Unity 6000.4.10f1, URP 17.4.0, and the Windows x64 IL2CPP player. The original code in this folder can live in public Git. Sonity source, the local audio selections, and any selected Undergrounds models must stay with the licensed developer.

Restore the exact archive recorded in the intake manifest using Unity Package Manager → My Assets. `restore_trial.py` verifies the paid archive SHA-256 and restores its original GUIDs. It also restores the slice's selected clips from the licensed Asset Consideration Pile. Place `BuildAudioTrial.cs` under `Assets/MovingViolation/Editor` and the three runtime scripts in `Assets/MovingViolation`. Build with Unity's batch method `MovingViolation.Audio.Editor.BuildAudioTrial.Build`. The build checks all cue assets before writing the player.

## Cue routing

| Cue | Category | Trigger and parameters |
| --- | --- | --- |
| Wet asphalt, snow, tile and gravel footsteps | SFX | Distance walked and the current surface. Concrete and stone recordings stand in for wet asphalt and gravel in the first slice. |
| Punch, gunshot and collision | SFX | Play from the originating world transform. The test scene uses buttons to exercise events independently of combat physics. |
| Siren and police radio | Vehicles and Police Radio | Play from the vehicle and UI/listener respectively. The first slice uses an alarm and a spoken callout as placeholders. |
| NPC bark | Voice | A spatial emitter can play the bark on dialogue or AI events. |
| Engine and shutdown | Vehicles | One loop per emitter, continuously updated by normalized RPM, throttle and travel speed. Shutdown releases the loop and plays a tail. |
| Rain and wind | Weather | Drive continuous levels from the current conditions and lower the low-pass cutoff as snowfall increases. |
| Underground and club | Ambience and Music | Update mix from enclosure and club audibility. The corridor adds a stone reverb zone and the low-pass curve muffles cross-room audio. |
| Menu, quest success and failure | UI and Music | UI interaction and independent outcome cues. |

Sonity owns playback and voice limits. The adapter accepts caller-owned world transforms and state. A future live weather source can call `Weather` from its resolved Weather Maker/Weatherade state, and a vehicle controller can call `Vehicle` using its measured RPM and speed. The trial uses explicitly selectable weather and a test vehicle to exercise those interfaces. There is no dependency on another game's startup managers.

## Run the checks

- In the player, walk from the street through the marked corridor and back. Test dry, rain and snowfall with Y or R. Enter or leave the test vehicle near the street with X or V.
- Use Start or Escape for Audio Options. Use the D-pad or arrow keys to select and adjust Master, Music, SFX, Voice, UI, Ambience, Vehicles, Weather and Police Radio.
- Launch with `--audio-smoke` to drive the scripted checks. Then launch with `--verify-volume` and inspect the output for the persisted Weather volume.
- Compare spatial cues at the near and far ends of the corridor and listen for changes in engine pitch, rain, and interior reverb. This still benefits from a physical controller and listening pass.
