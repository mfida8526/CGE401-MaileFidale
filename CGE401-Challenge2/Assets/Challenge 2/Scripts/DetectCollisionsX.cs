using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
		 * Maile Fidale
		 * DetectCollisionsX
		 * Challenge 2
		 * detects collisions of ball and dog to add score
*/

public class DetectCollisionsX : MonoBehaviour
{
    private DisplayScore displayScoreScript;

    private void Start()
    {
        displayScoreScript = GameObject.FindGameObjectWithTag("DisplayScoreText").GetComponent<DisplayScore>();
    }
    private void OnTriggerEnter(Collider other)
    {
        displayScoreScript.score++;
        //Destroy(other.gameObject);
        Destroy(gameObject);
    }
}
