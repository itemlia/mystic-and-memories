using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using static audioManager.soundEffect;

public class loadInsideHouse : MonoBehaviour
{

    public Button enter;
    public GameObject player;

    public AudioSource sound;


    public void loadHouse()
    { //changes scene and starts player at a specific postion
        SceneManager.LoadScene("scenes/insideHouse");
        player.transform.position = new Vector3(0.1314539f, -9.746695f, 0f);
        sound = GameObject.Find("soundManager").GetComponent<AudioSource>();

        sound.Play();
        
    }
    
    public void Start()
    {
        player = GameObject.FindWithTag("Player");
       
        
        var btn = enter.GetComponent<Button>();
        btn.onClick.AddListener(loadHouse);
    }


}
