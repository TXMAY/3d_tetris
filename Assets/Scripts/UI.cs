using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    public Text UIScore;
    public Text GameOverScore;
    public int score=0;

    // 점수 표시
    void Update()
    {
        score = GameManager.score;
        if (UIScore != null)
        {
            UIScore.text = "Score : " + score.ToString();
        }
        if (GameOverScore != null)
        {
            GameOverScore.text = "Game Over\nScore : " + score.ToString();
        }
    }
}
