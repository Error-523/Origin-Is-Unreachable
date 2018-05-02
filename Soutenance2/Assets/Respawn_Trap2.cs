using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn_Trap2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            other.transform.position = new Vector3(-4292, 244, -1567);
        }

    }
}
