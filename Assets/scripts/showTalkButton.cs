using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showTalkButton : MonoBehaviour
{
    public GameObject pressF;
    [SerializeField] private float distance;
    

    private void Update()
    {
        int layer = 2;
        int mask = 1 << layer;
        mask = ~ mask;
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, distance, mask);
        if (hit.transform != null)
        {
            if (hit.transform.CompareTag("Player")) //when player gets near npc pop up shows allowing them to talk to player
            {
                 pressF.SetActive(true);
            }
        }
        

    }

    
}
