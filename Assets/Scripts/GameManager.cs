using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text UIScore;
    int score;

    // ���� ǥ��
    void Update()
    {
        UIScore.text = "Score : " + score.ToString();
    }

}
