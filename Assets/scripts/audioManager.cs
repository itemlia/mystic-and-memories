using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioManager : MonoBehaviour
{
   [Serializable]

   public class soundEffect
    {
        public AudioSource soundFile;
        public string name;
        public float volume;

    }

    [SerializeField] List<soundEffect> sounds = new List<soundEffect>();
}
