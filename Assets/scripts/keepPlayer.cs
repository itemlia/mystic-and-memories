using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class keepPlayer : MonoBehaviour
{

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);

    }
}
