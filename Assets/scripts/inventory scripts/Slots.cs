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
        if (transform.childCount >= 1)
        {
            inventory.isFull[i] = true; //edits invetory array
        }
    }

    public void OnMouseDown()
    {
        foreach (Transform child in transform)
        {
            child.GetComponent<Spawn>().SpawnItems(); //calls function from spawn class
            Destroy(child.gameObject); //if cross is press then object will be removed from inventory
        }
    }
}
