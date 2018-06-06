using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class final : MonoBehaviour
{
    private bool inside = false;
    private bool ok = false;
    public GameObject key;
    public GameObject door1;
    public GameObject door2;
    public float speed;
    public float maxvalue;
    public float CurrentValue;


    // Use this for initialization
    void Start ()
    {
        GameObject.FindGameObjectWithTag("Player").gameObject.GetComponent<PlayerInventory>().inventory.SetActive(true);

        key.gameObject.SetActive(false);
	}
	
	// Update is called once per frame
	void Update()
    {
        if (Input.GetKey(KeyCode.E) || ok)
        {
           if(inside)
           {
                ok = true;
                key.gameObject.SetActive(true);
                OpenDoor1();
                OpenDoor2();
                GameObject.FindGameObjectWithTag("Player").gameObject.GetComponent<PlayerInventory>().inventory.SetActive(false);
            }
                

        }	
	}

    public void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Player")
        {
            inside = true;
        }
            
    }

    //1423

    void OpenDoor1()
    {
        float movement = speed + Time.deltaTime;
        CurrentValue += movement;
        if (CurrentValue <= maxvalue)
        {
            door1.transform.position = new Vector3(door1.transform.position.x - movement, door1.transform.position.y, door1.transform.position.z);
        }
    }

    void OpenDoor2()
    {
        float movement = speed + Time.deltaTime;
        CurrentValue += movement;
        if (CurrentValue <= maxvalue)
        {
            door2.transform.position = new Vector3(door2.transform.position.x + movement, door2.transform.position.y, door2.transform.position.z);
        }
    }
}
