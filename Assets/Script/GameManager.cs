using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public BallMovement ball;

    public TMP_Text leftScoreText;
    public TMP_Text rightScoreText;

    public int playerLeftScore = 0;
    public int playerRightScore = 0;

    private void Start()
    {
        UpdateScoreUI();
    }

    public void LeftPlayerScored()
    {
        playerLeftScore++;
        UpdateScoreUI();
        ball.ResetBall();
    }

    public void RightPlayerScored()
    {
        playerRightScore++;
        UpdateScoreUI();
        ball.ResetBall();
    }

    private void UpdateScoreUI()
    {
        leftScoreText.text = playerLeftScore.ToString();
        rightScoreText.text = playerRightScore.ToString();
    }
}