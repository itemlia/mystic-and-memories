using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class loadMageHouse : MonoBehaviour
{
    public Button enter;
    public GameObject player;

    public void loadHouse()
    {
        //changes scene and starts player at a specific postion
        player.transform.position = new Vector3(-0.07999991f, -9.081256f, 0f);
        SceneManager.LoadScene("scenes/mageHouse");

        //plays open door sound effect
        var sound = GameObject.Find("soundManager").GetComponent<audioManager>();

        sound.sound[1].playSound(true);
    }

    public void Start()
    {
        player = GameObject.FindWithTag("Player");
        var btn = enter.GetComponent<Button>();
        btn.onClick.AddListener(loadHouse);
    }
}
