using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    private GameObject item;
    private Transform player;
    [SerializeField] private Vector3 scale;

    private void Start()
    {
        player = GameObject.FindWithTag("Player").transform; //gets position of player
        item = GameObject.FindWithTag("item");

    }

    public void SpawnItems ()
    {
        Vector2 spawnPos = new Vector3(player.position.x + 3, player.position.y - 3, 0); //sets a new position variable of the players position with an offset
        Instantiate(item, spawnPos, Quaternion.identity); //quarternian stops object rotating weirdly when spawned back into gamae
        item.transform.localScale = scale; //sets scale of item when spawned into game
    }
}
