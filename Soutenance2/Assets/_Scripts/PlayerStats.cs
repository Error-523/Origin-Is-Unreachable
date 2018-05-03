using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStats: MonoBehaviour
{

    public int InitialHealth;
    public int currentHealth;
    Text infoText;
    public Image heart1;
    public Image heart2;
    public Image heart3;
    public Image heart1full;
    public Image heart2full;
    public Image heart3full;

    

    void Start()
    {
        currentHealth = InitialHealth;

    }

    public void TakeDamage(int amountDamage)
    {

        if (currentHealth <= 0)
            return;
        currentHealth -= amountDamage;
        Debug.Log("Took " + amountDamage);

        if (currentHealth <= 0)
        {
            currentHealth = 0;

            Dead();

            return;
        }
    }

    private void Update()
    {
        
        switch (currentHealth)
        {
            case 1:
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(false);
                heart3.gameObject.SetActive(false);
                heart1full.gameObject.SetActive(false);
                heart2full.gameObject.SetActive(false);
                heart3full.gameObject.SetActive(false);
                break;
            case 2:
                heart1.gameObject.SetActive(false);
                heart2.gameObject.SetActive(false);
                heart3.gameObject.SetActive(false);
                heart1full.gameObject.SetActive(true);
                heart2full.gameObject.SetActive(false);
                heart3full.gameObject.SetActive(false);
                break;
            case 3:
                heart1.gameObject.SetActive(false);
                heart2.gameObject.SetActive(true);
                heart3.gameObject.SetActive(false);
                heart1full.gameObject.SetActive(true);
                heart2full.gameObject.SetActive(false);
                heart3full.gameObject.SetActive(false);
                break;
            case 4:
                heart1.gameObject.SetActive(false);
                heart2.gameObject.SetActive(false);
                heart3.gameObject.SetActive(false);
                heart1full.gameObject.SetActive(true);
                heart2full.gameObject.SetActive(true);
                heart3full.gameObject.SetActive(false);
                break;
            case 5:
                heart1.gameObject.SetActive(false);
                heart2.gameObject.SetActive(false);
                heart3.gameObject.SetActive(true);
                heart1full.gameObject.SetActive(true);
                heart2full.gameObject.SetActive(true);
                heart3full.gameObject.SetActive(false);
                break;
            case 6:
                heart1.gameObject.SetActive(false);
                heart2.gameObject.SetActive(false);
                heart3.gameObject.SetActive(false);
                heart1full.gameObject.SetActive(true);
                heart2full.gameObject.SetActive(true);
                heart3full.gameObject.SetActive(true);
                break;
            default:
                break;
        }
    }

    
    void Dead()
    {
            infoText = GameObject.FindObjectOfType<Text>();
            infoText.text = "Game Over!\nYou died!";
            GameObject player = GameObject.FindGameObjectWithTag("Player");
            //Destroy(player);
    }
    
}