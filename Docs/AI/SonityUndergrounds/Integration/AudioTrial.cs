using System;
using System.Collections;
using Sonity;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.AI;
using UnityEngine.UI;

namespace MovingViolation.Audio
{
    public sealed class AudioTrial : MonoBehaviour
    {
        private SonityAudio audioAdapter;
        private SoundManager manager;
        private Transform driver;
        private Transform weather;
        private Transform interior;
        private CharacterController player;
        private Camera playerCamera;
        private readonly SoundEvent[] sounds = new SoundEvent[Enum.GetValues(typeof(AudioCue)).Length];
        private readonly float[] samples = new float[1024];
        private float walkDistance;
        private float rpm;
        private float inside;
        private bool driving;
        private int weatherMode;
        private int selectedBus;
        private string label = "Street";
        private bool options;
        private bool automated;
        private float cameraYaw;
        private float cameraPitch;
        private Text status;

        public void Awake()
        {
            manager = FindAnyObjectByType<SoundManager>();
            if (!manager)
                manager = new GameObject("Sonity SoundManager").AddComponent<SoundManager>();
            manager.SetVoiceLimit(24);
            audioAdapter = gameObject.AddComponent<SonityAudio>();
            player = GameObject.Find("Player").GetComponent<CharacterController>();
            playerCamera = player.GetComponentInChildren<Camera>();
            driver = GameObject.Find("Vehicle").transform;
            weather = GameObject.Find("Weather").transform;
            interior = GameObject.Find("Tunnel Ambience").transform;
            var bindings = new SonityAudio.Binding[sounds.Length];
            for (var i = 0; i < sounds.Length; i++)
            {
                var cue = (AudioCue)i;
                sounds[i] = CreateEvent(cue);
                bindings[i] = new SonityAudio.Binding { Cue = cue, Bus = Bus(cue), Event = sounds[i] };
            }
            audioAdapter.Configure(bindings, "MovingViolation.AudioTrial.");
            status = FindAnyObjectByType<Text>();
            var args = Environment.GetCommandLineArgs();
            automated = Array.Exists(args, arg => arg is "--audio-smoke" or "--verify-volume");
            if (automated)
            {
                Application.runInBackground = true;
                InputSystem.settings.backgroundBehavior = InputSettings.BackgroundBehavior.IgnoreFocus;
                StartCoroutine(Verify(Array.Exists(args, arg => arg == "--verify-volume")));
            }
        }

        private static AudioBus Bus(AudioCue cue) => cue switch
        {
            AudioCue.Engine or AudioCue.EngineStop or AudioCue.Siren => AudioBus.Vehicles,
            AudioCue.Rain or AudioCue.Wind => AudioBus.Weather,
            AudioCue.Underground => AudioBus.Ambience,
            AudioCue.Club or AudioCue.QuestWon or AudioCue.QuestLost => AudioBus.Music,
            AudioCue.Voice => AudioBus.Voice,
            AudioCue.Radio => AudioBus.PoliceRadio,
            AudioCue.Menu => AudioBus.Ui,
            _ => AudioBus.Sfx,
        };

        private static SoundEvent CreateEvent(AudioCue cue)
        {
            var loop = cue is AudioCue.Engine or AudioCue.Rain or AudioCue.Wind or AudioCue.Underground or AudioCue.Club;
            var spatial = cue is not (AudioCue.Menu or AudioCue.QuestWon or AudioCue.QuestLost or AudioCue.Radio);
            var container = ScriptableObject.CreateInstance<SoundContainer>();
            var clip = Resources.Load<AudioClip>("TrialCues/" + cue);
            if (!clip)
                throw new InvalidOperationException($"Restore the local audio file for {cue}.");
            container.internals.audioClips = new[] { clip };
            var tuning = container.internals.data;
            tuning.loopEnabled = loop;
            tuning.distanceEnabled = spatial;
            tuning.distanceScale = loop ? 30f : 22f;
            tuning.spatialBlend = spatial ? 1f : 0f;
            tuning.lowpassEnabled = loop;
            tuning.lowpassIntensityEnable = loop;
            var sound = ScriptableObject.CreateInstance<SoundEvent>();
            sound.name = cue.ToString();
            sound.internals.soundContainers = new[] { container };
            sound.internals.data.polyphony = loop ? 3 : 4;
            return sound;
        }

        private void Update()
        {
            if (automated)
                return;
            var gamepad = Gamepad.current;
            var keyboard = Keyboard.current;
            if (gamepad?.startButton.wasPressedThisFrame == true || keyboard?.escapeKey.wasPressedThisFrame == true)
            {
                options = !options;
                audioAdapter.Play(AudioCue.Menu, player.transform);
            }
            if (options)
            {
                ChangeOptions(gamepad, keyboard);
                return;
            }

            if (gamepad?.buttonNorth.wasPressedThisFrame == true || keyboard?.rKey.wasPressedThisFrame == true)
                weatherMode = (weatherMode + 1) % 3;
            if (gamepad?.buttonWest.wasPressedThisFrame == true || keyboard?.vKey.wasPressedThisFrame == true)
                if (driving || Vector3.Distance(player.transform.position, driver.position) < 4f)
                    driving = !driving;
            if (gamepad?.rightShoulder.wasPressedThisFrame == true || keyboard?.spaceKey.wasPressedThisFrame == true)
                audioAdapter.Play(driving ? AudioCue.Collision : AudioCue.Impact, driving ? driver : player.transform);
            if (gamepad?.leftShoulder.wasPressedThisFrame == true || keyboard?.fKey.wasPressedThisFrame == true)
                audioAdapter.Play(AudioCue.Gunshot, player.transform);
            if (gamepad?.buttonEast.wasPressedThisFrame == true || keyboard?.qKey.wasPressedThisFrame == true)
                audioAdapter.Play(AudioCue.Radio, player.transform);
            if (gamepad?.rightStickButton.wasPressedThisFrame == true || keyboard?.tKey.wasPressedThisFrame == true)
                audioAdapter.Play(AudioCue.Siren, driver);
            if (gamepad?.leftStickButton.wasPressedThisFrame == true || keyboard?.gKey.wasPressedThisFrame == true)
                audioAdapter.Play(AudioCue.QuestLost, player.transform);
            if (gamepad?.buttonSouth.wasPressedThisFrame == true || keyboard?.eKey.wasPressedThisFrame == true)
                audioAdapter.Play(inside > 0.5f ? AudioCue.QuestWon : AudioCue.Voice, player.transform);

            var input = gamepad?.leftStick.ReadValue() ?? Vector2.zero;
            if (keyboard != null)
                input += new Vector2((keyboard.dKey.isPressed ? 1 : 0) - (keyboard.aKey.isPressed ? 1 : 0),
                                     (keyboard.wKey.isPressed ? 1 : 0) - (keyboard.sKey.isPressed ? 1 : 0));
            var look = gamepad?.rightStick.ReadValue() ?? Vector2.zero;
            if (Mouse.current?.rightButton.isPressed == true)
                look += Mouse.current.delta.ReadValue() * 0.08f;
            cameraYaw += look.x * 110f * Time.deltaTime;
            cameraPitch = Mathf.Clamp(cameraPitch - look.y * 110f * Time.deltaTime, -65f, 65f);
            player.transform.rotation = Quaternion.Euler(0f, cameraYaw, 0f);
            playerCamera.transform.localRotation = Quaternion.Euler(cameraPitch, 0f, 0f);
            var travel = MoveCharacter(input, Time.deltaTime);
            if (driving)
                driver.position += travel;
            else
            {
                walkDistance += travel.magnitude;
                if (walkDistance >= 1.45f)
                {
                    walkDistance -= 1.45f;
                    audioAdapter.Play(Surface(), player.transform);
                }
            }
            rpm = Mathf.MoveTowards(rpm, driving ? Mathf.Clamp01(input.magnitude) : 0, Time.deltaTime);
            inside = Mathf.MoveTowards(inside, player.transform.position.z > 7f ? 1 : 0, Time.deltaTime * 2);
            label = player.transform.position.z > 14f ? "Underground room" : inside > 0.5f ? "Maintenance corridor" : "Street";
            audioAdapter.Vehicle(driver, driving, rpm, input.magnitude,
                travel.magnitude / (Mathf.Max(0.0001f, Time.deltaTime) * 8f));
            audioAdapter.Weather(weather, weatherMode == 1 ? 0.75f : 0, weatherMode == 0 ? 0.08f : 0.45f, weatherMode == 2 ? 1 : 0);
            audioAdapter.Interior(interior, inside, Mathf.Lerp(0.07f, 0.7f, inside));
        }

        private AudioCue Surface()
        {
            if (inside > 0.5f) return AudioCue.Tile;
            if (weatherMode == 2) return AudioCue.Snow;
            return player.transform.position.x > 1f ? AudioCue.Gravel : AudioCue.WetAsphalt;
        }

        private Vector3 MoveCharacter(Vector2 input, float seconds)
        {
            var desired = player.transform.TransformDirection(new Vector3(input.x, 0, input.y));
            var motion = Vector3.ClampMagnitude(desired, 1f) * (driving ? 8f : 4f);
            var previous = player.transform.position;
            player.Move((motion + Vector3.down * 3f) * seconds);
            return Vector3.ProjectOnPlane(player.transform.position - previous, Vector3.up);
        }

        private void ChangeOptions(Gamepad pad, Keyboard keys)
        {
            var count = Enum.GetValues(typeof(AudioBus)).Length;
            if (pad?.dpad.down.wasPressedThisFrame == true || keys?.downArrowKey.wasPressedThisFrame == true)
                selectedBus = (selectedBus + 1) % count;
            if (pad?.dpad.up.wasPressedThisFrame == true || keys?.upArrowKey.wasPressedThisFrame == true)
                selectedBus = (selectedBus + count - 1) % count;
            float change = 0f;
            if (pad?.dpad.left.wasPressedThisFrame == true || keys?.leftArrowKey.wasPressedThisFrame == true) change = -0.1f;
            if (pad?.dpad.right.wasPressedThisFrame == true || keys?.rightArrowKey.wasPressedThisFrame == true) change = 0.1f;
            if (change != 0f)
                audioAdapter.SetVolume((AudioBus)selectedBus, audioAdapter.GetVolume((AudioBus)selectedBus) + change);
        }

        private IEnumerator Verify(bool readBack)
        {
            yield return new WaitForSecondsRealtime(0.6f);
            if (readBack)
            {
                Finish(Mathf.Abs(audioAdapter.GetVolume(AudioBus.Weather) - 0.37f) < 0.001f, "persisted Weather=0.37");
                yield break;
            }
            audioAdapter.SetVolume(AudioBus.Master, 1f);
            audioAdapter.SetVolume(AudioBus.Weather, 1f);
            audioAdapter.Vehicle(driver, true, 0.2f, 0.2f, 0.15f);
            audioAdapter.Weather(weather, 0.7f, 0.4f, 0.6f);
            audioAdapter.Interior(interior, 0.8f, 0.7f);
            yield return new WaitForSecondsRealtime(0.4f);
            var engine = manager.GetLastPlayedAudioSource(sounds[(int)AudioCue.Engine], driver);
            var rain = manager.GetLastPlayedAudioSource(sounds[(int)AudioCue.Rain], weather);
            var club = manager.GetLastPlayedAudioSource(sounds[(int)AudioCue.Club], interior);
            var enginePitch = engine ? engine.pitch : 0;
            audioAdapter.Vehicle(driver, true, 0.82f, 0.8f, 0.65f);
            var listenerPeak = 0f;
            var sourcePeak = 0f;
            var timestamp = AudioSettings.dspTime;
            var sampleEnd = Time.realtimeSinceStartup + 1.5f;
            while (Time.realtimeSinceStartup < sampleEnd)
            {
                AudioListener.GetOutputData(samples, 0);
                listenerPeak = Mathf.Max(listenerPeak, Peak());
                if (engine && engine.isPlaying)
                {
                    engine.GetOutputData(samples, 0);
                    sourcePeak = Mathf.Max(sourcePeak, Peak());
                }
                yield return null;
            }
            var dspAdvanced = AudioSettings.dspTime > timestamp + 0.05;
            var changedPitch = engine && engine.pitch > enginePitch + 0.1f;
            var sourceState = engine ? $"playing={engine.isPlaying} sourceVolume={engine.volume:F4} samples={engine.timeSamples}" : "engineMissing";
            var nav = new NavMeshPath();
            var access = NavMesh.SamplePosition(new Vector3(0, 0, 1), out var a, 2f, NavMesh.AllAreas)
                && NavMesh.SamplePosition(new Vector3(0, 0, 16), out var b, 2f, NavMesh.AllAreas)
                && NavMesh.CalculatePath(a.position, b.position, NavMesh.AllAreas, nav)
                && nav.status == NavMeshPathStatus.PathComplete
                && NavMesh.CalculatePath(b.position, a.position, NavMesh.AllAreas, nav)
                && nav.status == NavMeshPathStatus.PathComplete;
            var cues = 0;
            foreach (AudioCue cue in Enum.GetValues(typeof(AudioCue)))
                if (IsOneShot(cue) && audioAdapter.Play(cue, player.transform))
                    cues++;
            audioAdapter.Vehicle(driver, false, 0, 0, 0);
            var pad = InputSystem.AddDevice<Gamepad>();
            var routeStart = player.transform.position;
            yield return DriveRoute(pad, Vector2.up);
            var arrival = player.transform.position;
            var entered = player.transform.position.z > 14f && playerCamera.isActiveAndEnabled;
            var args = Environment.GetCommandLineArgs();
            var snapshot = Array.IndexOf(args, "--capture-trial");
            if (entered && snapshot >= 0 && snapshot + 1 < args.Length)
                ScreenCapture.CaptureScreenshot(args[snapshot + 1]);
            yield return DriveRoute(pad, Vector2.down);
            var exited = player.transform.position.z < 5f;
            automated = false;
            InputSystem.QueueStateEvent(pad, new GamepadState(GamepadButton.Start));
            yield return null;
            var opened = options;
            InputSystem.QueueStateEvent(pad, new GamepadState(GamepadButton.DpadDown));
            yield return null;
            var navigated = selectedBus == (int)AudioBus.Music;
            InputSystem.RemoveDevice(pad);
            automated = true;
            audioAdapter.SetVolume(AudioBus.Weather, 0.37f);
            Finish(Mathf.Max(listenerPeak, sourcePeak) > 0.0001f && dspAdvanced
                && engine && rain && club && changedPitch && access && cues == 14
                && entered && exited && opened && navigated,
                $"listenerPeak={listenerPeak:F6} sourcePeak={sourcePeak:F6} dsp={dspAdvanced} {sourceState} "
                + $"engine={!!engine} rain={!!rain} club={!!club} pitch={changedPitch} path={access} cues={cues} "
                + $"entered={entered} exited={exited} start={routeStart} arrival={arrival} controllerMenu={opened && navigated}");
        }

        private IEnumerator DriveRoute(Gamepad pad, Vector2 direction)
        {
            InputSystem.QueueStateEvent(pad, new GamepadState { leftStick = direction });
            InputSystem.Update();
            var input = pad.leftStick.ReadValue();
            for (var frame = 0; frame < 245; frame++)
            {
                MoveCharacter(input, 1f / 60f);
                if (frame % 15 == 0)
                {
                    Physics.SyncTransforms();
                    yield return null;
                }
            }
        }

        private float Peak()
        {
            var peak = 0f;
            foreach (var sample in samples)
                peak = Mathf.Max(peak, Mathf.Abs(sample));
            return peak;
        }

        private void LateUpdate()
        {
            if (!status || automated)
                return;
            if (options)
            {
                var bus = (AudioBus)selectedBus;
                status.text = $"AUDIO OPTIONS\n{bus}  {audioAdapter.GetVolume(bus):P0}\n"
                    + "D-pad / arrows: choose and adjust    Start / Esc: close";
            }
            else
                status.text = $"{label}  ·  {(driving ? "Driving" : "On foot")}\n"
                    + "Left stick / WASD: move    Right stick / right mouse: look\n"
                    + "Y / R: weather    X / V: vehicle    Start / Esc: audio options";
        }

        private static bool IsOneShot(AudioCue cue) =>
            cue is not (AudioCue.Engine or AudioCue.Rain or AudioCue.Wind or AudioCue.Underground or AudioCue.Club);

        private static void Finish(bool success, string evidence)
        {
            Debug.Log($"MOVING_VIOLATION_AUDIO_{(success ? "PASS" : "FAIL")} {evidence}");
            Application.Quit(success ? 0 : 4);
        }
    }
}
