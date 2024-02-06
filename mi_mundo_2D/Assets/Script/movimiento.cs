using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public float velocidad = 5.0f;

    void Update()
    {
        // Movimiento hacia adelante con la tecla W
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * velocidad * Time.deltaTime);
        }

        // Movimiento hacia atrás con la tecla S
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * velocidad * Time.deltaTime);
        }

        // Movimiento hacia la izquierda con la tecla A
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * velocidad * Time.deltaTime);
        }

        // Movimiento hacia la derecha con la tecla D
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * velocidad * Time.deltaTime);
        }
    }
}
