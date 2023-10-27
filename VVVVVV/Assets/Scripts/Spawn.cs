using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    private GameManager gameManager;
    private PlayerManager player;
    private void Awake()
    {
        gameManager = GameManager.gameManager;
        player = PlayerManager.player;

        if ("Spawn" + gameManager.spawn == gameObject.tag)
        {
            player.transform.position = new Vector3(gameObject.transform.position.x, player.transform.position.y, player.transform.position.z);
        }
    }
}
