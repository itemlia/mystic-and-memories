using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class loadInsideHouse : MonoBehaviour
{

    public Button enter;
    public GameObject player;

    public void loadHouse()
    {
        SceneManager.LoadScene("scenes/insideHouse");
        player.transform.position = new Vector3(0.1314539f, -9.746695f, 0f);
    }
    
    public void Start()
    {
        player = GameObject.FindWithTag("Player");
        var btn = enter.GetComponent<Button>();
        btn.onClick.AddListener(loadHouse);
    }


}
