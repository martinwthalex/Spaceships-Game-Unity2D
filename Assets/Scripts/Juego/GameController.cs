using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    //bool pausa;
    public GameObject menuPausa;
    public static AudioSource AudioSource;
    public static bool nivel1 = false, nivel2 = false, nivel3 = false;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        //pausa = false;
        menuPausa.SetActive(false);
        AudioSource = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        NivelDeDificultad();
    }

    public void ReiniciarJuego()
    {
        SceneManager.LoadScene("Juego");
    }
    public void PausarJuego()
    {
        //if (!pausa)
        //{
        //    Time.timeScale = 0;
        //    pausa = true;
        //}
        //else if (pausa)
        //{
        //    Time.timeScale = 1;
        //    pausa = false;
        //}
        Time.timeScale = 0;
        PausarAudio();
        menuPausa.SetActive(true);
        
    }
    public void Reanudar()
    {
        Time.timeScale = 1;
        ResumeAudio();
        menuPausa.SetActive(false);
    }
    public static void PausarAudio()
    {
        AudioSource.Pause();
    }
    public static void ResumeAudio()
    {
        AudioSource.Play();
    }
    public void VolverAlMenu()
    {
        PausarAudio();
        SceneManager.LoadScene("Inicio");
    }
    void NivelDeDificultad()
    {
        if (Jugador.puntos < 20)
        {
            nivel1 = true;
        }
        else if(Jugador.puntos >= 20 && Jugador.puntos < 50)
        {
            nivel2 = true;
            nivel1 = false;
        }
        else
        {
            nivel3 = true;
            nivel2 = false;
        }
    }
}
