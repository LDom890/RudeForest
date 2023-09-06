using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleDetectionB : MonoBehaviour
{
    public GameObject PuzzleB;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "PuzzleObject")
        {
            if (PuzzleB != null && PuzzleB.GetComponent<PuzzleObjectB>().ObjectRbool == true)
            {
                //Pasa informacion para abrir la puerta
            }
        }


    }
}
