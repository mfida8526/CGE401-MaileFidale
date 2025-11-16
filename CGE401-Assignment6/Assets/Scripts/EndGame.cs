using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*
    * Maile Fidale
    * Assignment 6
    * Game over requirements
*/

public class EndGame : MonoBehaviour
{
    public DisplayScore displayScore;       // Assign in Inspector or find at runtime
    public int requiredScore = 10;          // Number of gems to collect
    public GameObject gameOverText;         // Assign your Game Over UI GameObject here

    private bool gameOver = false;

    void Start()
    {
        // Hide game over text at start
        if (gameOverText != null)
            gameOverText.SetActive(false);

        if (displayScore == null)
            displayScore = FindObjectOfType<DisplayScore>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!gameOver && other.CompareTag("Player"))
        {
            if (displayScore.score >= requiredScore)
            {
                GameOver();
            }
            else
            {
                Debug.Log("Collect all gems before finishing!");
            }
        }
    }

    void Update()
    {
        if (gameOver && Input.GetKeyDown(KeyCode.R))
        {
            RestartLevel();
        }
    }

    void GameOver()
    {
        gameOver = true;

        // Show game over text
        if (gameOverText != null)
            gameOverText.SetActive(true);

        // Optional: disable player movement here if you want
        Debug.Log("You Win! Press R to Restart.");
    }

    void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
