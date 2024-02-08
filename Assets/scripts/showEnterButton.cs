using System.Collections;
using System.Collections.Generic;
//ing System.Diagnostics;
using Unity.VisualScripting;
using UnityEditor.Presets;
using UnityEngine;



public class showEnterButton : MonoBehaviour
{
    public GameObject buttonManager;
    [SerializeField] private float distance;

    private void Update()
    {
        int layer = 2;
        int mask = 1 << layer;
        mask = ~mask; 
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, distance, mask);
        if (hit.transform != null)
        {
            testCoroutine();

            hideAfterSeconds();
            
        }

        IEnumerator hideAfterSeconds()
        {
            if (hit.transform.CompareTag("Player")) //when player gets near house enter button shows up
            {

                buttonManager.SetActive(true);

                yield return new WaitForSeconds(100000000);

                buttonManager.SetActive(false);
            }
            
        }

        IEnumerator testCoroutine()
        {
            Debug.Log("started coroutine at: " + Time.time);

            yield return new WaitForSeconds(5);

            Debug.Log("ended coroutine at:" + Time.time);
        }
    }

}
