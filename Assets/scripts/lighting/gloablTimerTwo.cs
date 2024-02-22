using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.SceneManagement;

public class gloablTimerTwo : MonoBehaviour
{
    private Light2D lightComp;
    public float repeatTime;

    
    private void Start()
    {
        lightComp = GameObject.FindWithTag("global light").GetComponent<Light2D>();

        GameObject[] lightDupe = GameObject.FindGameObjectsWithTag("global light");

        if (lightDupe.Length > 1)
        {
            //destroys extra global light if it duplicates when changing scene 

            Destroy(lightDupe[0]);

        }

        StartCoroutine(Timer());

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
