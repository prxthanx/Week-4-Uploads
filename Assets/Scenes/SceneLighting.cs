using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneLighting : MonoBehaviour
{
    void Start()
    {
        // Create a Directional Light
        GameObject dirLight = new GameObject("Directional Light");
        Light dirLightComp = dirLight.AddComponent<Light>();
        dirLightComp.type = LightType.Directional;
        dirLightComp.color = Color.white;
        dirLightComp.intensity = 1.5f;
        dirLight.transform.rotation = Quaternion.Euler(50, -30, 0);

        // Enable shadows for the Directional Light
        dirLightComp.shadows = LightShadows.Soft;
        dirLightComp.shadowStrength = 0.8f;

        // Create a Point Light
        GameObject pointLight = new GameObject("Point Light");
        Light pointLightComp = pointLight.AddComponent<Light>();
        pointLightComp.type = LightType.Point;
        pointLightComp.color = Color.yellow;
        pointLightComp.range = 10;
        pointLightComp.intensity = 1.0f;
        pointLight.transform.position = new Vector3(0, 5, 0);

        // Enable shadows for the Point Light
        pointLightComp.shadows = LightShadows.Soft;

        // Create a Spotlight
        GameObject spotLight = new GameObject("Spot Light");
        Light spotLightComp = spotLight.AddComponent<Light>();
        spotLightComp.type = LightType.Spot;
        spotLightComp.color = Color.red;
        spotLightComp.range = 15;
        spotLightComp.spotAngle = 45;
        spotLightComp.intensity = 1.2f;
        spotLight.transform.position = new Vector3(2, 5, -5);
        spotLight.transform.rotation = Quaternion.Euler(45, 0, 0);

        // Enable shadows for the Spotlight
        spotLightComp.shadows = LightShadows.Hard;
    }
}
