using System.Collections;
using System.Collections.Generic;
using UnityEngine;





public class Camara : MonoBehaviour
{
    public Transform target; // El objeto que la c�mara seguir�
    public float smoothSpeed = 0.125f; // La velocidad a la que la c�mara se mover� para seguir al objetivo

    void FixedUpdate()
    {
        if (target != null) // Comprobamos si el objetivo est� definido
        {
            // Obtenemos la posici�n actual de la c�mara
            Vector3 desiredPosition = target.position;

            // Mantenemos la misma posici�n en el eje Z para que la c�mara no se acerque ni se aleje del objetivo
            desiredPosition.z = transform.position.z;

            // Movemos suavemente la c�mara hacia la posici�n deseada usando Lerp
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

            // Actualizamos la posici�n de la c�mara
            transform.position = smoothedPosition;
        }
    }
}