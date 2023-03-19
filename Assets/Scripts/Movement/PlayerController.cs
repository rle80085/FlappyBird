using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rb;

    public KeyCode jumpKey = KeyCode.Space;
    public float jumpForce = 7f;

    public float speed = 5f;

    public AudioSource jumpSound;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        jumpSound = GetComponent<AudioSource>();
    }
    private void Update()
    {
        if (Input.GetKeyDown(jumpKey))
        {
            Jump();
        }
    }
    private void FixedUpdate()
    {
        rb.gravityScale = rb.velocity.y > 0 ? 2 : 3;

      //  rb.velocity = new Vector2(speed, Mathf.Max(rb.velocity.y, -25));
        rb.velocity = new Vector2(rb.velocity.x, Mathf.Max(rb.velocity.y, -25));
        
    }
    private void Jump()
    {
        rb.velocity = new Vector2(rb.velocity.x, 0);
        rb.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
        jumpSound.Play();
    }
}
