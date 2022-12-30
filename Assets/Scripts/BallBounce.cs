using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBounce : MonoBehaviour
{
    public GameObject hitSFX;

    public BallMovement ballMovement;
    public ScoreManager scoreManager;

    private void Bounce(Collision2D collision)
    {
        Vector3 ballPosition = transform.position;
        Vector3 racketPosition = collision.transform.position;
        float racketHeight = collision.collider.bounds.size.y;

        float positionX;
        if (collision.gameObject.name == "Player 1")
        {
            positionX = 1;
        }
        else
        {
            positionX = -1;
        }

        float positionY = (ballPosition.y - racketPosition.y) / racketHeight;
        ballMovement.IncreaseHitCounter();
        ballMovement.MoveBall(new Vector2(positionX, positionY));
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name == "Player 1" || other.gameObject.name == "Player 2")
        {
            Bounce(other);
        }
        else if (other.gameObject.name == "Left Border")
        {
            scoreManager.IncreasePlayer2Score();
            ballMovement.player1Starts = true;
            StartCoroutine(ballMovement.Launch());
        }
        else if (other.gameObject.name == "Right Border")
        {
            scoreManager.IncreasePlayer1Score();
            ballMovement.player1Starts = false;
            StartCoroutine(ballMovement.Launch());
        }

        if (hitSFX != null)
        {
            Instantiate(hitSFX, transform.position, transform.rotation);
        }
    }
}
