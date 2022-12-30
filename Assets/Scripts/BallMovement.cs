using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float startSpeed;
    public float extraSpeed;
    public float maxExtraSpeed;

    public bool player1Starts = true;

    public int hitCounter = 0;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        StartCoroutine(Launch());
    }

    private void RestartBall()
    {
        rb.velocity = Vector2.zero;
        transform.position = Vector2.zero;
    }

    public IEnumerator Launch()
    {
        RestartBall();
        yield return new WaitForSeconds(1f);
        if (player1Starts)
        {
            rb.velocity = Vector2.right * startSpeed;
        }
        else
        {
            rb.velocity = Vector2.left * startSpeed;
        }
    }

    public void MoveBall(Vector2 direction)
    {
        direction = direction.normalized;
        float ballSpeed = startSpeed + (extraSpeed * hitCounter);
        rb.velocity = direction * ballSpeed;
    }

    public void IncreaseHitCounter()
    {
        hitCounter++;

        if (hitCounter > maxExtraSpeed)
        {
            hitCounter = (int)maxExtraSpeed;
        }
    }
    
}
