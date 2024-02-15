using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class enemyController : MonoBehaviour
{
    public Transform player;
    public float speed;

    private void Start()
    {
        player = GameObject.FindWithTag("player").GetComponent<Transform>();

    }
}
