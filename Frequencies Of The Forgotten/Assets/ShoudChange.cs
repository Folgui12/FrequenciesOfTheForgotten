using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShoudChange : MonoBehaviour
{
    [SerializeField] private List<Transform> Objects;
    [SerializeField] private List<Transform> Furniture;
    [SerializeField] private List<Transform> ObjectsPoints;
    [SerializeField] private List<Transform> FurniturePoints;

    private int indexObjects;
    private int indexFurniture;

    void Start()
    {
        indexObjects = 0;
        indexFurniture = 0;
    }

    public void ChangeObjects()
    {
        for (int i = 0; i < Objects.Count;i++) 
        {
            Objects[i].position = NextAvailableObjectPoint().position;
        }

    }

    private Transform NextAvailableObjectPoint()
    {
        WithObject currentPoint = ObjectsPoints[indexObjects].GetComponent<WithObject>();

        while (currentPoint.haveAnyObject)
        {
            currentPoint = currentPoint.nextPoint.GetComponent<WithObject>(); 
        }

        currentPoint.haveAnyObject = true;

        indexObjects++;

        if(indexObjects >= ObjectsPoints.Count)
            indexObjects = 0;

        return currentPoint.transform;
    }

    public void ChangeFurniture()
    {
        for (int i = 0; i < Furniture.Count;i++) 
        {
            Furniture[i].position = NextAvailableFurniturePoint().position;
        }
    }

    private Transform NextAvailableFurniturePoint()
    {
        WithObject currentPoint = FurniturePoints[indexFurniture].GetComponent<WithObject>();

        while (currentPoint.haveAnyObject)
        {
            currentPoint = currentPoint.nextPoint.GetComponent<WithObject>(); 
        }

        currentPoint.haveAnyObject = true;

        indexFurniture++;

        if(indexFurniture >= FurniturePoints.Count)
            indexFurniture = 0;

        return currentPoint.transform;
    }
}
