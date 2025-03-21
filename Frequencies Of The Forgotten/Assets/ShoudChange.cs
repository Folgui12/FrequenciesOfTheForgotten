using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShoudChange : MonoBehaviour
{
    [SerializeField] private List<Transform> Objects;
    [SerializeField] private List<Transform> Furniture;
    [SerializeField] private List<Transform> ObjectsPoints;
    [SerializeField] private List<Transform> FurniturePoints;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeObjects()
    {
        for(int i = 0; i < Objects.Count;i++)
        {
            Objects[i] = ObjectsPoints[Random.Range(0, ObjectsPoints.Count - 1)];
        }
    }

    public void ChangeFurniture()
    {
        
    }
}
