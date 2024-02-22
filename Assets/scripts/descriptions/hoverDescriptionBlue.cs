using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class hoverDescriptionBlue : MonoBehaviour
{
    public GameObject description;

    private void Update()
    {
        description = GameObject.FindWithTag("blue");
    }

    private void OnMouseOver()
    {

        description.SetActive(true); //when hovering over item, description shows

    }

    private void OnMouseExit()
    {
        description.SetActive(false);
    }
}
    
