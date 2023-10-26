using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    private PlayerManager playerManager;
    public static GameManager gameManager;
    private AudioSource audio;
    public string spawn;

    void Awake()
    {
        string scene = SceneManager.GetActiveScene().name;

        if (scene.Contains("Menu"))
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
            SceneManager.LoadScene(sceneName: "PAUSEMENU");
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
