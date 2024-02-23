using UnityEngine;

public class DesplazamientoHorizontal : MonoBehaviour
{
    public float velocidad = 5f; // Velocidad de desplazamiento
    public float distancia = 10f; // Distancia total a recorrer
    private float direccion = 1f; // Dirección del movimiento

    private float puntoInicial; // Punto inicial del desplazamiento

    void Start()
    {
        puntoInicial = transform.position.x; // Guardar la posición inicial en x
    }

    void Update()
    {
        // Mover el objeto en la dirección y velocidad especificadas
        transform.Translate(Vector2.right * direccion * velocidad * Time.deltaTime);

        // Si el objeto ha recorrido la distancia completa, cambiar dirección
        if (Mathf.Abs(transform.position.x - puntoInicial) >= distancia / 2)
        {
            direccion *= -1; // Invertir la dirección
        }
    }
}
