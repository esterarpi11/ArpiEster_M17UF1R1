using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public GameObject endPoint;
    public GameObject startPoint;
    float speed = 5f;
    Vector3 direction = Vector3.right;
    public AudioSource audio;

    private void Start()
    {
    }
    private void Update()
    {
        transform.Translate(direction * speed * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Finish"))
        {
            direction = Vector3.left;
            transform.position = new Vector2(transform.position.x, transform.position.y);
            spriteRenderer.flipX = true;
            audio.Play();
        }
        if (collision.gameObject.CompareTag("Respawn"))
        {
            direction = Vector3.right;
            transform.position = new Vector2(transform.position.x, transform.position.y);
            spriteRenderer.flipX = false;
            audio.Play();
        }
    }
}
