using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class talkToNPC : MonoBehaviour
{
   
   

    public void loadScene()
    {
        SceneManager.LoadScene("scenes/talkToNPC");
    
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.F)) //loads dialogue scene when f is pressed
        {
            loadScene();
        }
    }
}
