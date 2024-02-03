using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keepCamera : MonoBehaviour
{
   
    void Start()
    {
        int camera = GameObject.FindGameObjectsWithTag("MainCamera").Length;

        if (camera > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

   
}
