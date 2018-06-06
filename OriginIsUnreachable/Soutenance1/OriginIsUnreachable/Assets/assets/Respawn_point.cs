using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn_point : MonoBehaviour {

    public int x;
    public int y;
    public int z;

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
            other.transform.position = new Vector3(x, y, z);
        }
    }
}
