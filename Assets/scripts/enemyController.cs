using UnityEngine;
using UnityEngine.SceneManagement;

public class enemyController : MonoBehaviour
{
    private Transform playerTrans;
    private GameObject playerCanvas;
    

    public float speed;
    public float stoppingDist;
    public bool playerInSight;
    public int health = 100;

    private GameObject healthBar;
    public ParticleSystem hitParticles;
    public ParticleSystem enemyParticles;

    public Vector3 scale;

    private void Start()
    {
       
        playerTrans = GameObject.FindWithTag("Player").GetComponent<Transform>();
        playerCanvas = GameObject.Find("empty player canvas");
        hitParticles = GameObject.Find("slashParticles").GetComponent<ParticleSystem>();
        enemyParticles = GameObject.Find("enemyParticles").GetComponent<ParticleSystem>();
        healthBar = GameObject.Find("health bar");
    }

    private void Update()
    {
        //sets death particle system to be where enemy is
        enemyParticles.transform.position = gameObject.transform.position;

        // enemy stops when it reaches a certain distance from the playerTrans
        if (playerInSight && Vector2.Distance(transform.position, playerTrans.position) >= stoppingDist)
        {
            transform.position = Vector2.MoveTowards(transform.position, playerTrans.position, speed * Time.deltaTime);
            enemyParticles.Play();
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

            hitParticles.Play();

        }
        else if (playerInSight && health <= 0 && Input.GetKeyDown(KeyCode.E))
        {
           
            //when health reaches zero enemy dies

            Destroy(gameObject);
            playerCanvas.SetActive(false);
            SceneManager.LoadScene("endScene");


        }
    }
}






