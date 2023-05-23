using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopPlayer : MonoBehaviour

   
{
    private void gumReset()
    {
        ChewingGum.gumStatus = 0;
    }
    void Update()
    {
        if(ChewingGum.gumStatus == 1)
        {
           GetComponent<PlayerMovement>().enabled = false;
           Invoke("gumReset", 6);
        }
        else
        {
            GetComponent<PlayerMovement>().enabled = true;
        }
    }
}
