using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "Player")
        {
            Debug.Log("Player Detected = attack!");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Player out of range, resume patrol");
    }
}
