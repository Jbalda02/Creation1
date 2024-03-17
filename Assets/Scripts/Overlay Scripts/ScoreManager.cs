using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public Text scoreText;
    private int ScoreCount;

    private void Awake()
    {
        instance = this;
        
    }

    private void Start()
    {
        scoreText.text = "Score: " + ScoreCount.ToString(); 
    }
    void Update()
    {
    }

    public void AddPoint(int d)
    {
        ScoreCount += d;
        scoreText.text = "Score: " + ScoreCount.ToString(); 

    }

}
