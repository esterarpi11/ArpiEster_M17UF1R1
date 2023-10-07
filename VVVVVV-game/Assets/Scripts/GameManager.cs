using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public enum GameState { Ready, Playing };

public class GameManager : MonoBehaviour
{
    public GameState gamestate = GameState.Ready;
    // Start is called before the first frame update
    void Start()
    {
        SceneManager.LoadScene(sceneName: "MAINMENU");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
