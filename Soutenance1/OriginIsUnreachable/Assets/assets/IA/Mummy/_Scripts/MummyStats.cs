using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MummyStats : MonoBehaviour {

    public int mummyHealth = 25;

	void Oncollision (Collision col)
    {
        if (col.gameObject.tag == "hurt")
            mummyHealth -= 25;
    }
	
	// Update is called once per frame
	void Update () {
		if (mummyHealth <= 0)
        {
            GetComponent<Animator>().Play("LookInStumik");
            mummyHealth += 25;
        }
	}
}
