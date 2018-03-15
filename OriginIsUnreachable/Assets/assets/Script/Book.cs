using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Book : MonoBehaviour
{
    public GameObject panel;

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    
    public void Update ()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            panel.SetActive(true);
        }
        if (Input.GetKey(KeyCode.Escape))
        {
            panel.SetActive(false);
        }
		
	}
}
