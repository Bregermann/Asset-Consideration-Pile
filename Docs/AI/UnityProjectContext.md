# Unity project context

This Unity project stores imported asset packs for evaluation and reuse. See [Asset catalogue](AssetCatalogue.md) for pack descriptions and file paths.

- Unity 6000.3.6f1 and Universal Render Pipeline 17.3.0.
- Input System 1.18.0 is configured with `Assets/InputSystem_Actions.inputactions`.
- The enabled build scene in `ProjectSettings/EditorBuildSettings.asset` is `Assets/Scenes/SampleScene.unity`.
- Unity Test Framework 1.6.0 is declared in the manifest. Editor, Play Mode and build validation were outside the asset inventory scope.
- The project has Unity AI Assistant 2.22.0-pre.1 in its manifest. A live Unity MCP connection was unverified.
- `Assets/Settings/` holds render settings and `Assets/TutorialInfo/` holds template tutorial assets. The imported folders are mapped in the catalogue.

Inspected on 2026-11-18 against baseline `35c55eb741e1a97f43bbf9974da31da973ab00b8` and the local asset tree. Environment evidence is in `ProjectSettings/ProjectVersion.txt`, `ProjectSettings/EditorBuildSettings.asset` and `Packages/manifest.json`.
