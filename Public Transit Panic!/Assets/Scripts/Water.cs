using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Water : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        print("LevelLose");
        SharedVariables.lose = 1;
    }
}
