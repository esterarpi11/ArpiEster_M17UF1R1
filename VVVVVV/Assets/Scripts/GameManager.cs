using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public static GameManager gameManager;
    private new AudioSource audio;
    public string spawn;

    void Awake()
    {
        if (SceneManager.GetActiveScene().name.Contains("Menu"))
        {
            gameObject.SetActive(false);
        }
        else if (gameManager == null)
        {
            gameObject.SetActive(true);
            gameManager = this;
            DontDestroyOnLoad(gameObject);
        }
        else if (gameManager != null && gameManager != this)
        {
            Destroy(this.gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
        audio.Play();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(sceneName: "PauseMenu");
        }
    }

    public void sceneChange(int escena)
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
