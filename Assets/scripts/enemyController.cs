using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build;
using UnityEngine;
using UnityEngine.Rendering;

public class enemyController : MonoBehaviour
{
    private Transform player;

    public float speed;
    public float stoppingDist;
    public bool playerInSight;
    public int health = 100;

    public GameObject healthBar;

    public Vector3 scale;

    private void Start()
    {
        player = GameObject.FindWithTag("Player").GetComponent<Transform>();
        healthBar = GameObject.Find("health bar");
    }

    private void Update()
    {
     
        if (playerInSight && Vector2.Distance(transform.position, player.position) >= stoppingDist)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
        }
        decreaseHealth();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerInSight = true;

        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerInSight = false;
        }
    }

    private void decreaseHealth()
    {
        if (playerInSight && health > 0 && Input.GetKeyDown(KeyCode.E))
        {
            

            health = health - 10;
            healthBar.transform.localScale = healthBar.transform.localScale - scale;
            
        } else if (playerInSight && health <= 0 && Input.GetKeyDown(KeyCode.E))
        {
            Destroy(gameObject);
        }
    }
}
