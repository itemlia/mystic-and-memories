using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class hoverDescription : MonoBehaviour
{
    public GameObject description;

 

    private void OnMouseOver()
    {

        description.SetActive(true); //when hovering over item, description shows

    }

    private void OnMouseExit()
    {
        description.SetActive(false);
    }
}
    
