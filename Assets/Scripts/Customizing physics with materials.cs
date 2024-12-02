using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsMaterialHandler : MonoBehaviour
{
    public PhysicMaterial material;

    void Start()
    {
        Collider collider = GetComponent<Collider>();
        if (collider != null)
        {
            collider.material = material;
        }
    }
}

