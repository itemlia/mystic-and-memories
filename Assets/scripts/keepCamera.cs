using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class keepCamera : MonoBehaviour
{

    private void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
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
