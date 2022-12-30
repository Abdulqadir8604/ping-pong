using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public int scoreToReach;

    public Text player1ScoreText;
    public Text player2ScoreText;

    public int player1Score = 0;
    public int player2Score = 0;

    public GameOverScreen gameOverScreen;

    public void IncreasePlayer1Score()
    {
        player1Score++;
        player1ScoreText.text = player1Score.ToString();
        CheckScore();
    }

    public void IncreasePlayer2Score()
    {
        player2Score++;
        player2ScoreText.text = player2Score.ToString();
        CheckScore();
    }

    public void CheckScore()
    {
        if (player1Score >= scoreToReach || player2Score >= scoreToReach)
        {
            gameOverScreen.Setup(player1Score , player2Score);
        }
    }

}
