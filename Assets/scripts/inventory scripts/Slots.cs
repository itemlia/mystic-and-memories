using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slots : MonoBehaviour
{
    private Inventory inventory;
    public int i; //= 0;

    private void Start()
    {
        inventory = GameObject.FindWithTag("Player").GetComponent<Inventory>(); 
    }


    private void Update()
    {
        if (transform.childCount >= 1)       
        {
            inventory.isFull[i] = true; //edits inventory array
        }
    }

    public void OnMouseDown()
    {
        //inventory.isFull[i] = false;
        foreach (Transform child in transform)
        {
            child.GetComponent<Spawn>().SpawnItems(); //calls function from spawn class
           // if (child.tag == "item")
            //{
                Destroy(child.gameObject);
               
           // }
        }
        
    }
}
