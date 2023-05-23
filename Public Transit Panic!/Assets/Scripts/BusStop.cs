using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BusStop : MonoBehaviour


{
    

    private void Start()
    {
        SharedVariables.win = 0;
        SharedVariables.lose = 0;
    }

    //if touching Bus Stop, win.
    private void OnTriggerEnter(Collider other)
    {
        print("LevelWin");
        SharedVariables.win = 1;
    }
    private void Update()
    {
        //If win go to winMenu
        if (SharedVariables.win==1)
        {
            SceneManager.LoadScene(2);
        }

        //if time runs out and not winning, lose
        if (SharedVariables.timeValue == 0 && SharedVariables.win == 0)
        {
            SharedVariables.lose = 1;
        }

        //if lose go to loseMenu
        if (SharedVariables.lose == 1)
        {
            SceneManager.LoadScene(3);
        }
        
        
    }
}
