using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Contador : MonoBehaviour
{
    public Text textoContador;
    private int contador = 0;

    void Start()
    {
        ActualizarTextoContador();
    }

    public void IncrementarContador()
    {
        contador++;
        ActualizarTextoContador();
    }

    void ActualizarTextoContador()
    {
        textoContador.text = "Contador Platanero: " + contador.ToString();
    }
}
