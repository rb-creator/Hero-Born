using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour
{
    public float OnscreenDelay = 3f;

    void Start()
    {
        Destroy(this.gameObject, OnscreenDelay);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
