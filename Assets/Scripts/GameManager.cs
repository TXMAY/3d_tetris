using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static int score = 0;
    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
}
