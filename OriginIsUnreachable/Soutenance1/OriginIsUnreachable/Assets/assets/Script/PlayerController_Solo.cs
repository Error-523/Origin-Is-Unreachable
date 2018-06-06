using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController_Solo : MonoBehaviour {

    public float speed;
    public float rotateSpeed;
    public float jumpForce;
    float mouseX;
    float mouseY;
    float sensitivity = 5f;
    bool isGrounded = false;
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
        if (isGrounded)
        {
            if (Input.GetKeyDown(KeyCode.Space))
                m_rb.velocity = Vector3.up * jumpForce;
        }
        else
            m_rb.AddForce(gravity, ForceMode.Acceleration);
    }

    private void OnCollisionEnter(Collision collision)
    {
        isGrounded = true;
    }

    private void OnCollisionExit(Collision collision)
    {
        isGrounded = false;
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
