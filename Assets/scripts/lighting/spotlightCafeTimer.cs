using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class spotlightCafeTimer : MonoBehaviour
{

    private Light2D lightComp;
    public float repeatTime;



    private void Start()
    {
        lightComp = GetComponent<Light2D>();

        //loops the couroutine
        
        for (int i = 0; i < 100; i++)
        {
            StartCoroutine(Timer());
           
        }
    }


    //coroutine that delays when the intesity of the light decreases, aslong as intensity is more than 1
    IEnumerator Timer()
    {
        while (lightComp.intensity > 1)
        {
            yield return new WaitForSeconds(repeatTime);
            lightComp.intensity = lightComp.intensity - (0.008f);
        }
    }
}
