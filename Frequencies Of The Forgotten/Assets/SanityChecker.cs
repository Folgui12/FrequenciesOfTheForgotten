using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SanityChecker : MonoBehaviour
{   
    public GameObject[] Rooms;

    // Start is called before the first frame update
    void Start()
    {
        Rooms = GameObject.FindGameObjectsWithTag("Room");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void StatusCheck(float status)
    {
        if (status <= 10 && status > 5)
        {
            ChangeObjectsInRooms();
        }
            
        else if (status <= 5 && status > 0)
        {
            ChangeFurnitureInRooms();
        }
            
        else
            Debug.Log("Change Entire Room");
    }

    private void ChangeObjectsInRooms()
    {
        foreach (GameObject room in Rooms)
        {
            room.GetComponent<ShoudChange>().ChangeObjects();
        }
    }

    private void ChangeFurnitureInRooms()
    {
        foreach (GameObject room in Rooms)
        {
            room.GetComponent<ShoudChange>().ChangeFurniture();
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            PlayerMindStatus pjMindStatus = other.gameObject.GetComponent<PlayerMindStatus>();

            StatusCheck(pjMindStatus.sanity);
        }
    }
}
