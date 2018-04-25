using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mult_triggerAutoUp : MonoBehaviour {

    public bool opening = false;
    public Transform door;
    public Transform door2;
    public Transform door3;
    public Transform door4;
    public Transform door5;
    public Transform door6;
    public float speed;
    public float maxOpenValue;
    private float CurrentValue = 0;

    // Use this for initialization
    void Start ()
    {

    }
	
	// Update is called once per frame
	void Update ()
    {
        if (opening)
        {
            OpenDoor();
        }
    }

    void OnTriggerEnter(Collider obj)
    {
        if (obj.transform.tag == "Player")
        {
            opening = true;
        }
    }

    void OpenDoor()
    {
        float movement = speed + Time.deltaTime;
        CurrentValue += movement;
        if (CurrentValue <= maxOpenValue)
        {
            door.position = new Vector3(door.position.x, door.position.y + movement, door.position.z);
            door2.position = new Vector3(door2.position.x, door2.position.y + movement, door2.position.z);
            door3.position = new Vector3(door3.position.x, door3.position.y + movement, door3.position.z);
            door4.position = new Vector3(door4.position.x, door4.position.y + movement, door4.position.z);
            door5.position = new Vector3(door5.position.x, door5.position.y + movement, door5.position.z);
            door6.position = new Vector3(door6.position.x, door6.position.y + movement, door6.position.z);
        }
    }
}
