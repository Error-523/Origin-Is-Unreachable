using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioSettings : MonoBehaviour
{

    public AudioMixer audioMasterMixer;

    public void SetMasterVolume(float volume)
    {
        audioMasterMixer.SetFloat("volume", volume);
    }

    public void SetMusicVolume(float volume)
    {
        audioMasterMixer.SetFloat("MusicVal", volume);
    }

    public void SetEffectsVolume(float volume)
    {
        audioMasterMixer.SetFloat("EffectsVal", volume);
    }
    
}
