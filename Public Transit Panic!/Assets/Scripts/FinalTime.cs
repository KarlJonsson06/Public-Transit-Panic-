using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalTime : MonoBehaviour
{
   

    public Text finalTime;

    private void FixedUpdate()
    {
      
        if (SharedVariables.win > 0)
        {
            SharedVariables.win = 0;
            DisplayTime(SharedVariables.timeValue);
        }

    }

    void DisplayTime(float timeToDisplay)
    {

        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        finalTime.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }




}
