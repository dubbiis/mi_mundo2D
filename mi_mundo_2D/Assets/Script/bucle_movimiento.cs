using UnityEngine;

public class MovimientoConParedes : MonoBehaviour
{
    public float velocidad = 2f; // Velocidad de movimiento
    public float distanciaDeteccion = 0.1f; // Distancia para detectar la pared
    private bool yendoHaciaDerecha = true; // Indica si el objeto está moviéndose hacia la derecha

    private void Update()
    {
        // Calcula el desplazamiento basado en la dirección actual y la velocidad
        float desplazamiento = velocidad * Time.deltaTime * (yendoHaciaDerecha ? 1 : -1);

        // Mueve el objeto en la dirección calculada
        transform.Translate(desplazamiento, 0, 0);

        // Detecta la pared
        RaycastHit2D hit = Physics2D.Raycast(transform.position, yendoHaciaDerecha ? Vector2.right : Vector2.left, distanciaDeteccion);

        // Si se encuentra una pared, cambia la dirección
        if (hit.collider != null && hit.collider.CompareTag("GameController"))
        {
            yendoHaciaDerecha = !yendoHaciaDerecha;
            // Girar el objeto en el eje Y para reflejar el cambio de dirección
            transform.localScale = new Vector3(transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);
        }
    }
}
