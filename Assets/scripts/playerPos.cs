using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerPos : MonoBehaviour

{
    public GameObject player;

  
    void Start()
    {
        player.transform.position = new Vector3(-0.07f, -8.56f, 0f); //playerTrans loads in at bottom of screen


    }
}
