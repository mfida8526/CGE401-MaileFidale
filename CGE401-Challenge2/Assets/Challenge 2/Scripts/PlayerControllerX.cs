using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
		 * Maile Fidale
		 * PlayerControllerX
		 * Challenge 2
		 * player presses space key to spawn dog, cooldown time to prevent spamming of key
*/


public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    public float spawnCooldown = 2f;  // cooldown time in seconds

    private bool canSpawn = true;     // can spawn initially

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && canSpawn)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);

            StartCoroutine(SpawnCooldownRoutine());
        }
    }

    IEnumerator SpawnCooldownRoutine()
    {
        canSpawn = false;                  // prevent spawning again immediately
        yield return new WaitForSeconds(spawnCooldown);  // wait cooldown time
        canSpawn = true;                   // allow spawning again
    }
}
