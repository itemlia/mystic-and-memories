using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class showItemInfo : MonoBehaviour
{

    public GameObject itemInfo;
    public Button button;

    private void showInfo()
    {
        itemInfo.SetActive(true);
    }

    public void Start()
    {
        var btn = button.GetComponent<Button>();
        btn.onClick.AddListener(showInfo);
    }
}
    
