using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowManager : MonoBehaviour
{
    public Transform startPoint;
    public Transform endPoint;
    private new AudioSource audio;
    float speed = 8f;

    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
        if (transform.position.x >= endPoint.position.x)
        {
            transform.position = new Vector2(startPoint.position.x, transform.position.y);
            audio.Play();
        }
    }

}
