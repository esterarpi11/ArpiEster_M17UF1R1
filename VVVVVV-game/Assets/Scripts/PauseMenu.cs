using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public void Restart()
    {
        Debug.Log("restart");
        SceneManager.LoadScene(sceneBuildIndex: 2);
    }
    public void Exit()
    {
        Debug.Log("exit");
        SceneManager.LoadScene(sceneBuildIndex: 1);
    }
}
