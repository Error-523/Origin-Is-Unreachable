using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cheatcode : MonoBehaviour
{
    public int x1;
    public int y1;
    public int z1;
    public int x2;
    public int y2;
    public int z2;
    public int x3;
    public int y3;
    public int z3;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKey(KeyCode.F1))
        {
            Vector3 spawnposition = new Vector3(x1, y1, z1);
        }

        if (Input.GetKey(KeyCode.F2))
        {
            Vector3 spawnposition = new Vector3(x2, y2, z2);
        }

        if (Input.GetKey(KeyCode.F3))
        {
            Vector3 spawnposition = new Vector3(x3, y3, z3);
        }

    }
}
