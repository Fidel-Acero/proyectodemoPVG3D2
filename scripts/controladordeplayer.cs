using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controladordeplayer : MonoBehaviour

{
    //gravedad y velocidad de salto como variables que controlan esas caracteristicas del jugador
    public Vector3 gravity;
    public Vector3 velocidaddesalto;

    //variable boleana para que el jugador no salte infinitas veces
    bool enelsuelo = false;

    Rigidbody rb;

    // Start is called before the first frame update
    void Awake()
    {
        Physics.gravity = gravity;
        rb = GetComponent<Rigidbody>();
    }

    // permite que el jugador salte solo cuando esta en el suelo
    void Update()
    {
        if ( Input.anyKeyDown && enelsuelo){
            rb.velocity = velocidaddesalto;
            enelsuelo = false;
        }
    }
    //
    void OnCollisionEnter(Collision collision)
    {
        enelsuelo = true;
    }

    
}
