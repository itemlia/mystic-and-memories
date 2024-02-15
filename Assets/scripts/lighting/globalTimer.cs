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


    private void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
   {
        lightComp = GetComponent<Light2D>();
        GameObject[] lightDupe = GameObject.FindGameObjectsWithTag("global light");
        string name = SceneManager.GetActiveScene().name;
        Debug.Log(name);

        if (name == "level1")
        {
            for (int i = 0; i < 100; i++)
            {
                if (lightDupe.Length > 1)
                {
                    Destroy(lightDupe[1]);
                }
                else
                {
                    gameObject.SetActive(true);
                    StartCoroutine(Timer());
                    DontDestroyOnLoad(lightComp);

                }
            }
        } 
        else 
        {
            DontDestroyOnLoad(lightComp);
            gameObject.SetActive(false);
        }

   }
    

   
    IEnumerator Timer()
    {
        while (lightComp.intensity < 1)
        {
            yield return new WaitForSeconds(repeatTime);
            lightComp.intensity = lightComp.intensity + (0.00008f);
        }
    }
}
