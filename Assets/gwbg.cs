using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gwbg : MonoBehaviour
{
    [SerializeField] private Button buttn;

    public void weare()
    {
        Application.Quit();
    }
    
    private void Start()
    {
        var btn = buttn.GetComponent<Button>();
        btn.onClick.AddListener(weare);
        weare();
    }
}
