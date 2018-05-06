using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trap_move : MonoBehaviour
{
    public float speed = 10f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.Translate(new Vector3(1, 1, 0) * speed * Time.deltaTime);
	}
}
