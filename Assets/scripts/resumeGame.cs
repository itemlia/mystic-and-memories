using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class resumeGame : MonoBehaviour
{
    [SerializeField] private GameObject pauseMenu;
    [SerializeField] private Button resumeBtn;
    public void resume()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
    }
    
    private void Start()
    {
        var btn = resumeBtn.GetComponent<Button>();
        btn.onClick.AddListener(resume);
        resume();
    }
}
