using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed = 7f;

    private GameObject ball;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        ball = GameObject.Find("Ball");
    }

    // Update is called once per frame
    void Update()
    {
        if (ball != null)
        {
            //delimits the vertical position for the enemy paddle
            float targetY = Mathf.Clamp(ball.transform.position.y, -4.27f, 4.27f);
            Vector2 targetPosition = new Vector2(transform.position.x, targetY);
            //move to ball position Y
            transform.position = Vector2.MoveTowards(transform.position, targetPosition, Time.deltaTime * speed);

        }
        
    }
}
