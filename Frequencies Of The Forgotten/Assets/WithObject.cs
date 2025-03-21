using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WithObject : MonoBehaviour
{
    public GameObject nextPoint;
    public bool haveAnyObject;

    private void Start()
    {
        haveAnyObject = false;
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("RoomObject") || other.CompareTag("Furniture"))
        {
            haveAnyObject = false;
        }
    }
}
