using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour
{
    public string nextScene;

    // 게임 실행
    public void StartGame()
    {
        SceneManager.LoadScene(nextScene);
    }

    // 게임 종료
    public void ExitGame()
    {
        // 게임 종료(에디터)
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        // 게임 종료(프로그램)
#else
        Application.Quit();
#endif
    }
}
