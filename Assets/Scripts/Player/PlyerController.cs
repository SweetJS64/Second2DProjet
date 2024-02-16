using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D)), RequireComponent(typeof(SpriteRenderer)), RequireComponent(typeof(Animator))]
public class PlyerController : MonoBehaviour
{
    [Header("Movement Configuration")]

    [SerializeField]
    private MovementConfiguration movementConfiguration;

    [Header("Ground Detection")]
    [SerializeField]
    private LayerMask groundMask;
    [SerializeField]
    private Transform groundCheck;

    [SerializeField, Range(0.01f, 10)]
    private float groundRadius = 0.3f;

    private Rigidbody2D rb;
    private SpriteRenderer sr;
    private Animator animator;

    private bool isGrounded;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundRadius, groundMask);

        var horizontalAxis = Input.GetAxis("Horizontal");
        var isJumping = Input.GetButtonDown("Jump");
        
        HandleWalk(horizontalAxis);
        HandleJump(isJumping);
    }

    private void HandleJump(bool isJumping)
    {
        if (isJumping && isGrounded)
        {
            rb.AddForce(new Vector2(0f, movementConfiguration.jumpForce));
        }
        animator.SetBool("isJumping", isGrounded);
    }

    private void HandleWalk(float horizontalAxis)
    {
        if (horizontalAxis < 0)
        {
            sr.flipX = true;
        }
        else if (horizontalAxis > 0)
        {
            sr.flipX = false;
        }
        
        rb.velocity = new Vector2(horizontalAxis * movementConfiguration.velocityModifier, rb.velocity.y);
        animator.SetFloat("Speed", Mathf.Abs(horizontalAxis));
    }
}
