using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetupRigidbody : MonoBehaviour
{
    void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.collisionDetectionMode = CollisionDetectionMode.Continuous;
        }
    }
}
