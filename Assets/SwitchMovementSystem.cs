using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchMovementSystem : MonoBehaviour
{

    public GameObject contMove;
    public GameObject grabMove;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Swamp"))
        {
            contMove.SetActive(false);
            grabMove.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Swamp"))
        {
            contMove.SetActive(true);
            grabMove.SetActive(false);
        }
    }
}
