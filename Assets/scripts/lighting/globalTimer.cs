using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
using UnityEngine.SceneManagement;

public class globalTimer : MonoBehaviour
{
    
    private Light2D lightComp;
    public float repeatTime;


    //private void OnEnable()
    //{
    //    SceneManager.sceneLoaded += OnSceneLoaded;
    //}

   // private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
   //{
   //     //when scene is loaded run function

   //     lightComp = GetComponent<Light2D>();
   //     GameObject[] lightDupe = GameObject.FindGameObjectsWithTag("global light");
   //     string name = SceneManager.GetActiveScene().name;

   //     if (name == "level1")
   //     {
   //         //if right scene is loaded sttart timer 

   //         for (int i = 0; i < 100; i++)
   //         {
   //             if (lightDupe.Length > 1)
   //             {
   //                 //destroys extra global light if it duplicates when changing scene 

   //                 Destroy(lightDupe[1]);
                   
   //                 lightComp = lightDupe[0].GetComponent<Light2D>();
   //             }
   //             else
   //             {
   //                 //starts coroutine timer and sets light to be active

   //                 gameObject.SetActive(true);
   //                 StartCoroutine(Timer());
   //             }
   //         }
   //     } 
   //     else 
   //     {
   //         //if in wrong scene disables light

   //         gameObject.SetActive(false);
   //     }

   // }

    private void Start()
    {

        lightComp = GetComponent<Light2D>();
        GameObject[] lightDupe = GameObject.FindGameObjectsWithTag("global light");
        string name = SceneManager.GetActiveScene().name;

        //keeps global light when changing scene so timer continues
        DontDestroyOnLoad(lightComp);

        if (name == "level1")
        {
            //if right scene is loaded sttart timer 

            for (int i = 0; i < 100; i++)
            {
                if (lightDupe.Length > 1)
                {
                    //destroys extra global light if it duplicates when changing scene 

                    Destroy(lightDupe[1]);

                    lightComp = lightDupe[0].GetComponent<Light2D>();
                }
                else
                {
                    //starts coroutine timer and sets light to be active

                    gameObject.SetActive(true);
                    StartCoroutine(Timer());
                }
            }
        }
        else
        {
            //if in wrong scene disables light

            gameObject.SetActive(false);
        }
    }

    //coroutine that delays when the intesity of the light decreases, aslong as intensity is more than 1
    IEnumerator Timer()
    {
        while (lightComp.intensity < 1)
        {
            yield return new WaitForSeconds(repeatTime);
            lightComp.intensity = lightComp.intensity + (0.00008f);
        }
    }
}
