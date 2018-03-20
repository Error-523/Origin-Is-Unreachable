using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pauseScript : MonoBehaviour {

    public GameObject playButton;
	
	// Update is called once per frame
	void Update () {
		if(playButton.activeInHierarchy == true)
        {
            Time.timeScale = 0f;
        }
	}
}
