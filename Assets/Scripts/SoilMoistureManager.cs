using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoilMoistureManager : MonoBehaviour
{ 
    public InputManager inputManager;

    public GameObject chFace;
    public Material yuck;
    public Material hungry;
    private void Start()
    {

    }
    private void Update()
    {
        if(inputManager.dirtMoisture > 200)
        {
            chFace.GetComponent<MeshRenderer>().material = yuck;
        }
        else if(inputManager.dirtMoisture < 50)
        {
            chFace.GetComponent<MeshRenderer>().material = hungry;
        }
    }
    //멀리 있을 때는 다 자고 있는데
    //가까이 오면 180도 도는
}
