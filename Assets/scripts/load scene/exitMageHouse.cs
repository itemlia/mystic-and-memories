using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class exitMageHouse : MonoBehaviour
{
    public GameObject player;


    private void Start()
    {
        player = GameObject.FindWithTag("Player");
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        SceneManager.LoadScene("scenes/level1");
        player.transform.position = new Vector3(0.9f, 8.34f, 0f);
    }
}
