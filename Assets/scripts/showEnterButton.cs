using System.Collections;
using System.Collections.Generic;
//ing System.Diagnostics;
using Unity.VisualScripting;
using UnityEditor.Presets;
using UnityEngine;



public class showEnterButton : MonoBehaviour
{
    public GameObject buttonManager;
    [SerializeField] private float distance;

    private void Update()
    {
        int layer = 2;
        int mask = 1 << layer;
        mask = ~mask; //makes it so that the raycast ignores things on a certain layer
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, distance, mask);
        if (hit.transform != null)
        {

            if (hit.transform.CompareTag("Player")) //when playerTrans gets near house enter button shows up
            {
                buttonManager.SetActive(true);
            }

        } else
        {
            buttonManager.SetActive(false); //when playerTrans moves away enter button disappears
        }
    }

}
