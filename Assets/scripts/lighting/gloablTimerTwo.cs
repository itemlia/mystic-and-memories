using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class gloablTimerTwo : MonoBehaviour
{
    private Light2D lightComp;
    public float repeatTime;

    private void Start()
    {
        StartCoroutine(Timer());
        GameObject[] lightDupe = GameObject.FindGameObjectsWithTag("global light");
        if (lightDupe.Length > 1)
        {
            //destroys extra global light if it duplicates when changing scene 

            Destroy(lightDupe[1]);

            //lightComp = lightDupe[0].GetComponent<Light2D>();
        }
    }


    //coroutine that delays when the intesity of the light decreases, aslong as intensity is less than 1
    IEnumerator Timer()
    {
        while (lightComp.intensity < 1)
        {
            yield return new WaitForSeconds(repeatTime);
            lightComp.intensity = lightComp.intensity + (0.008f);
        }
    }
}
