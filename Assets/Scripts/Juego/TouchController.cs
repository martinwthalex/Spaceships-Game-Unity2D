using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchController : MonoBehaviour
{

    Rigidbody2D rb;
    int velocidad;
    
    // Start is called before the first frame update
    void Start()
    {
        //Application.targetFrameRate = 30; // limitamos a 30 fps
        rb = GetComponent<Rigidbody2D>();
        velocidad = 8;
        
    }

    // Update is called once per frame
    void Update()
    {
        Touch();
        //Velocidad();
    }
    
    void Touch()
    {
        if(Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if(touch.phase == TouchPhase.Began)
            {
                velocidad = velocidad * -1;
                rb.velocity = new Vector2(0, rb.velocity.y);
                rb.velocity += new Vector2(velocidad, 0);
            }
        }
    }
    //void Velocidad()
    //{
    //    if (GameController.nivel1) velocidad = 8;
    //    else if(GameController.nivel2) velocidad = 10;
    //    else if(GameController.nivel3) velocidad = 15;
    //}
    
}
