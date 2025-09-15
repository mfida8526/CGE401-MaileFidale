using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
		 * Maile Fidale
		 * Move Forward
		 * Prototype 2
		 * game object movement
*/

public class MoveForward : MonoBehaviour
{
    public float speed = 40;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
