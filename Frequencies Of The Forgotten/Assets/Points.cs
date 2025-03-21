using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points : MonoBehaviour
{
    public Transform[] PointList;

    // Start is called before the first frame update
    void Start()
    {
        PointList = GetComponentsInChildren<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
