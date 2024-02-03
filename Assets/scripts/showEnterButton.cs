using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
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
        mask = ~mask; 
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, distance, mask);
        if (hit.transform != null)
        {
            if (hit.transform.CompareTag("Player")) //when player gets near house enter button shows up
            {
                buttonManager.SetActive(true);

                //use waitforseconds to hide it so doest always stay active

                //make scripts that let u leave houses when u walk towards the back - use collisions
            }
        }


    }

}
