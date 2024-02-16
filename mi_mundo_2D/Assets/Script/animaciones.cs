using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationController : MonoBehaviour
{
    Animator animator; // Referencia al componente Animator del personaje
    Rigidbody2D rb; // Referencia al componente Rigidbody2D del personaje
    bool isGrounded; // Indica si el personaje est� en el suelo
    bool hasDoubleJumped; // Indica si el personaje ha realizado un doble salto

    void Start()
    {
        animator = GetComponent<Animator>(); // Obtener el componente Animator
        rb = GetComponent<Rigidbody2D>(); // Obtener el componente Rigidbody2D
    }

    void Update()
    {
        // Verificar si el personaje est� en el suelo
        isGrounded = Physics2D.Raycast(transform.position, Vector2.down, 0.1f);

        // Actualizar las variables de la animaci�n
        animator.SetBool("isGrounded", isGrounded);
        animator.SetFloat("verticalSpeed", rb.velocity.y);

        // Cambiar la animaci�n de acuerdo al estado del personaje
        if (isGrounded)
        {
            if (Mathf.Abs(rb.velocity.x) > 0.1f)
            {
                // Si el personaje se est� moviendo, reproducir la animaci�n de caminar
                animator.SetBool("pj_quieto", true);
            }
            else
            {
                // Si el personaje est� quieto, reproducir la animaci�n de estar quieto
                animator.SetBool("pj_quieto", false);
            }

            // Restablecer la variable de doble salto
            hasDoubleJumped = false;
        }
        else
        {
            // Si el personaje est� en el aire, reproducir la animaci�n de saltar
            animator.SetBool("pj_quieto", false);
            animator.SetBool("saltar", true);

            // Verificar si el personaje ha realizado un doble salto
            if (!hasDoubleJumped && rb.velocity.y < -0.1f)
            {
                // Si el personaje ha ca�do despu�s de un doble salto, reproducir la animaci�n de doble salto
                animator.SetBool("saltar", false);
                animator.SetBool("doblesalto", true);
            }
        }
    }

    // M�todo para activar el doble salto
    public void ActivateDoubleJump()
    {
        hasDoubleJumped = true;
    }
}
