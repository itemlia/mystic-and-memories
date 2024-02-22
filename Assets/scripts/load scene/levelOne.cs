using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class levelOne : MonoBehaviour
{
    public Button enter;
  

    public void destroy()
    {
        //delets canvas
        Destroy(gameObject);
        
       
    }

    public void Start()
    {
        var btn = enter.GetComponent<Button>();
        btn.onClick.AddListener(destroy);
    }

}
