using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class talkToMage : MonoBehaviour
{
    public void loadScene()
    {
        //changes scene
        SceneManager.LoadScene("scenes/talkToMage");

    }

    private void OnMouseDown()
    {
        loadScene();
    }
}

