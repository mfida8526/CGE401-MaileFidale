using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
		 * Maile Fidale
		 * Lose On Fall
		 * Prototype 1
		 * player will lose game if they fall off road
		 */


//attach this script to the player

public class LoseOnFall : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < -1)
        {
            ScoreManager.gameOver = true;
        }
    }
}
