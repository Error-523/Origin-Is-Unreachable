using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float speed = 25.0f;
    public float rotationSpeed = 75.0f;

    Rigidbody rb;

    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void Update()
    {
        float z = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        float x = Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime;
        transform.Rotate(0, x, 0);
        transform.Translate(0, 0, z);
        Quaternion turn = Quaternion.Euler(0f, x, 0f);
        rb.MoveRotation(rb.rotation * turn);
    }
}
