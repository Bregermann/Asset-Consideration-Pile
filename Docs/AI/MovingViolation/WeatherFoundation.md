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

- **Weather Maker 8.0.9** is active in the local Pile at `Assets/WeatherMaker`. The narrowed import retained 711 runtime and support files, with zero serialized references to the 96 separately preserved demo files. Two vendor demo scenes reported missing components during the full-archive test. The scoped import passed the Unity 6000.3.6f1 and URP 17.3.0 smoke and the live Pile compile check. Scene rendering and weather transitions still need validation. [Package evidence](Packages/19.md) · [Unity Asset Store listing](https://assetstore.unity.com/packages/package/60955)

- **Weatherade 1.1.8** remains isolated. The prepared candidate uses `WeatheradeSRS_URP.unitypackage` followed by `WeatheradeSRS_URP_17_1.unitypackage`, the order used by the shipped installer for Unity 6.1 and newer. The merged candidate passed its GUID audit, then failed compilation with obsolete `PhysicMaterial` in the bundled controller and `BeginUICategory` overload errors in the weather inspectors. Resolve the matching vendor dependency and compiler compatibility before configuring a Pile renderer. In an isolated scene, confirm `SRS_DepthRenderer` has a consistent slot in every selected URP asset and then test the snow and rain materials. [Package evidence](Packages/24.md) · [Vendor installation](https://wiki.not-lonely.com/doku.php/weatherade_manual%3Ainstallation) · [Vendor renderer setup](https://wiki.not-lonely.com/doku.php/weatherade_manual%3Aquick_start) · [Unity Asset Store listing](https://assetstore.unity.com/packages/package/275622)

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
