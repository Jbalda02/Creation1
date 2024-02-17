using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Net;
using UnityEngine;
using UnityEngine.VFX;

public class TargetBehaviour:MonoBehaviour
{
    public float speed;
    private Vector3 spawn;
    public float distance;
    public Vector3 direction;
    private Vector3 endpoint; 
    private void Start()
    {
        spawn = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        endpoint = spawn + (direction * distance);
    }

     void Update()
    {
        if (transform.position.x <= endpoint.x)
        {
            transform.Translate(direction * (speed * Time.deltaTime));
        }
        if (transform.position.x > endpoint.x)
        {
            transform.localPosition = spawn;
        }
    }
     
}
