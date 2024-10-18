using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemigo : MonoBehaviour
{
    public float timer;
    Vector3 spawnPos;
    float x, y,z = 0;
    public GameObject prefabEnemigo, jugador;
    float rango = 0.9f;
    
    
    // Start is called before the first frame update
    void Start()
    {
        timer = 1.5f;
        
    }

    // Update is called once per frame
    void Update()
    {
        Spawn();
    }

    void Spawn()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            if(!Jugador.jugadorParado) x = Random.Range(-3f + rango, 3f - rango);
            else
            {
                int dado = Random.Range(1, 3);
                if(dado == 1) x = jugador.transform.position.x;
                else x = Random.Range(-3f + rango, 3f - rango);
                Jugador.SetJugadorParado(false);
            } 
            y = 6f;
            spawnPos = new Vector3(x, y, 0);
            Quaternion rotacion = new Quaternion(0, 0, z, 0);
            Instantiate(prefabEnemigo, spawnPos, rotacion);
            
            if(GameController.nivel1)
            {
                timer = 1.1f;
            }
            else if(GameController.nivel2)
            {
                timer = 0.8f;
                //Fondo.velocidad = 4;
                MovimientoEnemigo.velocidad = 16;
            }
            else
            {
                timer = 0.4f;
                //Fondo.velocidad = 8;
                MovimientoEnemigo.velocidad = 25;
            }
        }
    }
}
