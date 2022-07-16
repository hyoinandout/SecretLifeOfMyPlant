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
        intensity = (byte)inputManager.light;
        tempLight.r = intensity;
        tempLight.g = intensity;
        tempLight.b = intensity;
        roomLight.color = tempLight;
        backgroundImage.color = tempLight;
    }
    // 조도에 따라서 표정 변화도 있음.
    // 이마에 해 붙이고 있는 애가 일정 조도 이하로 내려가면 우울해진다.
}
