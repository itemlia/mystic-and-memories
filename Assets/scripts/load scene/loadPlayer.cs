using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class loadPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    public Button enter;


    public void loadScene()
    {
        SceneManager.LoadScene("scenes/emptyPlayerScene");


    }

    public void Start()
    {
        var btn = enter.GetComponent<Button>();
        btn.onClick.AddListener(loadScene);
    }

}
