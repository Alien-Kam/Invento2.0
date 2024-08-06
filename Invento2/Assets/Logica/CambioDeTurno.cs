using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Carta;

public class CambiosDeTurno
{
    public int current = 0;
    public bool hasmovid = false;
    public bool liderefect = false;
    public bool pasar = false;
    public List<Jugador> jugadores = new List<Jugador>(2);
   
    void AddList(Jugador player)
    {
        jugadores.Add(player);
    }
    public void StarTurn()
    {
         
        if (hasmovid || liderefect || pasar)
        {
            EndTurn();
        }
    }
    public void EndTurn()
    {
        current = (current + 1) % jugadores.Count;
        StarTurn();
    }

}
