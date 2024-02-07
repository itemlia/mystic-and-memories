using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class loadPlayer : MonoBehaviour
{
    // Start is called before the first frame update
   


    public void Start()
    {
        SceneManager.LoadSceneAsync("scenes/emptyPlayerScene");

    }

  

}
