using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class ObstacleGenerator : MonoBehaviour
{
 private int RandomCounterTimer;
 private int RandomSpawnPointSelector;
 private int Counter;
 private Rigidbody rb;

 [SerializeField] private List<GameObject> SpawnPointList;
 [SerializeField] private GameObject ObstaclePrefab;
 private void Start()
 {
  GetComponent<Rigidbody>();
  RandomCounterTimer = Random.Range(0, 400);
 }

 void Update() {
  if (RandomCounterTimer < Counter)
  {
   //Select Spawn
   Transform SpawnSelected = SpawnPointList[Random.Range(0,SpawnPointList.Count)].transform;
   Instantiate(ObstaclePrefab, SpawnSelected.position, Quaternion.identity);
   Counter = 0;
   RandomCounterTimer = Random.Range(0, 400);
  }
  Counter++;
 }

}
