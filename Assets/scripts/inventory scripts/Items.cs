using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class Items : MonoBehaviour
{
    private Inventory inventory;
    public GameObject item;
    [SerializeField] private Vector3 scale;


    private void Start()
    {
        inventory = GameObject.FindWithTag("Player").GetComponent<Inventory>(); 
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision");
        for (int i = 0; i < inventory.slot.Length; i++)
        {
            if (inventory.isFull[i] == false)
            {//checks if inventory is full or not so item can be added
              
                inventory.isFull[i] = true;
                gameObject.transform.localScale = scale; //increases size of gameobject when in inventory
                Instantiate(item, inventory.slot[i].transform, false); //makes sure item image spawns where the inventory slot is
                //PrefabUtility.InstantiatePrefab(item as GameObject);
                gameObject.SetActive(false);
                break;
            }
        }
    }
}
