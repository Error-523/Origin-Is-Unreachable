using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn_Trap3 : MonoBehaviour {

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
            other.transform.position = new Vector3(10732, 53, 10327);
        }

    }

}
