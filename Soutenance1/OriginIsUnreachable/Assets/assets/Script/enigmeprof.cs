using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class enigmeprof : MonoBehaviour
{
    public Text Welcome;
    public Text Q1;
    public Text Q2;
    public Text Q3;
    public Text Q4;
    public Text last;
    public GameObject key;
    public bool ishere;
    public bool bool1 = false;
    public bool bool2 = false;
    public bool bool3 = false;
    public bool bool4 = false;
    public bool bool5 = true;

    // Use this for initialization
    void Start ()
    {
        key.gameObject.SetActive(false);
	}
	
	// Update is called once per frame
	void Update ()
    {
        if(ishere)
        {
            if (Input.GetKey(KeyCode.E) && bool5)
            {
                Welcome.enabled = false;
                Q1.enabled = true;
                bool1 = true;
            }
            if (Input.GetKey(KeyCode.Alpha3) && bool1)
            {
                Q1.enabled = false;
                Q2.enabled = true;
                bool1 = false;
                bool2 = true;
            }
            if (Input.GetKey(KeyCode.Alpha2) && bool2)
            {
                Q2.enabled = false;
                Q3.enabled = true;
                bool2 = false;
                bool3 = true;

            }
            if(Input.GetKey(KeyCode.Alpha1) && bool3)
            {
                Q3.enabled = false;
                Q4.enabled = true;
                bool3 = false;
                bool4 = true;
            }
            if(Input.GetKey(KeyCode.Alpha4)  && bool4)
            {
                key.gameObject.SetActive(true);
                Q4.enabled = false;
                last.enabled = true;
                bool4 = false;
                bool5 = false;
                
            }
        }
        else
        {
            Welcome.enabled = false;
            Q1.enabled = false;
            Q2.enabled = false;
            Q3.enabled = false;
            Q4.enabled = false;
            last.enabled = false;
        }
		
	}


    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            ishere = true;
            Welcome.GetComponent<Text>().enabled = true;
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            ishere = false;
            Welcome.GetComponent<Text>().enabled = false;
        }
    }
}
