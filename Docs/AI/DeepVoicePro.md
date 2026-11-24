# DeepVoice Pro – Text to Voice

**S-tier priority** for editor-generated character dialogue, cinematics, narration and short-form marketing. AiKodex lists version 3.0.7 under Asset Store ID 314245. [Official product listing](https://assetstore.unity.com/packages/tools/generative-ai/deepvoice-pro-text-to-voice-314245).

| Check | Result |
| --- | --- |
| Acquisition | Studio owner confirmed ownership of Asset Store ID 314245. Download and local import are pending authenticated Unity access or the original archive. Unity CLI reported signed out and the checked local caches contained no matching archive. |
| Dependencies | The publisher requires Unity Editor Coroutines and internet access. ACP already declares and locks `com.unity.editorcoroutines` 1.1.0 from the Unity Registry. |
| Unity 6 and URP | The listing identifies Unity 6000.2.13 as the original editor and advertises URP support. Import and compile in ACP and Rowan remain untested. |
| Service access | The publisher advertises an internet-backed Editor workflow without a separate sign-up or user API key. It identifies ElevenLabs as the Multi model backend. Advertised limits are 2,500 characters per request and 150,000 per month. Quota access, provider availability, and a supported programmatic or batch interface remain unverified. |
| Commercial output | Pending written clarification for the selected voices and backends. The Asset Store listing identifies Unity's Standard Asset Store EULA for the package. It does not establish which provider terms or commercial permissions apply to WAVs generated through AiKodex's backend. ElevenLabs documents paid-plan commercial rights for direct use. Those terms alone do not establish AiKodex's downstream grant. [Unity Asset Store EULA](https://unity.com/legal/as-terms) · [ElevenLabs speech documentation](https://elevenlabs.io/docs/overview/capabilities/text-to-speech). |

## Selective retrieval

Find ID 314245 in Unity Package Manager → My Assets using a Luna Wolf Studios account with access. An authorized archive from the studio cache is also suitable. Keep the vendor package in licensed storage, preserve its paths and GUIDs, and check for an existing DeepVoice install before importing. Resolve Editor Coroutines through the Unity Registry in the destination project if absent. Start in an isolated Unity 6 URP copy matching Rowan's editor and renderer before promoting it. [AiKodex support](https://www.aikodex.com/).

## Editor workflow

The steps below follow the publisher's feature descriptions. Exact controls and output paths depend on the acquired version.

1. **Generate.** Open the DeepVoice Editor window, choose a model and voice, paste a short line of original dialogue, and generate a preview. Record the model and voice names with each approved take. Use a short neutral sample first to separate connectivity and quota failures from script or voice problems.
2. **Select an accent.** Choose a voice or accent option appropriate to the character and target language. Audition the same line across candidates, including Rowan character and place names, before locking the cast.
3. **Direct the performance.** Adjust the advertised Pro tone and pacing controls, use punctuation for pauses, and audition emotional directions where supported. A model may read a dialogue tag aloud. Trim any spoken direction from the take before export.
4. **Export and review.** Trim the take in DeepVoice, save the Pro WAV, and import it as a Unity AudioClip through the destination's usual dialogue or Timeline workflow. Name takes by character, locale, line ID and revision. Check pronunciation, clipping, silence, level and sync against the scene. Use the same WAV master for derivative short-form edits once rights are confirmed.
5. **Plan automation around approved takes.** Keep a line manifest with script revision, voice, accent, delivery settings and WAV path. Pre-render dialogue for builds and trailers. Verify a documented batch interface and provider terms before connecting unattended generation to studio pipelines.

Before releasing dialogue, trailers or paid social clips, confirm the permitted uses, attribution and any voice-specific restrictions with AiKodex for the selected backend and retain that confirmation alongside the approved takes.
