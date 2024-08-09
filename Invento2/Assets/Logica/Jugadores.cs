using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Logica
{
    public class Jugador
    {
        public string nombreplayer;
        public int indexplayer;
        public Faccion faccion;

        public Jugador(string name, int index, Faccion faccion)
        {
            nombreplayer = name;
            indexplayer = index;
            this.faccion = faccion;
        }
    }
}
