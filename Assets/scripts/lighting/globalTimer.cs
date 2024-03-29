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
    private float tempLightVal = 0.0f;
    
    private void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {

        string name = SceneManager.GetActiveScene().name;
    
        GameObject[] lightDupe = GameObject.FindGameObjectsWithTag("global light");


        if (name == "level1")
        {
            lightComp = GameObject.FindWithTag("global light").GetComponent<Light2D>();

            //if right scene is loaded sttart timer 

            for (int i = 0; i < 3; i++)
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

                    //gameObject.SetActive(true);
                    //StartCoroutine(Timer());
                    TurnOn();
                }
            }
        }
        else if (name != "level1")
        {
            //if in wrong scene disables light

            // gameObject.SetActive(false);
            TurnOff();
        }
    }

    private void Start()
    {

        //keeps global light when changing scene so timer continues
       
        DontDestroyOnLoad(gameObject);

       
    }

    public void TurnOff()
    {
        StopCoroutine(Timer());
        tempLightVal = lightComp.intensity;
        lightComp.intensity = 0;
        
    }

    public void TurnOn()
    {
        lightComp.intensity = tempLightVal;
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
