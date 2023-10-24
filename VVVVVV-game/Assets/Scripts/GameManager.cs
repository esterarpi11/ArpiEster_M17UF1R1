using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public static GameManager gameManager;
    public string spawn;

    void Awake()
    {
        if (gameManager == null)
        {
            DontDestroyOnLoad(gameObject);
            gameManager = this;
        }
        else if (gameManager != null && gameManager != this)
        {
            Destroy(this.gameObject);
            return;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
               
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(sceneName: "PAUSEMENU");
            Destroy(PlayerManager.player);
        }
    }

    public void buttonOnClick(int escena)
    {
        if (escena != 0)
        {
            SceneManager.LoadScene(escena);
        }
        else
        {
            Application.Quit();
        }
    }
}
