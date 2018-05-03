using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enigma1 : MonoBehaviour {
    public bool opening = false;
    public Transform door;
    public float speed;
    public float maxOpenValue;
    private float CurrentValue = 0;
    public GameObject key;

    // Use this for initialization
    void Start()
    {
        key.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (opening)
        {
            OpenDoor();
            key.gameObject.SetActive(true);
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
            door.position = new Vector3(door.position.x, door.position.y - movement, door.position.z);
        }
    }
}
