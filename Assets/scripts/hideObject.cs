using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hideObject : MonoBehaviour
{
    public void Start()
    {
        gameObject.SetActive(false); //hides object at start of scene
    }
}
