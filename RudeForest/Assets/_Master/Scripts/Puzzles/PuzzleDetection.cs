using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleDetection : MonoBehaviour
{
    public GameObject PuzzleR;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "PuzzleObject")
        {
            if (PuzzleR != null && PuzzleR.GetComponent<PuzzleObject>().ObjectRbool == true)
            {
                //Pasa informacion para abrir la puerta
            }
        }
       
        
    }
}
