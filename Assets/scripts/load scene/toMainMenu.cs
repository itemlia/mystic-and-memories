using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class toMainMenu : MonoBehaviour
{
    [SerializeField] private GameObject pauseMenu;
    [SerializeField] private Button mainMenuBtn;
    
    public void loadScene()
    {
        //changes scene
        SceneManager.LoadScene("scenes/titleCard");
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
        
    }
    
    private void Start()
    {
        var btn = mainMenuBtn.GetComponent<Button>();
        btn.onClick.AddListener(loadScene);
        loadScene();
    }
    
}
