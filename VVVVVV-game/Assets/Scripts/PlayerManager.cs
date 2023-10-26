using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour
{
    public static PlayerManager player;
    private Animator animator;
    private SpriteRenderer spriteRenderer;
    private Rigidbody2D rigidbody2D;
    private float speed = 8f;
    private bool rightSide = true;
    private float horizontal;
    private GameManager gameManager;
    private bool isDead = false;
    private AudioSource audio;

    void Awake()
    {
        if (player == null)
        {
            DontDestroyOnLoad(gameObject);
            player = this;
        }
        else Destroy(this.gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameManager.gameManager;
        DontDestroyOnLoad(gameObject);
        animator = gameObject.GetComponent<Animator>();
        rigidbody2D = gameObject.GetComponent<Rigidbody2D>();
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        audio = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        if (rigidbody2D.velocity.y == 0)
        {
            Gravity();
        }
        Run();
        if(SceneManager.GetActiveScene().name == "PausaMenu") Destroy(gameObject);
    }
    void Gravity()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rightSide = !rightSide;

            rigidbody2D.gravityScale = (rightSide) ? 1 : -1;
            spriteRenderer.flipY = !rightSide;
        }
    }
    void Run()
    {
        if (horizontal != 0 && !isDead)
        {
            animator.SetBool("Movement_Key", true);
            transform.position += new Vector3(horizontal, 0f, 0f) * speed * Time.deltaTime;
            if (horizontal > 0)
            {
                spriteRenderer.flipX = false;
            }
            else
            {
                spriteRenderer.flipX = true;
            }
        }
        else if (horizontal == 0)
        {
            animator.SetBool("Movement_Key", false);
        }
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("NextLevel"))
        {
            gameManager.sceneChange(SceneManager.GetActiveScene().buildIndex + 1);
            gameManager.spawn = "NextLevel";
        }
        if (collision.gameObject.CompareTag("ReturnLevel"))
        {
            gameManager.sceneChange(SceneManager.GetActiveScene().buildIndex - 1);
            gameManager.spawn = "ReturnLevel";
        }
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            audio.Play();
            animator.SetBool("Dead", true);
            isDead = true;
            StartCoroutine(wait());
        }
    }
    IEnumerator wait()
    {
        yield return new WaitForSecondsRealtime(2);
        Destroy(gameObject);
        SceneManager.LoadScene(sceneName: "GameOverMenu");  

    }
}
