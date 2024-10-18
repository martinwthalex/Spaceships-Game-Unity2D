using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoEnemigo : MonoBehaviour
{
    Rigidbody2D rb;
    public static int velocidad;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        velocidad = 8;
    }

    // Update is called once per frame
    void Update()
    {
        Movimiento();
    }
    void Movimiento()
    {
        rb.velocity = new Vector2(rb.velocity.x, 0);
        rb.velocity -= new Vector2(0, velocidad);
    }
}
