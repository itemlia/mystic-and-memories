using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class firstDialogue : MonoBehaviour
{

   
    [SerializeField] private int destroyTime;
    
    private void Start()
    {
     
        StartCoroutine(deleteText());

    }

    IEnumerator deleteText() //coroutine that allows dialogue to be displayed for a certain amount of seconds
    {

        yield return new WaitForSeconds(destroyTime);
        gameObject.SetActive(false);
    }


}
