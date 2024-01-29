using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;
using UnityEngine.UI;

public class dialougeTimer : MonoBehaviour
{

   //[SerializeField] private int setActiveTime;
    //[SerializeField] private int destroyTime;
    [SerializeField] private GameObject previousText;
    private Button next;

    private void OnMouseDown()
    {
        Debug.Log("mouse");
        previousText.SetActive(false);
    }



    /*private void Start()
    {
        gameObject.SetActive(false);
        setActive();
        StartCoroutine(deleteText());
       
    }

    IEnumerator deleteText() //coroutine that allows dialogue to be displayed for a certain amount of seconds
    { 
     
        yield return new WaitForSeconds(destroyTime);
        Destroy(gameObject);
    }

    private void setActive()
    {
        if (previousText)
        {
            Debug.Log("seen");
            gameObject.SetActive(true);
        }
    }*/
} 
