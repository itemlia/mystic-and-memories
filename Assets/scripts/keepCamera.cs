using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keepCamera : MonoBehaviour
{
   
    void Start()
    {
         GameObject[] camera = GameObject.FindGameObjectsWithTag("MainCamera");

        //if camera duplicates when renetering a scene, new one will be destroyed

        if (camera.Length > 1)
        {

            Destroy(camera[1]);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

   
}
