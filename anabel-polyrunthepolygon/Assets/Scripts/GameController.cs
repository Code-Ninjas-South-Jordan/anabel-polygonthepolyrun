using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public GameObject gameOverPanel;
    public Text scoreText;
    //Starting Score
    int score = 0;

    public void GameOver()
    {
        Time.timeScale = 0;
        scoreText.gameObject.SetActive(false);
        gameOverPanel.SetActive(true);
    }

    public void IncrementScore()
    {
        //Changes the score by one. 
        score++;
        scoreText.text = score.ToString();
    }
    public void Awake() {
        Time.timeScale = 1;
    }
}
