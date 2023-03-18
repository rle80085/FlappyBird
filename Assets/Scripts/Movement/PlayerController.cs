using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rb;

    public KeyCode JumpKey = KeyCode.Space;
    public float JumpForce = 10f;

    public float speed = 5f;

    public AudioSource JumpSound;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        JumpSound = GetComponent<AudioSource>();
    }
    private void Update()
    {
        if (Input.GetKeyDown(JumpKey))
        {
            Jump();
        }
    }
    private void FixedUpdate()
    {
        rb.gravityScale = rb.velocity.y > 0 ? 2 : 3;

        rb.velocity = new Vector2(speed, Mathf.Max(rb.velocity.y, -25));
        
    }
    private void Jump()
    {
        rb.velocity = new Vector2(rb.velocity.x, 0);
        rb.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
        JumpSound.Play();
    }
}
