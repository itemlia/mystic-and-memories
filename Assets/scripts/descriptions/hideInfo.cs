using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hideInfo : MonoBehaviour
{
    public GameObject itemInfo;
    public Button button;

    private void quitInfo()
    {
        itemInfo.SetActive(false);
    }

    public void Start()
    {
        var btn = button.GetComponent<Button>();
        btn.onClick.AddListener(quitInfo);
    }
}
