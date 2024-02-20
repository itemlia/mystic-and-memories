using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;

public class characterController : MonoBehaviour
{
    [SerializeField] private float speed;

    private Rigidbody2D rBody;
    private Animator anim;
    private BoxCollider2D boxCollider;



    private void Awake()
    {
        rBody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        boxCollider = GetComponent<BoxCollider2D>();
    }

    private void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        rBody.velocity = new Vector2(horizontalInput, verticalInput) * speed; //gets the velcity character is goimh


        //plays diff animation depending on what the playerTrans is doing or which way theyre moving

        if (Input.GetKey(KeyCode.W))
        {
            anim.Play("moveBack");
        }
        else if (Input.GetKey(KeyCode.S))
        {
            anim.Play("moveForw");
        }
        else if (Input.GetKey(KeyCode.D))
        {
            anim.Play("moveRight");
        }
        else if (Input.GetKey(KeyCode.A))
        {
            anim.Play("moveLeft");
        }
        else if (Input.GetKey(KeyCode.E))
        {
            anim.Play("fightForward");
        }
        else
        {
            anim.Play("idleAnim");
        }
    }
}
