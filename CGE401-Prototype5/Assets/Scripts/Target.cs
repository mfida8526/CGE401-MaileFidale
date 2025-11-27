using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    private Rigidbody targetRb;
    private float minSpeed = 12;
    private float maxSpeed = 16;
    private float maxTorque = 10;
    private float xRange = 4;
    private float ySpawnPos = -6;

    // Start is called before the first frame update
    void Start()
    {
        targetRb = GetComponent<Rigidbody>();

        //add a force upwards mutliplied by a randomized speed
        targetRb.AddForce(RandomForce(), ForceMode.Impulse);

        //add a torque force with a randomized xyz values
        targetRb.AddTorque(RandomTorque(), RandomTorque(), RandomTorque(), ForceMode.Impulse);

        //add the position with a randomized X value
        transform.position = RandomSpawnPos();
    }

    private Vector3 RandomSpawnPos()
    {
        return new Vector3(Random.Range(-xRange, xRange), ySpawnPos);
    }

    private float RandomTorque()
    {
        return Random.Range(- maxTorque, maxTorque);
    }

    private Vector3 RandomForce()
    {
        return Vector3.up * Random.Range(minSpeed, maxSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
