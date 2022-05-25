using UnityEngine;

[RequireComponent(typeof(Rigidbody2D)), RequireComponent(typeof(SpriteRenderer)), RequireComponent(typeof(Animator))]
public class PlayerController : MonoBehaviour
{
    [Header("Movement Configuration")]

    [SerializeField, Range(0, 50), Tooltip("Player velocity modifier")]

    private float velocityModifier = 10;

    [SerializeField, Range(500, 5000)]
    private float jumpForce = 1000;

    [Header("Ground Detection")]
    [SerializeField]
    private LayerMask groundMask;
    [SerializeField]
    private Transform groundCheck;

    [SerializeField, Range(0.01f, 10)]
    private float groundRadius = 0.3f;

    private Rigidbody2D _rb;
    private SpriteRenderer _sr;
    private Animator _animator;

    private bool _isGrounded;
    private static readonly int Speed = Animator.StringToHash("Speed");
    private static readonly int IsJumping = Animator.StringToHash("isJumping");

    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _sr = GetComponent<SpriteRenderer>();
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        _isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundRadius, groundMask);

        var horizontalAxis = Input.GetAxis("Horizontal");
        var isJumping = Input.GetButtonDown("Jump");
        
        HandleWalk(horizontalAxis);
        HandleJump(isJumping);
    }

    private void HandleJump(bool isJumping)
    {
        if (isJumping && _isGrounded)
        {
            _rb.velocity = new Vector2(_rb.velocity.x, 0);
            _rb.AddForce(new Vector2(0f, jumpForce));
        }
        _animator.SetBool(IsJumping, _isGrounded);
    }

    private void HandleWalk(float horizontalAxis)
    {
        if (horizontalAxis < 0)
        {
            _sr.flipX = true;
        }
        else if (horizontalAxis > 0)
        {
            _sr.flipX = false;
        }

        _rb.velocity = new Vector2(horizontalAxis * velocityModifier, _rb.velocity.y);
        _animator.SetFloat(Speed, Mathf.Abs(horizontalAxis));
    }
}
