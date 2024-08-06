using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

namespace Funcion
{

  public class Funciones :MonoBehaviour 
  {
    public void Jugar()
    {
      SceneManager.LoadScene(2);
      
    }
    public void Salir()
    {
      Application.Quit();
    }
  } 
}