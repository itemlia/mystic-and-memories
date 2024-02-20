using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showTalkButton : MonoBehaviour
{
    public GameObject talkButton;
    [SerializeField] private float distance;
    

    private void Update()
    {
        int layer = 2;
        int mask = 1 << layer;
        mask = ~ mask; //makes it so that the raycast ignores things on a certain layer
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, distance, mask);
        if (hit.transform != null)
        {
            
            if (hit.transform.CompareTag("Player")) //when playerTrans gets near npc pop up shows allowing them to talk to playerTrans
            {
               
                talkButton.SetActive(true);
            }
        }
        else
        {
            talkButton.SetActive(false); //when playerTrans moves away enter button disappears
        }


    }

    
}
