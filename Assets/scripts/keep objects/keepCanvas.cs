using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class keepCanvas : MonoBehaviour
{
    private void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        GameObject[] playerCanvas = GameObject.FindGameObjectsWithTag("player canvas");

        //if player duplicates when renetering a scene, new one will be destroyed

        if (playerCanvas.Length > 1)
        {

            Destroy(playerCanvas[1]);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }
}
