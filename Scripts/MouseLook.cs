using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour {

    public float speed;
    public float runSpeed;
    private float currentSpeed;
    public float rotateSpeed;
    public float mouseX;
    public float mouseY;
    float sensitivity = 5f;

    // Update is called once per frame
    void Update ()
    {
        if (rigidbody.velocity == Vector3.zero)
            GetComponent<Animator>().Play("2HIdle");
        if (Input.GetKeyDown(KeyCode.RightShift) || Input.GetKeyDown(KeyCode.LeftShift))
            currentSpeed = runSpeed;
        else
            currentSpeed = speed;
        var x = Input.GetAxis("Horizontal") * Time.deltaTime * 150.0f * currentSpeed;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * 150.0f * currentSpeed;

        //transform.Rotate (0, x, 0);
        transform.Translate(x, 0, z);
        if (currentSpeed == runSpeed)
            GetComponent<Animator>().Play("1HCombatRunF");
        else
            GetComponent<Animator>().Play("2HWalkF");
        
        mouseX += Input.GetAxis("Mouse X") * sensitivity ;
        mouseY -= Input.GetAxis("Mouse Y") * sensitivity ;
        transform.Translate(new Vector3(0f, 0f, z));
        transform.rotation = Quaternion.Euler(0, mouseX, 0);
        GetComponentInChildren<Camera>().transform.rotation = Quaternion.Euler(mouseY, mouseX, 0);
    }
}
