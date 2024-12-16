using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController2D : MonoBehaviour
{
    //Referencias generales
    [SerializeField] Rigidbody2D playerRb;
    [SerializeField] Animator playerAnim;
    [SerializeField] PlayerInput playerInput;
    Vector2 moveInput;

    [Header("Movement Stats")]
    public float speed;
    [SerializeField] bool isFacingRight = true;

    [Header("Jump Stats")]
    public float jumpForce;
    [SerializeField] bool isGrounded;
    [SerializeField] GameObject groundCheck;
    [SerializeField] float groundCheckRadius = 0.1f;
    [SerializeField] LayerMask groundLayer;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
        playerAnim = GetComponent<Animator>();
        playerInput = GetComponent<PlayerInput>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        
    }

    void HandleAnimations()
    {

    }

    #region Input Methods
    public void HandleMovement(InputAction.CallbackContext context)
    {

    }
    public void HandleJump(InputAction.CallbackContext context)
    {

    }

    #endregion
}
