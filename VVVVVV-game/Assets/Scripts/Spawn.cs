using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    private GameManager gameManager;
    PlayerManager player;
    private void Awake()
    {
        gameManager = GameManager.gameManager;
        player = PlayerManager.player;

        if ("Spawn" + gameManager.spawn == gameObject.tag)
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
