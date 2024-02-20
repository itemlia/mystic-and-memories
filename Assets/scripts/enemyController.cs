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
    public ParticleSystem particles;

    public Vector3 scale;

    private void Start()
    {
        player = GameObject.FindWithTag("Player").GetComponent<Transform>();
        particles = GameObject.Find("slashParticles").GetComponent <ParticleSystem>();
        healthBar = GameObject.Find("health bar");
    }

    private void Update()
    {
        // enemy stops when it reaches a certain distance from the player
        if (playerInSight && Vector2.Distance(transform.position, player.position) >= stoppingDist)
        { 
            transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
        }
        hitSequence();
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

    private void hitSequence()
    {
        if (playerInSight && health > 0 && Input.GetKeyDown(KeyCode.E))
        {
            //when e is pressed, player is in range, and health is above zero, allow player to deal damage
           
            health = health - 10;

            //when enemy takes damage, decreases healthbar as well

            healthBar.transform.localScale = healthBar.transform.localScale - scale;

            //plays particle system aniamtion

            particles.Play();
            
        } else if (playerInSight && health <= 0 && Input.GetKeyDown(KeyCode.E))
        {
            //when health reaches zero enemy dies

            Destroy(gameObject);
        }
    }
}
