using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class speedUp : MonoBehaviour
{
    public void OnMouseDown()
    {
        GameObject player = GameObject.Find("player");
        

        //gets a refernece to the player controller script

        var playerScript = player.GetComponent<characterController>();

        //increases player speed

        playerScript.speed = 7;

        //destriys item

        Destroy(gameObject);
    }
}
