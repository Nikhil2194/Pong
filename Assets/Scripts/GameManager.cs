using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Ball ball;

    public Paddle playerPaddle;
    public Paddle computerPaddle;

    public Text playerScoreText;
    public Text computerScoreText;

    private int _playScore;
    private int _computerScore;


    public void PlayerScores()
    {
        _playScore++;

        this.playerScoreText.text = _playScore.ToString();
        ResetRound();
    }

    public void ComputerScores()
    {
        _computerScore++;

        this.computerScoreText.text = _computerScore.ToString();
        ResetRound();
    }

    private void ResetRound ()
    {
        this.playerPaddle.ResetPosition();
        this.computerPaddle.ResetPosition();
        this.ball.ResetPosition();
        this.ball.AddStartingForce();
    }
    
}
