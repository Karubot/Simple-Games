using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour{
    public Ball ball;
    public Paddle playerPaddle, computerPaddle;
    public Text playerScoreText, computerScoreText;
    
    private int _playerScore;
    private int _computerScore;

    public void PlayerScores(){
        _playerScore++;
        
        this.playerScoreText.text = _playerScore.ToString();
        ResetRound();
    }
    public void ComputerScores(){
        _computerScore++;

        this.computerScoreText.text = _computerScore.ToString();
        ResetRound();

    }

    private void ResetRound(){
        this.ball.ResetPosition();
        this.playerPaddle.ResetPosition();
        this.computerPaddle.ResetPosition();
        this.ball.AddStartingForce();
    }
}
