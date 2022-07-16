using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LightManager : MonoBehaviour
{
    public Canvas backgroundCanvas;

    public InputManager inputManager;
    public Image backgroundImage;
    private Color32 tempLight;
    public Light roomLight;

    [Range(0, 255)]
    public byte intensity;

    private void Start()
    {
        intensity = 255;
        tempLight = new Color32(255, 255, 255, 255);
    }
    private void Update()
    {
        tempLight.r = intensity;
        tempLight.g = intensity;
        tempLight.b = intensity;
        roomLight.color = tempLight;
        backgroundImage.color = tempLight;
    }

}
