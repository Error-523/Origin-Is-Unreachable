using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Book : MonoBehaviour
{
    public GameObject panel;
    public bool opening = false;

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    
    public void Update ()
    {
        if (opening)
            openmessage();

	}

    public void OnTriggerEnter(Collider obj)
    {
        if (obj.transform.tag == "Player")
        {
            opening = true;
        }
    }


    public void openmessage()
    {
        if (Input.GetKey(KeyCode.E))
        {
            panel.SetActive(true);
        }
        if (Input.GetKey(KeyCode.Escape))
        {
            panel.SetActive(false);
        }
    }
    
}
