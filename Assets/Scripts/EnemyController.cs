using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed = 7f;

    private GameObject ball;
    private PlayerController playerController;
    private PlayerController enemyController;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        ball = GameObject.Find("Ball");

        // Find and store references to the PlayerController scripts
        playerController = GameObject.Find("PlayerPaddle").GetComponent<PlayerController>();
        enemyController = GameObject.Find("EnemyPaddle").GetComponent<PlayerController>();
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

    // Call this method when need to update the paddle colors
    public void UpdatePaddleColors()
    {
        if (playerController != null)
        {
            playerController.UpdatePaddleColor();
        }

        if (enemyController != null)
        {
            enemyController.UpdatePaddleColor();
        }
    }
}
