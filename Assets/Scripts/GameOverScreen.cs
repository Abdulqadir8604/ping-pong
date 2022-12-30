using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    public Text scoreText;

    public void Setup(int player1Score, int player2Score)
    {
        Time.timeScale = 0f;
        gameObject.SetActive(true);
        scoreText.text = player1Score + " - " + player2Score;
    }
    
    public void Restart()
    {
        Time.timeScale = 1f;
        gameObject.SetActive(false);
        SceneManager.LoadScene(1);
    }
    
    public void MainMenu()
    {
        Time.timeScale = 1f;
        gameObject.SetActive(false);
        SceneManager.LoadScene(0);
    }
}
