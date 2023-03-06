using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class endlesscroll : MonoBehaviour
{
    public float factordemovimiento = -1;
    public Vector3 Gamevelocity;
    public GameObject menumuerte;
    public GameObject player;

    Rigidbody rb;

    
   
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = Gamevelocity * factordemovimiento;
        Time.timeScale = 1;
    }

    void OnTriggerExit(Collider areadejuego)
    {
        transform.position += Vector3.right *(areadejuego.bounds.size.x + GetComponent<BoxCollider>().size.x);

    }
    void OnCollisionEnter(Collision other)
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        menumuerte.SetActive(true);
        player.SetActive(false);
        Time.timeScale = 0;
    }
}
