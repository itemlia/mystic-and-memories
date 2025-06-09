using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class levelOne : MonoBehaviour
{
    public Button enter;
  

    public void loadScene()
    {
        //changes scene
        SceneManager.LoadScene("scenes/level1");
        
    }

    private void OnMouseDown()
    {
        loadScene();
    }
}
