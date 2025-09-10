using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//attach to food projectil prefab
public class DetectCollisions : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        Destroy(gameObject);
    }
}
