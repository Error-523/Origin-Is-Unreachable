using UnityEngine;
using UnityEngine.Networking;


public class PlayerController : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform bulletSpawn;
    public float speed;
    public float rotateSpeed;

    void Update()
    {
        var x = Input.GetAxis("Horizontal") * Time.deltaTime * 150.0f * speed;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * 150.0f * speed;

        //transform.Rotate (0, x, 0);
        transform.Translate (x, 0, z);

        var mouseX = Input.GetAxis("Mouse X") * rotateSpeed * Time.deltaTime;
        var mouseY = Input.GetAxis("Mouse Y") * rotateSpeed * Time.deltaTime;
        GetComponentInChildren<Camera>().transform.Rotate(mouseY, mouseX, 0);
    }
}
