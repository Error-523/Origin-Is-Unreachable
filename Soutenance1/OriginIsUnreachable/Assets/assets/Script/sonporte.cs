using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sonporte : MonoBehaviour
{
    public AudioSource MusicSource;
    public AudioClip MusicClip;
    private bool inside = false;

	// Use this for initialization
	void Start ()
    {
        MusicSource.clip = MusicClip;
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (inside)
        {
            if(Input.GetKey(KeyCode.E))
                MusicSource.Play();
        }
		
	}

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
            inside = true;
    }
}
