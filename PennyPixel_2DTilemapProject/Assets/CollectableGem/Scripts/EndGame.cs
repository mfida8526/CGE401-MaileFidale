using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    public DisplayScore displayScore;       // Assign in Inspector or find at runtime
    public int requiredScore = 10;          // Number of gems to collect
    public GameObject gameOverText;         // Assign your Game Over UI GameObject here

    private bool gameOver = false;

    void Start()
    {
        gameOver = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Collided with: " + collision.name);

        if (!gameOver && collision.CompareTag("Player"))
        {
            Debug.Log("Player entered end zone, score: " + displayScore.score);

            if (displayScore.score >= requiredScore)
            {
                gameOver = true;
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

    void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
