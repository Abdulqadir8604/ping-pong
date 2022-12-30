using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player1 : MonoBehaviour
{
    public float racketSpeed;
    
     public Button upButton;
     public Button downButton;

    private Rigidbody2D rb;
    private UnityEngine.Vector2 movement;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void MoveUp()
    {
        movement.y = racketSpeed;
    }
    
    public void MoveDown()
    {
        movement.y = -racketSpeed;
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * racketSpeed * Time.fixedDeltaTime);
    }
}
