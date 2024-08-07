using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Carta
{
    public class CambiosDeTurno
    {
        public int current = 0;
        public static bool hasmovid = false;
        public bool liderefect = false;
        public bool pasar = false;
        public List<Jugador> jugadores = new List<Jugador>(2);
        public static CambiosDeTurno inns = new CambiosDeTurno();
       
        public Jugador GetCurrent()
        {  
            Debug.Log(current);
            return jugadores[current];
        }
        public void EndTurn()  
        {
            hasmovid = false;
            current = (current + 1) % jugadores.Count;
        }
    }
}

