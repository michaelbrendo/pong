using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Transform playerPaddle;
    public Transform enemyPaddle;

    public Ball ballMovement;

    public int playerScore = 0;
    public int enemyScore = 0;

    public TextMeshProUGUI textPointsPlayer;
    public TextMeshProUGUI textPointsEnemy;

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

        playerScore = 0;
        enemyScore = 0;

        textPointsPlayer.text = playerScore.ToString();
        textPointsEnemy.text = enemyScore.ToString();
    }

    public void ScorePlayer()
    {
        playerScore++;
        textPointsPlayer.text = playerScore.ToString();
        //textPointsPlayer.text += playerScore.ToString();
    }

    public void ScoreEnemy()
    {
        enemyScore++;
        textPointsEnemy.text = enemyScore.ToString();
    }
}
