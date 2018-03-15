using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour {

    public int healthbase = 100;
    public int healthax = 100;

    public void applyDamage(int theDamage)
    {
        healthbase -= theDamage;

        if (healthbase <= 0)
            Dead();
    }

    public void Dead()
    {
        Debug.Log("player died");
    }
}
