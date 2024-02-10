using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class exitTalkScene : MonoBehaviour
{
    public Button exit;
    public GameObject player;

    private void OnMouseDown()
    {
        player = GameObject.FindWithTag("Player");
        loadHouse();
    }

    public void loadHouse()
    {
        SceneManager.LoadScene("scenes/insideHouse");
        player.transform.position = new Vector3(0.1314539f, -9.746695f, 0f);
    }
}
