using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public Text scoreText;
    private int ScoreCount;
    private int ScoreCap = 10000;
    [SerializeField]  string nextLevel;
    [SerializeField] private string thisLevel;

    private void Awake()
    {
        instance = this;
        
    }

    private void Start()
    {
        scoreText.text = "Score: " + ScoreCount.ToString(); 
    }

    public void CheckScore()
    {
        if (nextLevel != thisLevel)
        {
            if (ScoreCount > ScoreCap)
            {
                print("ReadyForNextLevel");
                SceneManager.LoadScene(nextLevel);
            }
        }
        scoreText.text = "Score: " + ScoreCount.ToString() + "You Won!!!";
    }

    public void AddPoint(int d)
    {
        ScoreCount += d;
        scoreText.text = "Score: " + ScoreCount.ToString(); 

    }

    public void ResetScore()
    {
        ScoreCount = 0;
        scoreText.text = "Score: " + ScoreCount.ToString(); 

    }
}
