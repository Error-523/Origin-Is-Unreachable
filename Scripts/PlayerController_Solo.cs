using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController_Solo : MonoBehaviour {

    public float speed;
    public float rotateSpeed;
    public float jumpForce;
    public float FloorPos;
    float mouseX;
    float mouseY;
    float sensitivity = 5f;
    public Behaviour[] compToDisable;

    public float gravityScale = 1.0f;

    // Global Gravity doesn't appear in the inspector. Modify it here in the code
    // (or via scripting) to define a different default gravity for all objects.

    public static float globalGravity = -9.81f;

    Rigidbody m_rb;


    private void Start()
    {

        // You have to set those components in Unity Editor. 
        // You have to disable the audio listener, the camera, and the controller script.
       
            UpdateCamera();
            if (Camera.main != null)
            {
                Camera.main.gameObject.SetActive(false);
            }
            m_rb = GetComponent<Rigidbody>();
        

    }

    void FixedUpdate()
    {
        if (Camera.main != null)
        {
            Camera.main.gameObject.SetActive(false);
        }

        var x = Input.GetAxis("Horizontal") * Time.deltaTime * 5.0f * speed;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * 5.0f * speed;


        transform.Translate(x, 0, z);

        mouseX += Input.GetAxis("Mouse X") * sensitivity;
        transform.rotation = Quaternion.Euler(0, mouseX, 0);
        UpdateCamera();

        //Jump and Gravity
        m_rb = GetComponent<Rigidbody>();
        Vector3 gravity = globalGravity * gravityScale * Vector3.up;
        if (m_rb.position.y < FloorPos)
        {
            if (Input.GetKeyDown(KeyCode.Space))
                m_rb.velocity = Vector3.up * jumpForce;
        }
        else
            m_rb.AddForce(gravity, ForceMode.Acceleration);
    }

    void UpdateCamera()
    {

        mouseX += Input.GetAxis("Mouse X") * sensitivity;
        mouseY -= Input.GetAxis("Mouse Y") * sensitivity;
        GetComponentInChildren<Camera>().transform.position = transform.position;
        GetComponentInChildren<Camera>().transform.rotation = Quaternion.Euler(mouseY, mouseX, 0);
    }

    private void OnDisable()
    {
        if (Camera.main != null)
            Camera.main.gameObject.SetActive(true); ;
    }
}
