using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class menugameover : MonoBehaviour
{

    
   public void reiniciar()
   {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
   }

    public void menuinicial()
   {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
   }
}
