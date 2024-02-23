using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioManager : MonoBehaviour
{
    [Serializable]

    public class soundEffect
    {
        //audio class

        public AudioSource soundFile;
        public string soundName;
        public float volume;
        public bool play;

        //method for playing sound
        public void playSound(bool play)
        {
            if (play == true)
            {
                soundFile.Play();
            }
        }
       
    }

    //array of soundeffects
    public soundEffect[] sound;

    private void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

}