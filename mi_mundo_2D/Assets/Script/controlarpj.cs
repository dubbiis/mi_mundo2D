using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlarpj : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    public float jumpForce;
    Rigidbody2D rigidBody;
    private float inputMovement;
    public bool isLookingRight = true;
    private bool isGrounded;
    private bool doubleJumped = false;

    PlayerAnimationController animationController; // Referencia al script de control de animaciones

     

    private void Start()
    {
        // Obtener la referencia al script de control de animaciones
        animationController = GetComponent<PlayerAnimationController>();
        rigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        ProcessingMovement();
        Jump();
    }

    void CharacterOrientation(float inputMovement)
    {
        if ((isLookingRight && inputMovement < 0) || (!isLookingRight && inputMovement > 0))
        {
            isLookingRight = !isLookingRight;
            transform.localScale = new Vector2(-transform.localScale.x, transform.localScale.y);
        }
    }

    void ProcessingMovement()
    {
        inputMovement = Input.GetAxis("Horizontal");
        rigidBody.velocity = new Vector2(inputMovement * speed, rigidBody.velocity.y);
        CharacterOrientation(inputMovement);
    }

    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isGrounded)
            {
                rigidBody.velocity = new Vector2(rigidBody.velocity.x, jumpForce);
                isGrounded = false;
                doubleJumped = false; // Resetea el estado de doble salto
            }
            else if (!doubleJumped)
            {
                animationController.ActivateDoubleJump();
                rigidBody.velocity = new Vector2(rigidBody.velocity.x, jumpForce);
                doubleJumped = true; // Marca que se ha realizado un doble salto
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("GameController"))
        {
            isGrounded = true;
            doubleJumped = false; // Resetea el estado de doble salto cuando toca el suelo
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("GameController"))
        {
            isGrounded = false;
        }
    }}