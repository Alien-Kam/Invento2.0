using System.Collections.Generic;
using UnityEngine;
using Carta;

public class Cambiodeturno : MonoBehaviour
{
    public static Cambiodeturno instance;
    CambiosDeTurno variacion = new CambiosDeTurno();
   
    

     void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }


    void Start()
    {
        Debug.Log("Cambio de Turno");
        StartTurn();
    }


    void StartTurn()
    {
        Debug.Log("Comenzo el cambio de turno");
        variacion.StarTurn();
    }
    public void EndTurn()
    {
        Debug.Log("Se ha acabado el turno");
    }
    void Update()
    {

    }
}
