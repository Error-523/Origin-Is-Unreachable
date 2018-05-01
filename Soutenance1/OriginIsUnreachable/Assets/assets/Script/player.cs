using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {

    public float speed = 0.001f;

    // Use this for initialization
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        move();

    }

    void move()
    {
        if (Input.GetKey(KeyCode.Z))
            transform.position += Vector3.forward * speed;
        if (Input.GetKey(KeyCode.S))
            transform.position += Vector3.back * speed;
        if (Input.GetKey(KeyCode.Q))
            transform.position += Vector3.left * speed;
        if (Input.GetKey(KeyCode.D))
            transform.position += Vector3.right * speed;
    }

}
