using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Contadorenemigo : MonoBehaviour
{
    public TMP_Text textoContadorenemigo;
    public int contadordeenemigo = 3;

    void Update()
    {
        ActualizarTextoContador();

    }

    public void IncrementarContador()
    {
        contadordeenemigo--;
        ActualizarTextoContador();
    }

    void ActualizarTextoContador()
    {
        textoContadorenemigo.text = "Muertes: " + contadordeenemigo.ToString();
    }
}
