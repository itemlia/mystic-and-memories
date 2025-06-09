using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class endGame : MonoBehaviour
{
    [SerializeField] private Button endGameBtn;

    public void Quit()
    {
        Application.Quit();
    }
    
    private void Start()
    {
        var btn = endGameBtn.GetComponent<Button>();
        btn.onClick.AddListener(Quit);
        Quit();
    }
}
