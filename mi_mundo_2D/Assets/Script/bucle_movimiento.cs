using UnityEngine;

public class MovimientoConParedes : MonoBehaviour
{
    public float velocidad = 2f; // Velocidad de movimiento
    public float distanciaDeteccion = 0.1f; // Distancia para detectar la pared
    private bool yendoHaciaDerecha = true; // Indica si el objeto est� movi�ndose hacia la derecha

    private void Update()
    {
        // Calcula el desplazamiento basado en la direcci�n actual y la velocidad
        float desplazamiento = velocidad * Time.deltaTime * (yendoHaciaDerecha ? 1 : -1);

        // Mueve el objeto en la direcci�n calculada
        transform.Translate(desplazamiento, 0, 0);

        // Detecta la pared
        RaycastHit2D hit = Physics2D.Raycast(transform.position, yendoHaciaDerecha ? Vector2.right : Vector2.left, distanciaDeteccion);

        // Si se encuentra una pared, cambia la direcci�n
        if (hit.collider != null && hit.collider.CompareTag("GameController"))
        {
            yendoHaciaDerecha = !yendoHaciaDerecha;
            // Girar el objeto en el eje Y para reflejar el cambio de direcci�n
            transform.localScale = new Vector3(transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);
        }
    }
}
