using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Spawn : MonoBehaviour
{
   
    public GameObject item;
    private Transform player;
   

    private void Start()
    {
        player = GameObject.FindWithTag("Player").transform; //gets position of player
        

    }

    public void SpawnItems ()
    {
        Vector2 spawnPos = new Vector2(player.position.x + 1, player.position.y); //sets a new position variable of the players position with an offset
        Instantiate(item, spawnPos, Quaternion.identity); //quarternian stops object rotating weirdly when spawned back into gamae
        Destroy(item);
        
    }
}
