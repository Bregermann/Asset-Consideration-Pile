using System;
using System.Collections.Generic;
using Sonity;
using UnityEngine;

namespace MovingViolation.Audio
{
    public enum AudioBus { Master, Music, Sfx, Voice, Ui, Ambience, Vehicles, Weather, PoliceRadio }
    public enum AudioCue
    {
        WetAsphalt, Snow, Tile, Gravel, Impact, Gunshot, Siren, Radio, Voice,
        Engine, EngineStop, Collision, Rain, Wind, Underground, Club, Menu, QuestWon, QuestLost
    }

    public interface IGameplayAudio
    {
        bool Play(AudioCue cue, Transform emitter);
        void Vehicle(Transform emitter, bool running, float rpm, float throttle, float speed);
        void Weather(Transform emitter, float rain, float wind, float snowfall);
        void Interior(Transform emitter, float enclosure, float clubAudibility);
        void Release(Transform emitter);
    }

    public sealed class SonityAudio : MonoBehaviour, IGameplayAudio
    {
        [Serializable]
        public struct Binding
        {
            public AudioCue Cue;
            public AudioBus Bus;
            public SoundEvent Event;
        }

        [SerializeField] private Binding[] bindings = Array.Empty<Binding>();
        [SerializeField] private string preferencesKey = "MovingViolation.Audio.";
        private readonly Dictionary<AudioCue, Binding> events = new();
        private readonly Dictionary<(AudioCue cue, Transform emitter), Loop> loops = new();
        private readonly float[] levels = new float[Enum.GetValues(typeof(AudioBus)).Length];

        private sealed class Loop
        {
            public AudioBus Bus;
            public SoundEvent Event;
            public float Gain;
            public readonly SoundParameterVolumeRatio Volume = new(0f, UpdateMode.Continuous);
            public readonly SoundParameterPitchRatio Pitch = new(1f, UpdateMode.Continuous);
            public readonly SoundParameterIntensity Openness = new(1f, UpdateMode.Continuous);
            public readonly SoundParameterReverbZoneMixRatio Reverb = new(0f, UpdateMode.Continuous);
        }

        private void Awake() => Configure(bindings, preferencesKey);

        public void Configure(Binding[] catalog, string preferencePrefix)
        {
            StopLoops(null);
            preferencesKey = preferencePrefix;
            events.Clear();
            foreach (var binding in catalog)
                if (binding.Event)
                    events.Add(binding.Cue, binding);
            for (var i = 0; i < levels.Length; i++)
                levels[i] = Mathf.Clamp01(PlayerPrefs.GetFloat(preferencesKey + (AudioBus)i, 1f));
        }

        public float GetVolume(AudioBus bus) => levels[(int)bus];

        public void SetVolume(AudioBus bus, float value)
        {
            levels[(int)bus] = Mathf.Clamp01(value);
            PlayerPrefs.SetFloat(preferencesKey + bus, GetVolume(bus));
            PlayerPrefs.Save();
            foreach (var loop in loops.Values)
                loop.Volume.VolumeRatio = loop.Gain * BusGain(loop.Bus);
        }

        private float BusGain(AudioBus bus) =>
            GetVolume(AudioBus.Master) * (bus == AudioBus.Master ? 1f : GetVolume(bus));

        public bool Play(AudioCue cue, Transform emitter)
        {
            if (!isActiveAndEnabled || !emitter || !SoundManager.Instance ||
                !events.TryGetValue(cue, out var binding))
                return false;
            binding.Event.Play(emitter, new SoundParameterVolumeRatio(BusGain(binding.Bus)));
            return true;
        }

        public void Vehicle(Transform emitter, bool running, float rpm, float throttle, float speed)
        {
            if (!running)
            {
                if (StopLoop((AudioCue.Engine, emitter)))
                    Play(AudioCue.EngineStop, emitter);
                return;
            }
            SetLoop(AudioCue.Engine, emitter, 0.22f + 0.55f * Mathf.Clamp01(throttle)
                + 0.16f * Mathf.Clamp01(speed), 0.65f + 1.3f * Mathf.Clamp01(rpm), 1f, 0f);
        }

        public void Weather(Transform emitter, float rain, float wind, float snowfall)
        {
            var openness = 1f - 0.75f * Mathf.Clamp01(snowfall);
            SetLoop(AudioCue.Rain, emitter, Mathf.Clamp01(rain), 1f, openness, 0f);
            SetLoop(AudioCue.Wind, emitter, Mathf.Clamp01(wind), 1f, openness, 0f);
        }

        public void Interior(Transform emitter, float enclosure, float clubAudibility)
        {
            enclosure = Mathf.Clamp01(enclosure);
            var club = Mathf.Clamp01(clubAudibility);
            SetLoop(AudioCue.Underground, emitter, enclosure, 1f, 1f - enclosure * 0.6f, enclosure);
            SetLoop(AudioCue.Club, emitter, club, 1f, club, 0.4f * enclosure);
        }

        private void SetLoop(AudioCue cue, Transform emitter, float gain, float pitch, float openness, float reverb)
        {
            if (!isActiveAndEnabled || !emitter || !SoundManager.Instance ||
                !events.TryGetValue(cue, out var binding))
                return;
            var key = (cue, emitter);
            if (gain <= 0.001f)
            {
                StopLoop(key);
                return;
            }

            var start = !loops.TryGetValue(key, out var loop);
            if (start)
            {
                loop = new Loop { Bus = binding.Bus, Event = binding.Event };
                loops.Add(key, loop);
            }
            loop.Gain = gain;
            loop.Volume.VolumeRatio = gain * BusGain(loop.Bus);
            loop.Pitch.PitchRatio = pitch;
            loop.Openness.Intensity = openness;
            loop.Reverb.ReverbZoneMixRatio = reverb;
            if (start)
                loop.Event.Play(emitter, loop.Volume, loop.Pitch, loop.Openness, loop.Reverb);
        }

        private bool StopLoop((AudioCue cue, Transform emitter) key)
        {
            if (!loops.Remove(key, out var loop))
                return false;
            if (key.emitter && loop.Event)
                loop.Event.Stop(key.emitter);
            return true;
        }

        public void Release(Transform emitter)
        {
            if (!ReferenceEquals(emitter, null))
                StopLoops(emitter);
        }

        private void StopLoops(Transform emitter)
        {
            foreach (var key in new List<(AudioCue cue, Transform emitter)>(loops.Keys))
                if (ReferenceEquals(emitter, null) || key.emitter == emitter)
                    StopLoop(key);
        }

        private void OnDisable() => StopLoops(null);
    }
}
