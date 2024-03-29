using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class keepPlayer : MonoBehaviour
{

    private void Start()
    {
        GameObject[] player = GameObject.FindGameObjectsWithTag("Player");
        
        //if player duplicates when renetering a scene, new one will be destroyed

        if (player.Length > 1)
        {

            Destroy(player[1]);
        } 
        else
        {
           DontDestroyOnLoad(gameObject);
        }
    }

   
}
