using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class exitHouse : MonoBehaviour
{
    public GameObject player;


    private void Start()
    {
        player = GameObject.FindWithTag("Player");
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //changes scene and starts playerTrans at a specific postion
        SceneManager.LoadScene("scenes/level1");
        player.transform.position = new Vector3(-10.31762f, 8.664538f, 0f);
    }
}
