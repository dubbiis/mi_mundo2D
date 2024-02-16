using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoBucle : MonoBehaviour
{
    public float velocidad = 2f; // Velocidad de movimiento
    public float distanciaDeteccion = 0.1f; // Distancia para detectar el borde de la superficie
    public LayerMask capaSuperficie; // Capa que representa la superficie sobre la que se mover� el objeto
    private bool yendoHaciaDerecha = true; // Indica si el objeto est� movi�ndose hacia la derecha

    void Update()
    {
        // Calcula el desplazamiento basado en la direcci�n actual y la velocidad
        float desplazamiento = velocidad * Time.deltaTime * (yendoHaciaDerecha ? 1 : -1);

        // Mueve el objeto en la direcci�n calculada
        transform.Translate(desplazamiento, 0, 0);

        // Detecta el borde de la superficie
        RaycastHit2D hit = Physics2D.Raycast(transform.position, yendoHaciaDerecha ? Vector2.right : Vector2.left, distanciaDeteccion, capaSuperficie);
        
        // Si se encuentra el borde, cambia la direcci�n
        if (hit.collider != null)
        {
            Debug.Log("Jp");
            yendoHaciaDerecha = !yendoHaciaDerecha;
            // Girar el objeto en el eje Y para reflejar el cambio de direcci�n
            transform.localScale = new Vector3(transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);
        }
    }
}
