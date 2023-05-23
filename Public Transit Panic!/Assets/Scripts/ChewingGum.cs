using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ChewingGum : MonoBehaviour

    
{
    public static float gumStatus;

    private void Start()
    {
        gumStatus = 0;
    }

    private void OnTriggerEnter(Collider other)
    {
        gumStatus = 1;
    }

    private void OnTriggerExit(Collider other)
    {
        gumStatus = 0;
    }


 

}
