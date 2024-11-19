using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmbientLightSetup : MonoBehaviour
{
    void Start()
    {
        // Set ambient light color
        RenderSettings.ambientLight = Color.gray;

        // Enable skybox-based ambient lighting
        RenderSettings.ambientMode = UnityEngine.Rendering.AmbientMode.Skybox;
    }
}
