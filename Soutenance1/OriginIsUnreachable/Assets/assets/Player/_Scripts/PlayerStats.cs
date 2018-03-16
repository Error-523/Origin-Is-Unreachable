using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class PlayerStats : NetworkBehaviour {

    public int healthbase = 3;
    public int healthax = 3;
    public static bool isAttack = true;
    public static bool isDamage = false;
    
    public void applyDamage(int theDamage)
    {
        if (isLocalPlayer)
        {
            healthbase -= theDamage;
            if (healthbase <= 0)
            {
                isAttack = false;
                Dead();
            }
            isDamage = true;
        }
    }

    public void Dead()
    {
        if (isLocalPlayer)
        {
            Debug.Log("player died");
        }
    }
}
