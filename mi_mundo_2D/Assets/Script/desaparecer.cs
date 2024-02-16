using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class desaparecer : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Verifica si el objeto que ha colisionado tiene la etiqueta "Enemigo"
        if (other.CompareTag("enemigo"))
        {
         
            Destroy(other.gameObject);

        }
    }
}