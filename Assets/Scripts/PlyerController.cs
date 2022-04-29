using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlyerController : MonoBehaviour
{
    public float speed = 1f;
    public float jump = 0.4f;
    public Rigidbody2D rb;
    public Vector2 moveVector;
    public Animator animator;

    private bool isGrounded;
    private float groundRadius = 0.3f;

    public Transform groundCheck;
    public LayerMask groundMask;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    private void Update()
    {
        walk();
        
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundRadius, groundMask);


        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            rb.AddForce(new Vector2(0f, jump));
        }
        animator.SetBool("isJumping", isGrounded);


        if (Input.GetAxis("Horizontal") < 0)
        {
            GetComponent<SpriteRenderer>().flipX = true;
        }
        if (Input.GetAxis("Horizontal") > 0)
        {
            GetComponent<SpriteRenderer>().flipX = false;
        }

    }

    void walk()
    {
        moveVector.x = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveVector.x * speed, rb.velocity.y);
        animator.SetFloat("Speed", Mathf.Abs(moveVector.x));

    }
}
