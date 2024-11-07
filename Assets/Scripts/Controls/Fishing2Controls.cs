using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fishing2Controls : MonoBehaviour
{
    private float horizontalMove;
    private float verticalMove;

    private Rigidbody2D rb;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        horizontalMove = InputManager2.instance.moveInput.x;
        verticalMove = InputManager2.instance.moveInput.y;
    }

    private void FixedUpdate() 
    {
        rb.velocity = new Vector2(horizontalMove, verticalMove);
    }
}
