using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Contador : MonoBehaviour
{
    public TMP_Text textoContador;
    public int contador = 0;

    void Update()
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
