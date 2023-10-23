using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    PlayerManager player;
    GameManager gameManager;
    private void Awake()
    {
        if (gameManager.spawn == "NextLevel")
        {
            player.transform.position = gameObject.transform.position;
        }
        else if (gameManager.spawn == "ReturnLevel")
        {
            player.transform.position = gameObject.transform.position;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
