using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Randomize : MonoBehaviour {

	public int RandomizeEnemy(int nbPlayer)
    {
        System.Random nb = new System.Random();
        int player = nb.Next(nbPlayer);
        return player;
    }
}
