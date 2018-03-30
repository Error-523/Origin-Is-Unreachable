using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class PlayerControllerSolo : NetworkBehaviour {

    Vector3 lastPos;
    public float speed;
    public float speedRun;
    public float rotateSpeed;
    public float mouseX;
    public float mouseY;
    float sensitivity = 5f;
    Rigidbody rb;

    void Start()
    {
        if (isLocalPlayer)
        {
            Cursor.visible = false;
            lastPos = transform.position;
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (isLocalPlayer)
        {
            Vector3 deplacement = transform.position - lastPos;
            lastPos = transform.position;
            var x = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
            var z = Input.GetAxis("Vertical") * Time.deltaTime * speed;

            transform.Translate(x, 0, z);
            if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
            {
                x = Input.GetAxis("Horizontal") * Time.deltaTime * speedRun;
                z = Input.GetAxis("Vertical") * Time.deltaTime * speedRun;
                transform.Translate(x, 0, z);
            }

            mouseX += Input.GetAxis("Mouse X") * sensitivity;
            mouseY -= Input.GetAxis("Mouse Y") * sensitivity;
            if (mouseY > 55)
                mouseY = 55;
            if (mouseY < -80)
                mouseY = -80;
            transform.Translate(new Vector3(0f, 0f, z));
            transform.rotation = Quaternion.Euler(0, mouseX, 0);
            GetComponentInChildren<Camera>().transform.rotation = Quaternion.Euler(mouseY, mouseX, 0);
            /*if (PlayerStats.isDamage)
            {
                GetComponent<Animator>().Play("2HPain");
                PlayerStats.isDamage = false;
            }*/
        }
    }
    
}
