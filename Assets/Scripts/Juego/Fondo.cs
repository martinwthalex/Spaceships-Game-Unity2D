using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Fondo : MonoBehaviour
{
    public static int velocidad;
    Rigidbody2D rb;
    float posInicial;
    float alturaMin;
    public GameObject fondo2;
    bool fondo2Bajando = false;
    // Start is called before the first frame update
    void Start()
    {
        velocidad = 2;
        rb = GetComponent<Rigidbody2D>();
        posInicial = 14.5f;
        alturaMin = -4.5f;
        fondo2.transform.position = new Vector2(0, posInicial);
    }

    // Update is called once per frame
    void Update()
    {
        MovimientoFondo();
    }
    void MovimientoFondo()
    {
        if(gameObject.transform.position.y > alturaMin)
        {
            rb.velocity = new Vector2(rb.velocity.x, 0);
            rb.velocity -= new Vector2(0, velocidad);
        }
        else
        {
            if(!fondo2Bajando) fondo2.transform.position = new Vector2(0, posInicial);
            MovimientoFondo2();
        }
        
    }
    void MovimientoFondo2()
    {
        fondo2Bajando = true;
        if (fondo2.transform.position.y > alturaMin)
        {
            fondo2.GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, 0);
            fondo2.GetComponent<Rigidbody2D>().velocity -= new Vector2(0, velocidad);
        }
        else
        {
            fondo2Bajando  = false; 
            gameObject.transform.position = new Vector2(0, posInicial);
        }
    }
}
