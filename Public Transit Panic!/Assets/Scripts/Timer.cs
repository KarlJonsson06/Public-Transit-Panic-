using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public Text timeText;
    private void Start()
    {
        SharedVariables.timeValue = 40;
    }
    
   

    // Update is called once per frame
    void Update()
    { 
        if (SharedVariables.timeValue > 0) 
        { 
            SharedVariables.timeValue -= Time.deltaTime; 
        }
        else
        {
            SharedVariables.timeValue = 0;
        }

        DisplayTime (SharedVariables.timeValue);
    }

    void DisplayTime(float timeToDisplay)
    {
        if (timeToDisplay < 0)
        {
            timeToDisplay = 0;
        }

        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);

    }

      
    


}
