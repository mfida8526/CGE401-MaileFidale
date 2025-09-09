using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
		 * Maile Fidale
		 * Spin Propeller X
		 * Challenge 1
		 * spins plane's propeller
*/

public class SpinPropellerX : MonoBehaviour
{
    public float rotationSpeed = 2000f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f,0f,rotationSpeed * Time.deltaTime, Space.Self);
    }
}
