using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    float speed = 5f;
    Vector3 direction = Vector3.right;
    Vector3 switchDirection = Vector3.left;
    private new AudioSource audio;

    private void Start()
    {
        audio = GetComponent<AudioSource>();
    }
    private void Update()
    {
        transform.Translate(direction * speed * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        direction = Vector3.Scale(direction, switchDirection);
        spriteRenderer.flipX = !spriteRenderer.flipX;
        audio.Play();
    }
}
