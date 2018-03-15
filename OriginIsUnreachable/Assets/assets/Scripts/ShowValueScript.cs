using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowValueScript : MonoBehaviour {

    Text value;
    // Use this for initialization
    void Start () {
        value = GetComponent<Text>();
	}
	
	// Update is called once per frame
	public void textUpdate (float ShowValue) {
        float vall = ShowValue + 80f;
        value.text = vall + " %";
	}
}
