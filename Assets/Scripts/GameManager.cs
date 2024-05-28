using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Transform playerPaddle;
    public Transform enemyPaddle;
    public Ball ballMovement;

    void Start()
    {
        ResetGame();
    }

    public void ResetGame()
    {
        // Initial paddle position
        playerPaddle.position = new Vector3(-7f, 0f, 0f);
        enemyPaddle.position = new Vector3(7f, 0f, 0f);

        ballMovement.ResetBall();
    }
}
