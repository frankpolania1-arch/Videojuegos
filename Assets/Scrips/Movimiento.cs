using System;
using System.IO;
using UnityEngine;
using UnityEngine.InputSystem;

public class Movimiento : MonoBehaviour
{
    public float speed = 3;
    public float jumpForce = 5;

    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    void FixedUpdate()
    {
        if (Keyboard.current.aKey.isPressed) rb.linearVelocity = new Vector2(-speed, rb.linearVelocity.y);
        else if (Keyboard.current.dKey.isPressed) rb.linearVelocity = new Vector2(speed, rb.linearVelocity.y);
        else rb.linearVelocity = new Vector2(0f, rb.linearVelocity.y);

        // Salto
        if (Keyboard.current.spaceKey.isPressed && CheckGround.IsGround == true)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, 0f); // resetea Y antes de saltar
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);

        }

       
    }
}