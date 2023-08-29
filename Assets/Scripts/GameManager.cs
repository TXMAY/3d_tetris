using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text UIScore;
    public Text GameOverScore;
    int score;

    // ���� ǥ��
    void Update()
    {
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
