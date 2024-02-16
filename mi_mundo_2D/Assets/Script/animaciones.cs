using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationController : MonoBehaviour
{
    Animator animator; // Referencia al componente Animator del personaje
    Rigidbody2D rb; // Referencia al componente Rigidbody2D del personaje
    bool isGrounded; // Indica si el personaje está en el suelo
    bool hasDoubleJumped; // Indica si el personaje ha realizado un doble salto

    void Start()
    {
        animator = GetComponent<Animator>(); // Obtener el componente Animator
        rb = GetComponent<Rigidbody2D>(); // Obtener el componente Rigidbody2D
    }

    void Update()
    {
        // Verificar si el personaje está en el suelo
        isGrounded = Physics2D.Raycast(transform.position, Vector2.down, 0.1f);

        // Actualizar las variables de la animación
        animator.SetBool("isGrounded", isGrounded);
        animator.SetFloat("verticalSpeed", rb.velocity.y);

        // Cambiar la animación de acuerdo al estado del personaje
        if (isGrounded)
        {
            if (Mathf.Abs(rb.velocity.x) > 0.1f)
            {
                // Si el personaje se está moviendo, reproducir la animación de caminar
                animator.SetBool("pj_quieto", true);
            }
            else
            {
                // Si el personaje está quieto, reproducir la animación de estar quieto
                animator.SetBool("pj_quieto", false);
            }

            // Restablecer la variable de doble salto
            hasDoubleJumped = false;
        }
        else
        {
            // Si el personaje está en el aire, reproducir la animación de saltar
            animator.SetBool("pj_quieto", false);
            animator.SetBool("saltar", true);

            // Verificar si el personaje ha realizado un doble salto
            if (!hasDoubleJumped && rb.velocity.y < -0.1f)
            {
                // Si el personaje ha caído después de un doble salto, reproducir la animación de doble salto
                animator.SetBool("saltar", false);
                animator.SetBool("doblesalto", true);
            }
        }
    }

    // Método para activar el doble salto
    public void ActivateDoubleJump()
    {
        hasDoubleJumped = true;
    }
}
