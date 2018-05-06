using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class DealDamage_Net : NetworkBehaviour
{

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            PlayerStats_Net health = collision.gameObject.GetComponent<PlayerStats_Net>();
            if (health != null)
                health.TakeDamage(1);
        }
    }
}

