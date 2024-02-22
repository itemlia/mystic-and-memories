using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class endGame : MonoBehaviour
{
    public Button quit;


    public void exitGame()
    {
        Application.Quit();

    }


    public void Start()
    {

        var btn = quit.GetComponent<Button>();
        btn.onClick.AddListener(exitGame);
    }

}
