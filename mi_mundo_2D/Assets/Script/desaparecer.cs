using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class desaparecer : MonoBehaviour
{
    public Contador contador;
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Verifica si el objeto que ha colisionado tiene la etiqueta "Enemigo"    contador.IncrementarContador();
        if (other.CompareTag("conseguible"))
        {
         
            Destroy(other.gameObject);

        }else if  (other.CompareTag("enemigo"))
                {
            Destroy(other.gameObject);
        }
    }
}