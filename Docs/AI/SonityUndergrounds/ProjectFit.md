# Undergrounds and Sonity project fit

Recommendations below identify candidates for a test scene. A standalone import result does not establish camera, NPC, streaming, lighting or frame-budget performance in another game.

| Project | Subway | Shelter | Bunker | Underpass | Off-road 4×4 | Industrial props | Pipes and vents |
| --- | --- | --- | --- | --- | --- | --- | --- |
| Moving Violation | Recommended for production as a small maintenance entrance and corridor | Depot only, use a few credible shelter props | Recommended for production as a later hideout | Depot only pending a contemporary regrade | Depot only as art pending NWH fit and gamepad handling | Use the selected environment's copy where identical | Use the selected environment's copy where identical |
| Interstate: Hauler | Depot only, no route need identified | Candidate for an abandoned highway service site | Depot only | Depot only pending real route geography | Candidate for a recovery target, preserve the existing vehicle controller | Candidate for depot utility repair | Candidate for maintenance rooms |
| Truck Taxi | Depot only | Depot only | Depot only | Candidate for a small route landmark | Candidate as a utility vehicle body | Depot only | Depot only |
| Truck Sports: Party! | Not suitable | Not suitable | Not suitable | Depot only, select individual obstacles | Candidate as a vehicle body | Depot only, select individual obstacles | Not suitable |
| Cartastrophe | Depot only | Candidate for a contraband storage room | Depot only | Depot only | Candidate for an old delivery vehicle | Candidate for pallet and utility jobs | Depot only |
| Rest Stop Racket | Depot only | Candidate for underground storage | Depot only | Depot only | Depot only | Candidate for repairable power equipment | Candidate for a small utility room |
| Rowan of Bramblebrook | Not suitable | Not suitable | Not suitable | Not suitable | Not suitable | Not suitable | Not suitable |
| Dead Air / horror | Recommended for production as a confined walkable sequence after a test | Recommended as a salvage or storm shelter | Recommended as a separate short hideout | Depot only pending lighting and dressing | Depot only as stationary dressing | Use matching copies from the selected environment | Use matching copies from the selected environment |
| Lifeline Run | Depot only, check emergency vehicle route scale first | Candidate for a rescue destination | Depot only | Candidate for an industrial district landmark | Depot only pending handling and EMS mission fit | Candidate for restrained industrial dressing | Depot only |

## Audio ownership and opt-in

- **Interstate: Hauler** already has a bootstrap and a shared weather coordinator under `Assets/LWS/InterstateHauler`. Subscribe to shared weather output for an isolated audio pass. Keep the existing driving and weather control paths.
- **Dead Air** is present in the Interstate checkout. `DeadAirAudioDirector`, `DeadAirAudioEventTrigger`, and `DeadAirDialogueLibrary` already own audio orchestration. Test one tunnel emitter behind those calls before any wider adoption.
- **Rowan** has Spark's `AudioSettingsData` and `AudioSettingsUI` plus `BlazeAIAudioManager`. Preserve their settings and AI audio behavior. Test a single ambience on a duplicate scene first.
- **Lifeline Run** has separate gameplay test scenes, a Port Industrial district and `LifelineArcadeAudioEventDebugReceiver`. Exercise a stationary siren or one ambience from a duplicate district before changing career scenes.
- **Truck Taxi** lives inside the Interstate checkout. Preserve `TruckTaxiAudioController`, `TruckTaxiAudioSettingsPanel`, `TruckTaxi.mixer`, and `TruckTaxiVehicle.mixer`. Compare a single route landmark in a duplicate of `Taxi_RailCorridor.unity` or `Taxi_ServiceArea.unity`. Drive a Sonity test emitter from an existing event and preserve passenger dialogue and radio playback.
- **Truck Sports: Party!** also lives inside the Interstate checkout. Preserve `SportsMatchAudioAnchor` and compare selected art in a duplicate of `TruckSports.unity`. Stress-test per-player cue concurrency before wider adoption.
- **Cartastrophe and Rest Stop Racket** are design evaluations. A matching Unity scene or checkout was not verified. No existing game has been modified here.

The Off-Road Vehicle is an art-only candidate. Preserve the existing vehicle physics authority and verify wheel pivots, collider fit, reverse, braking, and controller behavior before promoting it as drivable.
