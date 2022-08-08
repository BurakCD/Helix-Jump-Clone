using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    [Header("Settings")]
    public Text ScoreText;

    private int Score;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void GameScore(int ringscore)
    {
        Score += ringscore;
        ScoreText.text = Score.ToString();
    }

    public void restart() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
