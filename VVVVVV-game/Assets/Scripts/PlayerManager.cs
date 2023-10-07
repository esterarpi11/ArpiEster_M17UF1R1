using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public Animator animator;
    public SpriteRenderer spriteRenderer;
    public Rigidbody2D rigidbody2D;
    public Transform transform;
    private float speed = 5f;
    private float horizontal;
    private float vertical;

    // Start is called before the first frame update
    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
        rigidbody2D = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxis("Vertical");
        Run();

    }
    void Run()
    {

        if (horizontal > 0)
        {
            animator.SetBool("Movement_Key", true);
            flip("X", false);
            transform.position += new Vector3(horizontal, 0f, 0f) * speed * Time.deltaTime;
        }
        if (horizontal < 0)
        {
            animator.SetBool("Movement_Key", true);
            flip("X", true);
            transform.position += new Vector3(horizontal, 0f, 0f) * speed * Time.deltaTime;
        }
        if (horizontal == 0 )
        {
            animator.SetBool("Movement_Key", false);
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
