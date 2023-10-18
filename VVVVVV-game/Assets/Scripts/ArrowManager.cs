using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowManager : MonoBehaviour
{
    public Transform spawn;
    public Transform endPoint;

    float speed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
        if (transform.position.x >= endPoint.position.x)
        {
            transform.position = new Vector2 (spawn.position.x, transform.position.y);

        }
    }

}
