using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slots : MonoBehaviour
{
    private Inventory inventory;
    public int i = 0;

    private void Start()
    {
        inventory = GameObject.FindWithTag("Player").GetComponent<Inventory>(); 
    }


    private void Update()
    {
        if (transform.childCount >= 2)
        {
            inventory.isFull[i] = true; //edits invetory array
        }
    }

    public void OnMouseDown()
    {
        foreach (Transform child in transform)
        {
            GetComponent<Spawn>().SpawnItems(); //calls function from spawn class
            if (child.tag == "item")
            {
                Destroy(child.gameObject);
                inventory.isFull[i] = false;
            }
        }
        
    }
}
