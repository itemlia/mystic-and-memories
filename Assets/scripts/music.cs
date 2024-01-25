using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class music : MonoBehaviour
{


    private void Awake()
    {
        var playingCount = FindObjectsOfType<AudioSource>().Length;

        if (playingCount > 1) //if theres more than one song playig in a scene - will dleete old one
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }

    }

}
