using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
* Maile Fidale
* TriggerZoneAddScore
* Prototype 3
* adds 1 to score when player collides with trigger zone
*/

public class TriggerZoneAddScore : MonoBehaviour
{
    private UIManager uIManager;

    private bool triggered = false;
    // Start is called before the first frame update
    void Start()
    {
        uIManager = GameObject.FindObjectOfType<UIManager>(); 
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !triggered)
        {
            triggered = true;
            uIManager.score++;
        }
    }
}
