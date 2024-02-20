using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class exitTalkMage : MonoBehaviour
{
    public Button exit;


    private void OnMouseDown()
    {

        loadHouse();
    }

    public void loadHouse()
    {
        //changes scene
        SceneManager.LoadScene("scenes/mageHouse");

    }
}
