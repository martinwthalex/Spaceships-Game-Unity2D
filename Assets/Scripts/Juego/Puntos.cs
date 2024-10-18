using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Puntos : MonoBehaviour
{
    public TMP_Text textoPuntos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ActualizarTextos();
    }

    void ActualizarTextos()
    {
        textoPuntos.text = Jugador.puntos.ToString();
    }
}
