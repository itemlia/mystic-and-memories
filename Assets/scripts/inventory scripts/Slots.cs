using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class Slots : MonoBehaviour
{
    private Inventory inventory;
    private int i;

    public GameObject redText;

    private void Start()
    {
        inventory = GameObject.FindWithTag("Player").GetComponent<Inventory>();

    }


    public void OnMouseDown()
    {
        foreach (Transform child in transform)
        {
            
            child.GetComponent<Spawn>().SpawnItems(); //spawns item back into world
            GameObject.Destroy(child.gameObject);
            inventory.isFull[i] = false; //resets inventory slot to false
        }
    }


}