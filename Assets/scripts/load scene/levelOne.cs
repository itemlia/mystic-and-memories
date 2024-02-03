using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class levelOne : MonoBehaviour
{
    public Button enter;
  

    public void loadScene()
    {
        SceneManager.LoadSceneAsync("scenes/level1");
        
       
    }

    public void Start()
    {
        var btn = enter.GetComponent<Button>();
        btn.onClick.AddListener(loadScene);
    }

}
