using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trap : MonoBehaviour
{
    public Animation anim;
    public float speed;
    public string anim1;

	// Use this for initialization
	void Start ()
    {
        anim[anim1].speed = speed; 
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
