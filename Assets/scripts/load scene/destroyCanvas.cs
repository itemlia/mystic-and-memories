using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class destroyCanvas : MonoBehaviour
{
    public Button start;


    public void destroy()
    {
        Destroy(gameObject);
        
    }


    public void Start()
    {
        DontDestroyOnLoad(gameObject);

        var btn = start.GetComponent<Button>();
        btn.onClick.AddListener(destroy);
    }
}
