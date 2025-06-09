
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class pause : MonoBehaviour
{
    [SerializeField] private GameObject pauseMenu;
    [SerializeField] private Button pauseButton;

    // public void pauseGame()
    // {
    //     pauseMenu.SetActive(true);
    //     Time.timeScale = 0;
    // }
    // private void Start()
    // {
    //     var btn = pauseButton.GetComponent<Button>();
    //     btn.onClick.AddListener(pauseGame);
    //     pauseGame();
    // }

    private void OnMouseDown()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0;
    }
}
