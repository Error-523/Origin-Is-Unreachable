using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class PlayerController_Solo : MonoBehaviour
{

    public float speed;
    public float rotateSpeed;
    public float playerHeight = 0;
    public Canvas PauseMenu;
    public GameObject inventory;
    public GameObject hearts;
    float mouseX;
    float mouseY;
    float sensitivity = 5f;
    public Behaviour[] compToDisable;


    private void Start()
    {
        // You have to set those components in Unity Editor. 
        // You have to disable the audio listener, the camera, and the controller script.
        /*if (!isLocalPlayer)
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
            UpdateCamera(); */
            if (Camera.main != null)
            {
                Camera.main.gameObject.SetActive(false);
            }
        

    }

    private void Update()
    {
        bool isActive = PauseMenu.gameObject.activeInHierarchy;
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PauseMenu.gameObject.SetActive(!isActive);
            inventory.SetActive(isActive);
            hearts.SetActive(isActive);
        }

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
    }

    void UpdateCamera()
    {

        mouseX += Input.GetAxis("Mouse X") * sensitivity;
        mouseY -= Input.GetAxis("Mouse Y") * sensitivity;
        //GetComponentInChildren<Camera>().transform.position = transform.position;// + new Vector3(0,playerHeight,0);
        GetComponentInChildren<Camera>().transform.rotation = Quaternion.Euler(mouseY, mouseX, 0);
    }

    private void OnDisable()
    {
        if (Camera.main != null)
            Camera.main.gameObject.SetActive(true); ;
    }
}
