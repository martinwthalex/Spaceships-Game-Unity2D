using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    public static int puntos;
    public GameObject botonReiniciar;
    public static bool jugadorParado = false;
    // Start is called before the first frame update
    void Start()
    {
        puntos = 0;
        botonReiniciar.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemigo"))
        {
            Time.timeScale = 0;
            GameController.PausarAudio();
            gameObject.SetActive(false);
            botonReiniciar.SetActive(true);
        }

    }
    public static void SetJugadorParado(bool a)
    {
        if(a) jugadorParado = true;
        else jugadorParado = false;
    }
}
