using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomsOrganizer : MonoBehaviour
{
    public RoomsOrganizer Instance;
    public Dictionary<int, GameObject> RoomsAndDoors;

    void Awake()
    {
        if(Instance == null)
            Instance = this;
        else
            Destroy(this);
    }

    // Start is called before the first frame update
    void Start()
    {
        RoomsAndDoors = new();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void CollectAllRooms()
    {
        GameObject[] rooms = GameObject.FindGameObjectsWithTag("Room");

        int auxIndex = 0;

        while(auxIndex > rooms.Length)
        {
            RoomsAndDoors.Add(auxIndex, rooms[auxIndex]);

            auxIndex++;
        }
    }
}
