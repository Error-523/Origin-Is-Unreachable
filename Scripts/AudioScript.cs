using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScript : MonoBehaviour {

    public AudioSource screamer;
    public AudioClip sound;

    void OnTriggerEnter()
    {
        screamer.PlayOneShot(sound);
    }
}
