using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class hoverDescription : MonoBehaviour
{
    public GameObject description;

    private void Start()
    {
        description = GameObject.Find("red desc empty");
    }

    private void OnMouseOver()
    {
      
        description.SetActive(true);

    }

    private void OnMouseExit()
    {
        description.SetActive(false);
    }
}
    
