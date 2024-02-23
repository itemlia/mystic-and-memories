using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Rendering.Universal;

public class exitHouse : MonoBehaviour
{
    public GameObject player;
    public Light2D lightComp;

    private void Start()
    {
        player = GameObject.FindWithTag("Player");
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //changes scene and starts player at a specific postion
        SceneManager.LoadScene("scenes/level1");
        player.transform.position = new Vector3(-10.31762f, 8.664538f, 0f);

        //plays open door sound effect
        var sound = GameObject.Find("soundManager").GetComponent<audioManager>();

        sound.sound[1].playSound(true);

    }
}
