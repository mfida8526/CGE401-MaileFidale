using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*
 * Maile Fidale
 * Prototype 4
 * Manages score and text
*/

public class GameManager : MonoBehaviour
{
    public GameObject youLoseText;
    public GameObject youWinText;
    public GameObject startText;

    public bool isGameOver = false;

    void Start()
    {
        startText.SetActive(true);
        youLoseText.SetActive(false);
        youWinText.SetActive(false);
        Time.timeScale = 0f;
    }

    void Update()
    {
        // Wait for SPACE to start game
        if (Input.GetKeyDown(KeyCode.Space))
        {

            startText.SetActive(false);
            Time.timeScale = 1f;
        }

        if (isGameOver && Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    public void EndGame()
    {
        if (isGameOver) return;

        isGameOver = true;
        youLoseText.SetActive(true);
        Time.timeScale = 0f;
    }

    public void WinGame()
    {
        if (isGameOver) return;

        isGameOver = true;
        youWinText.SetActive(true);
        Time.timeScale = 0f;
    }
}
