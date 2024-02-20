using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class talkToNPC : MonoBehaviour
{

  

    public void loadScene()
    {
        //changes scene
        SceneManager.LoadScene("scenes/talkToNPC");
    
    }

    private void OnMouseDown()
    {
        loadScene();
    }
}
