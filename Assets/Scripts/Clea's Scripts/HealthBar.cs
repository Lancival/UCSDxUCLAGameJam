using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private int health;
    [SerializeField] private int numOfHearts;

    public Image[] hearts;
    public Sprite fullHearts;
    public Sprite emptyHearts;


    private void Update()
    {

        if(health > numOfHearts)
        {
            health = numOfHearts;
        }

        if (health == 0)
        {
            SceneManager.LoadScene("GameOverScene");
            Time.timeScale = 0;
        }


        for (int i = 0; i < hearts.Length; i++)
        {
            if(i < health)
            {
                hearts[i].sprite = fullHearts;
            } else
            {
                hearts[i].sprite = emptyHearts;
            }

            if(i < numOfHearts)
            {
                hearts[i].enabled = true;
            } else
            {
                hearts[i].enabled = false;
            }
        }
    }
}