using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class keepPlayer : MonoBehaviour
{
    private string currentScene; 

    private void Start()
    {
        currentScene = SceneManager.GetActiveScene().name;
    }

    private void Awake()
    {
        if (currentScene == "level1")
        {
            Destroy(gameObject);
        } 
        else
        {
            DontDestroyOnLoad(gameObject);
        }
        +
        

    }
}
