using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatsSolo : MonoBehaviour {

    public int healthbase = 3;
    public int healthax = 3;
    public static bool isAttack = true;
    public static bool isDamage = false;

    public void applyDamage(int theDamage)
    {
            healthbase -= theDamage;
            if (healthbase <= 0)
            {
                isAttack = false;
                Dead();
            }
            isDamage = true;
        
    }

    public void Dead()
    {
            Debug.Log("player died");
        
    }
}
