using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleDetectionG : MonoBehaviour
{
    public GameObject PuzzleG;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "PuzzleObject")
        {
            if (PuzzleG != null && PuzzleG.GetComponent<PuzzleObjectG>().ObjectRbool == true)
            {
                //Pasa informacion para abrir la puerta
            }
        }


    }
}
