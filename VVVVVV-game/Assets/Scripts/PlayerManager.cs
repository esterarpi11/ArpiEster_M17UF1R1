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
    private float gravitySpeed = 10f;
    private bool rightSide = true;
    private float horizontal;

    // Start is called before the first frame update
    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
        rigidbody2D = gameObject.GetComponent<Rigidbody2D>();
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
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
    }
    void Gravity()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rightSide = !rightSide;

            rigidbody2D.gravityScale = (rightSide) ? 1 : -1;
            spriteRenderer.flipY = !rightSide;

            Vector2 newSpeed = rigidbody2D.velocity;

            if (!rightSide)
            {
                newSpeed.y = gravitySpeed * -1;
                rigidbody2D.velocity = newSpeed;
            }
            else
            {
                newSpeed.y = gravitySpeed * 1;
                rigidbody2D.velocity = newSpeed;
            }
        }
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
        if (horizontal == 0)
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
