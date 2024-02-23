using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;


public class desaparecer : MonoBehaviour
{
public Vector3 positionToInstantine;
public float timeUntilSpawn;

    public Contadorenemigo contadordeenemigo;
    public Contador contador;

 

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Verifica si el objeto que ha colisionado tiene la etiqueta "Enemigo"    contador.IncrementarContador();
        if (other.CompareTag("conseguible"))
        {
            contador.IncrementarContador();  
            Destroy(other.gameObject);
            

        }else if  (other.CompareTag("enemigo"))
                {
                contadordeenemigo.IncrementarContador();
                
                Destroy(gameObject);
                Instantiate(gameObject, positionToInstantine, Quaternion.identity);
        }
    }
}