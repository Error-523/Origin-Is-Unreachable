using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerSolo : MonoBehaviour {

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
            lastPos = transform.position;
    }
    // Update is called once per frame
    void Update()
    {
            Vector3 deplacement = transform.position - lastPos;
            lastPos = transform.position;
            var x = Input.GetAxis("Horizontal") * Time.deltaTime * 150.0f * speed;
            var z = Input.GetAxis("Vertical") * Time.deltaTime * 150.0f * speed;

            transform.Translate(x, 0, z);
            if (deplacement.x != 0 || deplacement.z != 0 /*|| (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))*/)
            {
                if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
                {
                    Run();
                }
                else
                    GetComponent<Animator>().Play("2HWalkF");
            }
            else
            {
                if (!PlayerStats.isAttack)
                    GetComponent<Animator>().Play("2HDeathC");
                else
                    GetComponent<Animator>().Play("2HIdle");
            }
            /*if (Input.GetMouseButtonDown(0))
            {
                GetComponent<Animator>().Play("1HAttack");
            }*/
            mouseX += Input.GetAxis("Mouse X") * sensitivity;
            mouseY -= Input.GetAxis("Mouse Y") * sensitivity;
            transform.Translate(new Vector3(0f, 0f, z));
            transform.rotation = Quaternion.Euler(0, mouseX, 0);
            GetComponentInChildren<Camera>().transform.rotation = Quaternion.Euler(mouseY, mouseX, 0);
            /*if (PlayerStats.isDamage)
            {
                GetComponent<Animator>().Play("2HPain");
                PlayerStats.isDamage = false;
            }*/
        
    }

    void Run()
    {
            var x = Input.GetAxis("Horizontal") * Time.deltaTime * 150.0f * speedRun;
            var z = Input.GetAxis("Vertical") * Time.deltaTime * 150.0f * speedRun;

            transform.Translate(x, 0, z);
            GetComponent<Animator>().Play("1HCombatRunF");
    }
}
