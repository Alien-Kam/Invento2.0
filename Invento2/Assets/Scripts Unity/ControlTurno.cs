using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Carta;

public class ControlTurno : MonoBehaviour
{

    CambiosDeTurno cambiosDeTurno = new CambiosDeTurno();
    public static ControlTurno instancia = new ControlTurno();
    // Start is called before the first frame update
    void Start()
    {
        StartTurn();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void StartTurn()
    {
        Debug.Log(cambiosDeTurno.GetCurrent().nombreplayer);
    }
    public void EndTurn()
    {
        cambiosDeTurno.EndTurn();
        StartTurn();
    }
}
