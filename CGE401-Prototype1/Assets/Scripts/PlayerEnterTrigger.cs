using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
		 * Maile Fidale
		 * Player Enter Trigger
		 * Prototype 1
		 * checks if player neters trigger zone
		 */


//attach this to the player
public class PlayerEnterTrigger : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("TriggerZone"))
        {
            ScoreManager.score++;
        }
    }
   
}
