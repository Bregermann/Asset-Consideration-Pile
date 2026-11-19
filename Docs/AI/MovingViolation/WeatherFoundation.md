# Moving Violation weather foundation

Use the Interstate Hauler weather coordinator as the reference for a single clock and weather state. Weather Maker is the atmosphere renderer. Weatherade is a surface response candidate. The Pile holds candidate assets for testing. Production adoption requires separate approval and a dependency-complete integration.

| Reference | Observed responsibility |
| --- | --- |
| `Assets/LWS/InterstateHauler/Weather/LwsWeather.cs` | Defines semantic conditions, presets, snapshots, runtime adapter contracts and the coordinator. The coordinator exposes world time and preset state. |
| `Assets/LWS/InterstateHauler/Weather/LwsWeatherMakerAdapter.cs` | Bridges coordinator time to Weather Maker in seconds and resolves weather profiles. Applies semantic precipitation and fog, tracks diagnostics and controls transitions. |
| `Assets/LWS/InterstateHauler/Weather/LwsWeatherPresetDefinition.cs` | Stores and validates an authorable preset in a ScriptableObject. |
| `Assets/LWS/InterstateHauler/Roads/Conditions/LwsWeatheradeAdapter.cs` | Implements the road-condition visual adapter. Treat the material response as a consumer of shared weather state. |

Read from the local `Bregermann/Interstate-Hauler-Trucking-Simulator` checkout. The production project and source files were not edited. [Reference repository](https://github.com/Bregermann/Interstate-Hauler-Trucking-Simulator)

## Candidates

- **Weather Maker**. The owned cache supplied version 8.0.9, authored with Unity 6000.3.19f1. Candidate assets are under `Assets/WeatherMaker`, including `Prefab/WeatherMakerPlayer.prefab`, `Prefab/WeatherMakerVolumetricFogSphere.prefab` and `Demo/Scenes/DemoSceneWetness.unity`. Visual compatibility on the Pile's Unity 6000.3.6f1 and URP 17.3.0 requires a scene and renderer test. [Unity Asset Store listing](https://assetstore.unity.com/packages/package/60955)
- **Weatherade**. The owned cache supplied version 1.1.8. Candidate paths include `Assets/NOT_Lonely/Weatherade SRS/Samples/BasicSetupSnow.unity`, `Assets/NOT_Lonely/Weatherade SRS/Samples/BasicSetupRain.unity` and the vendor URP support archives under `Assets/NOT_Lonely/Weatherade SRS/URP Support/`. Inspect the support archive and use an isolated terrain and material scene before touching project renderer settings. [Unity Asset Store listing](https://assetstore.unity.com/packages/package/275622)

## Open acceptance checks

| Capability | Test before adoption |
| --- | --- |
| Snow accumulation and melt | Drive a shared snow amount into terrain, static props and roads. Test accumulation, clear weather and region transitions. |
| Bootprints and tire marks | Compare persistence and fading across lanes, terrain and pooled surface events. Confirm the effect survives streaming and material changes. |
| Rain and wetness | Check snow-to-rain transitions, wetness decay, and shared globals across additive scenes. |
| Wind and fog | Compare coordinator values with directional particle and Vegetation response plus fog at ground level and across camera changes. |
| Plowing and traction | Use a small road segment. Track plowed depth separately from the visible effect and feed the surface condition into NWH or the approved vehicle adapter. |
| Persistent transitions | Save active weather, normalized world time, region, blend progress and surface state. Reload during a transition and check continuity. |

Candidate vehicle, pedestrian, traffic, player, helicopter and destruction packages remain test candidates. No demo scene needs to become a startup scene to evaluate them.
