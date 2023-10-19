using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public GameObject endPoint;
    public GameObject startPoint;
    float change = 0.05f;
    float speed = 5f;
    Vector3 direction = Vector3.right;

    private void Update()
    {
        transform.Translate(direction * speed * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Finish"))
        {
            direction = Vector3.left;
            transform.position = new Vector2(transform.position.x - change, transform.position.y);
            spriteRenderer.flipX = true;
        }
        if (collision.gameObject.CompareTag("Respawn"))
        {
            direction = Vector3.right;
            transform.position = new Vector2(transform.position.x + change, transform.position.y);
            spriteRenderer.flipX = false;
        }
    }
}
