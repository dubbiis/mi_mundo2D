using System.Collections;
using System.Collections.Generic;
using UnityEngine;





public class Camara : MonoBehaviour
{
    public Transform target; // El objeto que la cámara seguirá
    public float smoothSpeed = 0.125f; // La velocidad a la que la cámara se moverá para seguir al objetivo

    void FixedUpdate()
    {
        if (target != null) // Comprobamos si el objetivo está definido
        {
            // Obtenemos la posición actual de la cámara
            Vector3 desiredPosition = target.position;

            // Mantenemos la misma posición en el eje Z para que la cámara no se acerque ni se aleje del objetivo
            desiredPosition.z = transform.position.z;

            // Movemos suavemente la cámara hacia la posición deseada usando Lerp
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

            // Actualizamos la posición de la cámara
            transform.position = smoothedPosition;
        }
    }
}