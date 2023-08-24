using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text UIScore;
    int score;

    // 점수 표시
    void Update()
    {
        UIScore.text = "Score : " + score.ToString();
    }

}
