using UnityEngine;
using UnityEngine.UI;

public class GameManagerSnake : MonoBehaviour{
    public Text scoreNum;
    private int _snakeScore;

    public void SnakeScore(){
        _snakeScore++;
        this.scoreNum.text = _snakeScore.ToString();
    }

}
