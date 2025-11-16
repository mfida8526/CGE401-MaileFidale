using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
    * Maile Fidale
    * Assignment 6
    * Coin target
*/
public class Target : MonoBehaviour
{
    public float health = 50f;

    public DisplayScore displayScore;

    public void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
        displayScore.score++;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
