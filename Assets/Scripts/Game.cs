using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour
{
    public string nextScene;

    // ���� ����
    public void StartGame()
    {
        SceneManager.LoadScene(nextScene);
    }

    // ���� ����
    public void ExitGame()
    {
        // ���� ����(������)
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        // ���� ����(���α׷�)
#else
        Application.Quit();
#endif
    }
}
