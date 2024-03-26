using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnmeyColl : MonoBehaviour
{
    private ScoreManager _scoreManager;
    [SerializeField] private string NextLevelName;
    [SerializeField] private string ThisLevelName;
    
    private void Start()
    {
        _scoreManager = FindObjectOfType<ScoreManager>();
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player")){
            _scoreManager.ResetScore();
            Destroy(gameObject);
            if (NextLevelName != "")
            {
                SceneManager.LoadScene(ThisLevelName);
            }
        }
        if (other.gameObject.CompareTag("Bullet"))
        {
            _scoreManager.AddPoint(1000);
            Destroy(gameObject);

        }
    }

    private void OnCollisionExit(Collision other)
    {
        _scoreManager.CheckScore();
    }
}
    