using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

/*
 * Maile Fidale
 * Challenge 4
 * Manages score and text
*/

public class GameManager : MonoBehaviour
{
    public int currentWave = 1;
    public int maxWave = 10;

    public Text waveText;
    public Text youWinText;
    public Text youLoseText;
    public Text startText;

    private bool gameStarted = false;
    private bool gameOver = false;

    void Start()
    {
        startText.gameObject.SetActive(false);
        waveText.text = "Wave: 0";
        startText.gameObject.SetActive(true);

        Time.timeScale = 0f;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            gameStarted = true;
            startText.gameObject.SetActive(false);
            waveText.text = "Wave: " + currentWave;

            Time.timeScale = 1f;
        }

        // Restart game if over
        if (gameOver && Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    // Call this when a wave is completed
    public void NextWave()
    {
        if (!gameStarted || gameOver) return;

        currentWave++;

        if (currentWave > maxWave)
        {
            WinGame();
        }
        else
        {
            waveText.text = "Wave: " + currentWave;
        }
    }

    // Call this when the player loses
    public void LoseGame()
    {
        gameOver = true;
        youLoseText.gameObject.SetActive(true);

        Time.timeScale = 0f;
    }

    // Win condition
    void WinGame()
    {
        gameOver = true;
        youWinText.gameObject.SetActive(true);

        Time.timeScale = 0f;
    }
}
