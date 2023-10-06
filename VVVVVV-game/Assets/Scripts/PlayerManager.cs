using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    private Animator animator;
    private SpriteRenderer spriteRenderer;
    private Rigidbody2D rigidbody2D;
    private Transform transform;
    private float speed = 8f;
    private float horizontal;
    private float vertical;

    // Start is called before the first frame update
    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxis("Vertical");
        animator.SetBool("R_Key", false);
        Run();

    }
    void Run()
    {

        if (Input.GetKeyDown(KeyCode.D))
        {
            animator.SetBool("R_Key", true);
            flip("X", false);
            transform.position += new Vector3(horizontal, 0f, 0f) * speed * Time.deltaTime;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            animator.SetBool("R_Key", true);
            flip("X", true);
            transform.position += new Vector3(horizontal, 0f, 0f) * speed * Time.deltaTime;
        }
        if (Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D))
        {
            animator.SetBool("R_Key", false);
        }

        void flip(string axis, bool value)
        {
            if (axis == "X")
            {
                spriteRenderer.flipX = value;
            }
            else
            {
                spriteRenderer.flipY = value;
            }
        }
    }
}
