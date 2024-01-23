using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class dialougeTimer : MonoBehaviour
{

    [SerializeField] private int setActiveTime;
    [SerializeField] private int destroyTime;

    private void Start()
    {
        //gameObject.SetActive(false);
        StartCoroutine(delayTime());
    }

    IEnumerator delayTime()
    {
        Debug.Log("timer");

       // yield return new WaitForSeconds(setActiveTime);
        //Thread.Sleep(setActiveTime);

       // gameObject.SetActive(true);

        yield return new WaitForSeconds(destroyTime);
        //Thread.Sleep(destroyTime);

        Destroy(gameObject);
    }
} 
