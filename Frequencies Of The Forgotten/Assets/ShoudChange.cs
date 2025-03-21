using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShoudChange : MonoBehaviour
{
    [SerializeField] private List<Transform> Objects;
    [SerializeField] private List<Transform> Furniture;
    [SerializeField] private List<Transform> ObjectsPoints;
    [SerializeField] private List<Transform> FurniturePoints;

    public void ChangeObjects()
    {
        for (int i = 0; i < Objects.Count;i++) 
        {
            Objects[i].position = NextAvailablePoint().position;
        }

    }

    private Transform NextAvailablePoint()
    {
        WithObject currentPoint = ObjectsPoints[0].GetComponent<WithObject>();

        while (currentPoint.haveAnyObject)
        {
            currentPoint = currentPoint.nextPoint.GetComponent<WithObject>(); 
            Debug.Log(currentPoint.haveAnyObject);

        }

        currentPoint.haveAnyObject = true;

        return currentPoint.transform;
    }

    public void ChangeFurniture()
    {
        for (int i = 0; i < Objects.Count; i++)
        {
            int rand = Random.Range(0, FurniturePoints.Count - 1);
            if (FurniturePoints[rand].gameObject.activeInHierarchy)
            {
                Objects[i].position = FurniturePoints[rand].position;
                FurniturePoints[rand].gameObject.SetActive(false);
            }
        }

        //ActivePoints(FurniturePoints);
    }
}
