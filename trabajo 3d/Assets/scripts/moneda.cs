using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class moneda : MonoBehaviour
{
    public float factordemovimiento = -1;
    public Vector3 Gamevelocity;
    
    public GameObject player;

    Rigidbody rb;

    
   
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = Gamevelocity * factordemovimiento;
    }

    void OnTriggerExit(Collider areadejuego)
    {
        transform.position += Vector3.right *(areadejuego.bounds.size.x + GetComponent<BoxCollider>().size.x);

    }
    void OnTreggerEnter(Collision Player)
    {
        
            Destroy(gameObject);
        

    }
}