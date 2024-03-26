using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class EnemyScript : MonoBehaviour
{
    [SerializeField] private float speed;
    private Transform target;
    private Rigidbody _rigidbody;
    private void Start()
    {
        target = GameObject.FindWithTag("Player").GetComponent<Transform>();
        _rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Vector3 position = Vector3.MoveTowards(transform.position, target.position,speed * Time.deltaTime);
        _rigidbody.MovePosition(position);
        transform.LookAt(target);
    }
}
