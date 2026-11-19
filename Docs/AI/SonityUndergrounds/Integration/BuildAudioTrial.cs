using System;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEditor.Build;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
using UnityEngine.UI;

namespace MovingViolation.Audio.Editor
{
    public static class BuildAudioTrial
    {
        private const string Root = "Assets/MovingViolation";
        private const string SceneFile = Root + "/AudioTrial.unity";

        public static void Build()
        {
            foreach (AudioCue cue in Enum.GetValues(typeof(AudioCue)))
                if (!Resources.Load<AudioClip>("TrialCues/" + cue))
                    throw new InvalidOperationException($"Missing restored trial cue {cue}.");

            var scene = EditorSceneManager.NewScene(NewSceneSetup.EmptyScene, NewSceneMode.Single);
            var street = Material("Asphalt", new Color(0.14f, 0.17f, 0.2f));
            var wall = Material("Concrete", new Color(0.33f, 0.39f, 0.4f));
            var floor = Material("Tile", new Color(0.24f, 0.31f, 0.3f));
            var hazard = Material("Hazard", new Color(0.89f, 0.43f, 0.08f));
            Block("Street", new Vector3(0, -0.25f, 1), new Vector3(20, 0.5f, 14), street);
            Block("Tile corridor", new Vector3(0, -0.25f, 11), new Vector3(5, 0.5f, 6), floor);
            Block("Maintenance room", new Vector3(0, -0.25f, 18), new Vector3(9, 0.5f, 8), floor);
            Block("Left corridor wall", new Vector3(-2.5f, 1.5f, 11), new Vector3(0.4f, 3, 6), wall);
            Block("Right corridor wall", new Vector3(2.5f, 1.5f, 11), new Vector3(0.4f, 3, 6), wall);
            Block("Lintel", new Vector3(0, 2.8f, 8), new Vector3(5, 0.45f, 0.65f), hazard);
            Block("Corridor roof", new Vector3(0, 3.15f, 11), new Vector3(5.4f, 0.3f, 6), wall);
            Block("Right room wall", new Vector3(4.5f, 1.5f, 18), new Vector3(0.3f, 3, 8), wall);
            Block("Back wall", new Vector3(0, 1.5f, 22), new Vector3(9, 3, 0.3f), wall);
            Block("Left room wall", new Vector3(-4.5f, 1.5f, 18), new Vector3(0.3f, 3, 8), wall);
            DressCorridor();

            var dataPath = Root + "/AudioTrialNavMesh.asset";
            var existingData = AssetDatabase.LoadAssetAtPath<NavMeshData>(dataPath);
            var sources = new List<NavMeshBuildSource>();
            var bounds = new Bounds(new Vector3(0, 1, 10), new Vector3(27, 12, 33));
            NavMeshBuilder.CollectSources(bounds, ~0, NavMeshCollectGeometry.PhysicsColliders, 0,
                new List<NavMeshBuildMarkup>(), sources);
            var settings = NavMesh.GetSettingsByIndex(0);
            var navData = NavMeshBuilder.BuildNavMeshData(settings, sources, bounds, Vector3.zero, Quaternion.identity);
            if (!navData) throw new InvalidOperationException("Trial navmesh creation failed.");
            if (existingData)
            {
                EditorUtility.CopySerialized(navData, existingData);
                navData = existingData;
                EditorUtility.SetDirty(navData);
            }
            else AssetDatabase.CreateAsset(navData, dataPath);

            var player = new GameObject("Player");
            player.transform.position = new Vector3(0, 1.02f, 1);
            var controller = player.AddComponent<CharacterController>();
            controller.height = 1.8f;
            var camera = new GameObject("Camera");
            camera.transform.SetParent(player.transform, false);
            camera.transform.localPosition = new Vector3(0, 0.58f, 0);
            camera.tag = "MainCamera";
            camera.AddComponent<Camera>();
            camera.AddComponent<AudioListener>();
            camera.AddComponent<UniversalAdditionalCameraData>().renderPostProcessing = true;

            var sun = new GameObject("Daylight").AddComponent<Light>();
            sun.type = LightType.Directional;
            sun.intensity = 1.15f;
            sun.shadows = LightShadows.Soft;
            sun.transform.rotation = Quaternion.Euler(45, -25, 0);
            PointLight("Entry work light", new Vector3(0, 2.45f, 9), new Color(1f, 0.68f, 0.35f));
            PointLight("Maintenance light", new Vector3(0, 2.8f, 17), new Color(0.45f, 0.85f, 1f));

            var weather = new GameObject("Weather");
            weather.transform.position = new Vector3(0, 2f, 3);
            var tunnel = new GameObject("Tunnel Ambience");
            tunnel.transform.position = new Vector3(0, 1f, 11);
            var reverb = tunnel.AddComponent<AudioReverbZone>();
            reverb.reverbPreset = AudioReverbPreset.StoneCorridor;
            reverb.minDistance = 2f;
            reverb.maxDistance = 9f;
            var driver = Block("Vehicle", new Vector3(-2, 0.65f, 2), new Vector3(1.6f, 0.85f, 2.9f), hazard);
            driver.GetComponent<Collider>().enabled = false;
            var trial = new GameObject("Moving Violation Audio Trial");
            trial.AddComponent<AudioTrial>();
            trial.AddComponent<TrialNavigation>().Data = navData;
            AddHud();

            EditorSceneManager.SaveScene(scene, SceneFile);
            EditorBuildSettings.scenes = new[] { new EditorBuildSettingsScene(SceneFile, true) };
            PlayerSettings.productName = "Moving Violation";
            PlayerSettings.runInBackground = true;
            PlayerSettings.SetScriptingBackend(NamedBuildTarget.Standalone, ScriptingImplementation.IL2CPP);
            AssetDatabase.SaveAssets();
            var directory = Path.GetFullPath(Environment.GetEnvironmentVariable("MV_AUDIO_BUILD_DIR")
                                             ?? "Builds/AudioTrial");
            Directory.CreateDirectory(directory);
            var report = BuildPipeline.BuildPlayer(new[] { SceneFile }, Path.Combine(directory, "MovingViolation.exe"),
                BuildTarget.StandaloneWindows64, BuildOptions.None);
            Debug.Log($"MOVING_VIOLATION_BUILD {report.summary.result} {report.summary.totalSize} bytes");
            if (report.summary.result != UnityEditor.Build.Reporting.BuildResult.Succeeded)
                throw new InvalidOperationException("Moving Violation Windows IL2CPP build failed.");
        }

        private static Material Material(string name, Color color)
        {
            var path = Root + "/" + name + ".mat";
            var material = AssetDatabase.LoadAssetAtPath<Material>(path);
            if (!material)
            {
                material = new Material(GraphicsSettings.currentRenderPipeline.defaultMaterial);
                AssetDatabase.CreateAsset(material, path);
            }
            material.color = color;
            EditorUtility.SetDirty(material);
            return material;
        }

        private static void DressCorridor()
        {
            const string localSelection = "UserSettings/MovingViolationDressing.txt";
            if (!File.Exists(localSelection))
                return;
            var positions = new[] { new Vector3(1.95f, 1.25f, 11f), new Vector3(-3.2f, 0.95f, 17f) };
            var paths = File.ReadAllLines(localSelection);
            for (var i = 0; i < Mathf.Min(paths.Length, positions.Length); i++)
            {
                var prefab = AssetDatabase.LoadAssetAtPath<GameObject>(paths[i]);
                if (!prefab)
                    throw new InvalidOperationException("Restore the selected Undergrounds prefab " + paths[i]);
                var prop = (GameObject)PrefabUtility.InstantiatePrefab(prefab);
                var renderers = prop.GetComponentsInChildren<Renderer>();
                if (renderers.Length == 0)
                    throw new InvalidOperationException("No visible geometry in " + paths[i]);
                foreach (var collider in prop.GetComponentsInChildren<Collider>(true))
                    collider.enabled = false;
                var bounds = renderers[0].bounds;
                foreach (var renderer in renderers)
                    bounds.Encapsulate(renderer.bounds);
                var scale = 1.7f / Mathf.Max(bounds.size.x, bounds.size.y, bounds.size.z, 0.01f);
                var displacement = (bounds.center - prop.transform.position) * scale;
                prop.transform.localScale *= scale;
                prop.transform.position = positions[i] - displacement;
            }
        }

        private static GameObject Block(string name, Vector3 position, Vector3 scale, Material material)
        {
            var block = GameObject.CreatePrimitive(PrimitiveType.Cube);
            block.name = name;
            block.transform.SetPositionAndRotation(position, Quaternion.identity);
            block.transform.localScale = scale;
            block.GetComponent<Renderer>().sharedMaterial = material;
            return block;
        }

        private static void PointLight(string name, Vector3 position, Color color)
        {
            var light = new GameObject(name).AddComponent<Light>();
            light.transform.position = position;
            light.type = LightType.Point;
            light.color = color;
            light.intensity = 7f;
            light.range = 12f;
        }

        private static void AddHud()
        {
            var canvas = new GameObject("Audio HUD").AddComponent<Canvas>();
            canvas.renderMode = RenderMode.ScreenSpaceOverlay;
            var scaler = canvas.gameObject.AddComponent<CanvasScaler>();
            scaler.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
            scaler.referenceResolution = new Vector2(1280, 720);
            var text = new GameObject("Instructions").AddComponent<Text>();
            text.transform.SetParent(canvas.transform, false);
            text.font = Resources.GetBuiltinResource<Font>("LegacyRuntime.ttf");
            text.fontSize = 21;
            text.color = Color.white;
            text.rectTransform.anchorMin = new Vector2(0, 1);
            text.rectTransform.anchorMax = new Vector2(0, 1);
            text.rectTransform.pivot = new Vector2(0, 1);
            text.rectTransform.anchoredPosition = new Vector2(24, -24);
            text.rectTransform.sizeDelta = new Vector2(810, 116);
            var outline = text.gameObject.AddComponent<Outline>();
            outline.effectColor = Color.black;
            outline.effectDistance = new Vector2(2, -2);
        }
    }
}
