using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    private Rigidbody2D rb;
    private Vector2 startingVelocity = new Vector2(5f, 0f);

    public void ResetBall()
    {
        // ball start position
        transform.position = Vector3.zero;

        if (rb == null) rb = GetComponent<Rigidbody2D>();
        rb.velocity = startingVelocity;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Wall"))
        {
            Vector2 newVelocity = rb.velocity;

            newVelocity.y = - newVelocity.y;
            rb.velocity = newVelocity;
        }

        if(collision.gameObject.CompareTag("Player") || collision.gameObject.CompareTag("Enemy"))
        {
            rb.velocity = new Vector2(-rb.velocity.x, rb.velocity.y);
        }
    }
}
