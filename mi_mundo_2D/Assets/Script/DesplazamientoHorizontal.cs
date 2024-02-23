using UnityEngine;

public class DesplazamientoHorizontal : MonoBehaviour
{
    public float velocidad = 5f; // Velocidad de desplazamiento
    public float distancia = 10f; // Distancia total a recorrer
    private float direccion = 1f; // Direcci�n del movimiento

    private float puntoInicial; // Punto inicial del desplazamiento

    void Start()
    {
        puntoInicial = transform.position.x; // Guardar la posici�n inicial en x
    }

    void Update()
    {
        // Mover el objeto en la direcci�n y velocidad especificadas
        transform.Translate(Vector2.right * direccion * velocidad * Time.deltaTime);

        // Si el objeto ha recorrido la distancia completa, cambiar direcci�n
        if (Mathf.Abs(transform.position.x - puntoInicial) >= distancia / 2)
        {
            direccion *= -1; // Invertir la direcci�n
        }
    }
}
