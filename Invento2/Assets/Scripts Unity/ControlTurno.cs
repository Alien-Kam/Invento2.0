using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Carta;

public class ControlTurno : MonoBehaviour
{
    public List<Players> jugadores;
    CambiosDeTurno cambiosDeTurno = new CambiosDeTurno();
    public static ControlTurno instancia;

    void Awake()
    {
        if (instancia == null)
        {
            instancia = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < jugadores.Count; i++)
        {
            Jugador player = new Jugador(jugadores[i].playerName, jugadores[i].playerIndex, jugadores[i].faccion);
            cambiosDeTurno.jugadores.Add(player); 
        }
        StartTurn();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void StartTurn()
    {
        Debug.Log($" Es el turno del jugador {cambiosDeTurno.GetCurrent().nombreplayer}");
    }
    public void EndTurn()
    {
        cambiosDeTurno.EndTurn();
        StartTurn();
    }
}
