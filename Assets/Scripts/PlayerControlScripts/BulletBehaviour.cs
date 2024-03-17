using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour
{ 
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Target"))
        { 
            Destroy(gameObject);
        }
    }
}

  