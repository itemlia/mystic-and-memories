using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class Items : MonoBehaviour
{
    private Inventory inventory;
    public GameObject item;
    


    private void Start()
    {
        inventory = GameObject.FindWithTag("Player").GetComponent<Inventory>();
        
    }

   

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            for (int i = 0; i < inventory.slot.Length; i++)
            {
                if (inventory.isFull[i] == false)
                {//checks if inventory is full or not so item can be added

                    inventory.isFull[i] = true;
                    Instantiate(item, inventory.slot[i].transform, false); //makes sure item image spawns where the inventory slot is
                    Destroy(gameObject);
                    break;
                }
            }
        }
    }
}
