using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerenigmefail : MonoBehaviour {

    public bool opening = false;
    public Transform door;
    //public Transform door2;
    public float speed;
    public float movement;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (opening)
        {
            door.position = new Vector3(door.position.x, door.position.y, door.position.z - movement*Time.deltaTime);
            //door2.position = new Vector3(door2.position.x, door2.position.y, door2.position.z - movement);
        }

    }

    void OnTriggerEnter(Collider obj)
    {
        if (obj.transform.tag == "Player")
        {
            opening = true;
        }
    }

}
