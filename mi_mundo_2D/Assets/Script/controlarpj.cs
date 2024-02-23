using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class controlarpj : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    public float jumpForce;
    Rigidbody2D rigidBody;
    private float inputMovement;
    public bool isLookingRight = true;
    public bool isGrounded;
    private bool doubleJumped = false;
    private AudioSource audiosource;
    public AudioClip jumClip;
    public AudioClip coin;

    Animator animator;
     

    private void Start()
    {
        // Obtener la referencia al script de control de animaciones
        rigidBody = GetComponent<Rigidbody2D>();
        audiosource = GetComponent<AudioSource>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        ProcessingMovement();
        Jump();
        animator.SetBool("isGrounded", isGrounded);
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
                //sonido
                audiosource.PlayOneShot(jumClip);

                

            }
            else if (!doubleJumped)
            {
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