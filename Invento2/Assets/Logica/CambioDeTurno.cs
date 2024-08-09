using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Logica
{
    public class CambiosDeTurno
    {
        public int current;
        public bool hasmovid = false;
        public bool liderefect;
        public bool pasar;
        public List<Jugador> jugadores;
        

        public CambiosDeTurno()
        {
            this.current = 0;
            this.hasmovid = false;
            this.liderefect = false;
            this.pasar = false;
            this.jugadores = new List<Jugador>(2);
        }

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

