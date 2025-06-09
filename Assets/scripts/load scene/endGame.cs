using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class endGame : MonoBehaviour
{
    [SerializeField] private Button quitBtn;
    
    public void quit()
    {
        Application.Quit();
    }
    
    private void Start()
    {
        var btn = quitBtn.GetComponent<Button>();
        btn.onClick.AddListener(quit);
        quit();
    }
}
