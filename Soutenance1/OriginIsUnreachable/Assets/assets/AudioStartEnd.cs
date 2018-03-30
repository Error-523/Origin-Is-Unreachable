using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioStartEnd : MonoBehaviour {

    public AudioSource effect;

    public void OnCollisionEnter(Collision collision)
    {
        effect.Play();
    }
    public void OnCollisionExit(Collision collision)
    {
        effect.Stop();
    }
}
