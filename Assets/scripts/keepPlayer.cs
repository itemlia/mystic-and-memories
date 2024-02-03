using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class keepPlayer : MonoBehaviour
{

    private void Start()
    {
        int player = GameObject.FindGameObjectsWithTag("Player").Length;

        if (player > 1)
        {
          Destroy(gameObject);
        } 
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

   
}
