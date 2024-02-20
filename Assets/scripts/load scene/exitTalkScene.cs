using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class exitTalkScene : MonoBehaviour
{
    public Button exit;
    

    private void OnMouseDown()
    {
       
        loadHouse();
    }

    public void loadHouse()
    {
        //changes scene
        SceneManager.LoadScene("scenes/insideHouse");
        
    }
}
