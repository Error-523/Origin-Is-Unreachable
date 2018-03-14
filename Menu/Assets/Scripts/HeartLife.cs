using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class HeartLife : MonoBehaviour {

    public int life;
    public GameObject heartRed1;
    public GameObject heartRed2;
    public GameObject heartRed3;
    // Use this for initialization
    void Start () {
		if (/*isLocalPlayer &&*/ false)
        {
            life = 3;
        }
	}
	
	// Update is called once per frame
	void Update () {
        if (/*isLocalPlayer &&*/ life == 2 )
        {
            heartRed3.SetActive(false);
        }
        if (/*isLocalPlayer &&*/ life == 1)
        {
            heartRed2.SetActive(false);
        }
        if (/*isLocalPlayer &&*/ life == 0)
        {
            heartRed1.SetActive(false);
        }
    }
}
