using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public string sceneName;

    // ���� ����
    public void StartGame()
    {
        SceneManager.LoadScene(sceneName);
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
