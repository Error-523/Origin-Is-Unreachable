using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class PlayerController : MonoBehaviour {

    public float vitesse;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

        //if (!isLocalPlayer)
        //    return;

        var x = Input.GetAxis("Horizontal") * Time.deltaTime * 1.5f * vitesse;
        var z = Input.GetAxis("Vertical") *  Time.deltaTime * vitesse;

        transform.Translate(0, 0, z);
        transform.Rotate(0,x,0);
	}
}
