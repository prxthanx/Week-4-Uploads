using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialSetup : MonoBehaviour
{
    public Material customMaterial; // Drag a material from the Assets into this field in the Inspector

    void Start()
    {
        // Create a cube and apply the custom material
        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.transform.position = new Vector3(0, 1, 0);
        Renderer cubeRenderer = cube.GetComponent<Renderer>();
        cubeRenderer.material = customMaterial;

        // Configure the material for realism
        cubeRenderer.material.SetFloat("_Glossiness", 0.7f); // Smoothness
        cubeRenderer.material.SetFloat("_Metallic", 0.5f);   // Metallic property
    }
}
