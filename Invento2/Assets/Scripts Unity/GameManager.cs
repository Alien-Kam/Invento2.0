using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Carta;
public class GameManager : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        ControlTurno.instancia.StartTurn();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
