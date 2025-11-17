using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject youLoseText;
    public GameObject youWinText;

    public bool isGameOver = false;

    void Start()
    {
        youLoseText.SetActive(false);
        youWinText.SetActive(false);
        Time.timeScale = 1f;
    }

    void Update()
    {
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
