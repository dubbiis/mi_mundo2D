using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimiento : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public float moveSpeed = 10f;//velocidad de movimiento
    public float turnSpeed = 50f;//velocidad girado


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.S))
            transform.Translate(-Vector3.forward * moveSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.A))
            transform.Rotate(Vector3.up, -turnSpeed *  Time.deltaTime);
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.D))
            transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);
    }
}
