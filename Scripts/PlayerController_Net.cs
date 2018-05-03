using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class PlayerController_Net : NetworkBehaviour {

    public float speed;
    public float runSpeed;
    private float currentSpeed;
    public float rotateSpeed;
    public float mouseX;
    public float mouseY;
    float sensitivity = 5f;
    public Behaviour[] compToDisable;

    public Rigidbody rigidbody;


    private void Start() 
    {
        // You have to set those components in Unity Editor. 
        // You have to disable the audio listener, the camera, and the controller script.
        if (!isLocalPlayer)
        {
            foreach (var item in compToDisable)
            {
                item.enabled = false;
            }
            Destroy(this);
            return;
        }
        // Components that need to be disable if isLocalPlayer
        else
        {
            UpdateCamera();
            if (Camera.main != null)
            {
                Camera.main.gameObject.SetActive(false);
            }
        }
        
    }

    void FixedUpdate ()
    {
        if (rigidbody.velocity == Vector3.zero)
            GetComponent<Animator>().Play("2HIdle");
        if (Camera.main != null)
        {
            Camera.main.gameObject.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.RightShift) || Input.GetKeyDown(KeyCode.LeftShift))
            currentSpeed = runSpeed;
        else
            currentSpeed = speed;
        var x = Input.GetAxis("Horizontal") * Time.deltaTime * 5.0f * currentSpeed;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * 5.0f * currentSpeed;

        
        transform.Translate(x, 0, z);
        if (currentSpeed == runSpeed)
            GetComponent<Animator>().Play("1HCombatRunF");
        else
            GetComponent<Animator>().Play("2HWalkF");
        mouseX += Input.GetAxis("Mouse X") * sensitivity;
        transform.rotation = Quaternion.Euler(0, mouseX, 0);
        UpdateCamera();
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
        if(Camera.main !=null )
            Camera.main.gameObject.SetActive(true); ;
    }
}
