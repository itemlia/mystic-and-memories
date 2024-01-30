using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class loadMageHouse : MonoBehaviour
{
    public Button enter;
    public GameObject player;

    public void loadHouse()
    {
        SceneManager.LoadScene("scenes/mageHouse");
        player.transform.position = new Vector3(-0.07999991f, -9.081256f, 0f);
    }

    public void Start()
    {
        var btn = enter.GetComponent<Button>();
        btn.onClick.AddListener(loadHouse);
    }
}
