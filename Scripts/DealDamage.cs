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
                health.TakeDamage(1);
        }
    }
}
