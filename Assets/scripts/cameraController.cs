using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cameraController : MonoBehaviour
{
  
    public Transform player;
    public Vector3 cameraOffset = new Vector3 (0, 0, -10);

    private void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        player = GameObject.Find("player").GetComponent<Transform>();
    }

    private void Update() //in update to stop camera moving before playerTrans does
    {
        transform.position = player.position + cameraOffset; //camera follows player around the scene
    }
}
