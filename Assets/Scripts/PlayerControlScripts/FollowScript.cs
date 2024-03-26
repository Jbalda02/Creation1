using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowScript : MonoBehaviour

{
    [SerializeField] private GameObject target;

    [SerializeField] private bool x;
    [SerializeField] private bool z;
    [SerializeField] private bool y;
    private Vector3 LastPosition;
    private void Start()
    {
        LastPosition = gameObject.transform.transform.position ;
    }

    void Update()
    {
        if (x)
        {
            LastPosition.x = target.GetComponent<Transform>().position.x;
        }

        if (y)
        {
            LastPosition.y = target.GetComponent<Transform>().position.y;
        }

        if (z)
        {
            LastPosition.z = target.GetComponent<Transform>().position.z;
        }

        gameObject.transform.position = LastPosition;
        {
            
        }
    }
}
