using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DealDamage : MonoBehaviour {
    
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            PlayerStats health = collision.gameObject.GetComponent<PlayerStats>();
            if (health != null)
            {
                Debug.Log("attack");
                health.TakeDamage(2);
            }
        }
        else if (collision.gameObject.tag == "Trap")
        {
            PlayerStats health = collision.gameObject.GetComponent<PlayerStats>();
            if (health != null)
            {
                Debug.Log("Trap");
                health.TakeDamage(1);
            }
        }
        
    }
}
