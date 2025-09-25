//This script is based on https://www.youtube.com/watch?v=3uyolYVsiWc
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

/*
		 * Maile Fidale
		 * HealthSystem
		 * Challenge 2
		 * player loses hearts if ball goes out of bounds, wins if scores 5
*/

public class HealthSystem : MonoBehaviour
{
    public int health;
    public int maxHealth;

    public List<Image> hearts;
    public Sprite fullHeart;
    public Sprite emptyHeart;

    public bool gameOver = false;
    private bool won = false;

    public GameObject gameOverText;
    public GameObject youWinText;

    public DisplayScore displayScore;


    void Update()
    {
        //If health is somehow more than max health, set health to max health
        if (health > maxHealth)
        {
            health = maxHealth;
        }


        for (int i = 0; i < hearts.Count; i++)
        {
            //Display full or empty heart sprite based on current health
            if (i < health)
            {
                hearts[i].sprite = fullHeart;
            }
            else
            {
                hearts[i].sprite = emptyHeart;
            }

            //Show the number of hearts equal to current max health
            if (i < maxHealth)
            {
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled = false;
            }
        }

        if (health <= 0)
        {
            gameOver = true;
            gameOverText.SetActive(true);

            //Press R to restart if game is over
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }

        if (displayScore.score >= 5)
        {
            won = true;
        }

        if (won)
        {
            gameOver = true;
            youWinText.SetActive(true);

            //if the game is over and they press R key on keyboard
            if (Input.GetKeyDown(KeyCode.R))
            {
                //reload the current scene
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }

    }

    public void TakeDamage()
    {
        health--;
    }

    public void AddMaxHealth()
    {
        maxHealth++;
    }


}
