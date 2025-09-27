using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText;
    public Text gameOverText;
    public int score = 0;

    public PlayerControllerX playerControllerXScript;

    public bool won = false;

    // Start is called before the first frame update
    void Start()
    {
        if (scoreText == null)
        {
            scoreText = FindObjectOfType<Text>();
        }
        if (playerControllerXScript == null)
        {
            playerControllerXScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerControllerX>();
        }

        scoreText.text = "Score: 0";
    }

    // Update is called once per frame
    void Update()
    {
        //display score until game is over
        if (!playerControllerXScript.gameOver)
        {
            scoreText.text = "Score: " + score;
        }

        //win condition: 10 points
        if (score >= 10)
        {
            playerControllerXScript.gameOver = true;
            won = true;

            //stop player running


            scoreText.text = "You Win! \nPress R to Try Again!";
        }

        if (playerControllerXScript.gameOver)
        {
            gameOverText.gameObject.SetActive(true);
        }

        if (playerControllerXScript.gameOver && Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    public void AddScore(int points)
    {
        score += points;
    }
}
