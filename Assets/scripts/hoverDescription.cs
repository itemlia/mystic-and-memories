using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class hoverDescription : MonoBehaviour
{
    public GameObject description;
    private int hideAfterSeconds = 7;

    private void OnMouseOver()
    {
        Debug.Log("working");
        description.SetActive(true);
        //StartCoroutine(hideDescr());
    }

    private void OnMouseExit()
    {
        description.SetActive(false);
    }

    //IEnumerator hideDescr()
    //{
    //    yield return new WaitForSeconds(hideAfterSeconds);
    //    description.SetActive(false);
    //}
}
