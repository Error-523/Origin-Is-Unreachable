using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{

    public float speed;
    public float rotateSpeed;
    public float mouseX;
    public float mouseY;
    float sensitivity = 5f;

    // Update is called once per frame
    void Update()
    {
        var x = Input.GetAxis("Horizontal") * Time.deltaTime * 150.0f * speed;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * 150.0f * speed;

        //transform.Rotate (0, x, 0);
        transform.Translate(x, 0, z);

        mouseX += Input.GetAxis("Mouse X") * sensitivity;
        mouseY -= Input.GetAxis("Mouse Y") * sensitivity;
        transform.Translate(new Vector3(0f, 0f, z));
        transform.rotation = Quaternion.Euler(0, mouseX, 0);
        GetComponentInChildren<Camera>().transform.rotation = Quaternion.Euler(mouseY, mouseX, 0);
    }
}
