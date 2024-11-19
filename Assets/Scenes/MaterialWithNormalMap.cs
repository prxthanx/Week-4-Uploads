using UnityEngine;

public class MaterialWithNormalMap : MonoBehaviour
{
    public Material baseMaterial;       // Drag your material here
    public Texture normalMapTexture;   // Drag your normal map texture here

    void Start()
    {
        if (baseMaterial != null && normalMapTexture != null)
        {
            // Apply the normal map to the material
            baseMaterial.SetTexture("_BumpMap", normalMapTexture);
            baseMaterial.EnableKeyword("_NORMALMAP");

            // Create a plane and assign the material
            GameObject plane = GameObject.CreatePrimitive(PrimitiveType.Plane);
            Renderer planeRenderer = plane.GetComponent<Renderer>();
            planeRenderer.material = baseMaterial;
        }
    }
}
