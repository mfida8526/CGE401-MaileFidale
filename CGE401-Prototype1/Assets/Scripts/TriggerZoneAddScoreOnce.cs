using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
		 * Maile Fidale
		 * TriggerZoneAddScoreOnce
		 * Prototype 1
		 * score will add one point every time player enters trigger zone
		 */


//attach this to a trigger zone
public class TriggerZoneAddScoreOnce : MonoBehaviour
{
    private bool triggered = false;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player") && !triggered)
        {
            triggered = true;
            ScoreManager.score++;
        }
    }
}
