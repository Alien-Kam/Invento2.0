using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Carta
{
    public class Tablero
    {
        public static Tablero instancia = new Tablero();
        public Carta2[,] tablero = new Carta2[6, 5];
        public bool[,] mask = new bool[6, 5];
        public bool[,] tableropy2 = new bool[3, 5];
        public Clima[] clima1 = new Clima[3];
        public bool[] climapl1 = new bool[3];
        public Clima[] clima2 = new Clima[3];
        public bool[] climapl2 = new bool[3];
        public Aumento[] Aumento1 = new Aumento[3];
        public bool[] Aumentopl1 = new bool[3];
        public Aumento[] Aumento2 = new Aumento[3];
        public bool[] Aumentopl2 = new bool[3];
        public static CambiosDeTurno instance = new CambiosDeTurno();   
        public enum Clasificacion
        {

        }

        public void Mesa(Carta2 card, int filaplayer1, int filaplayer2 ,int columna, uint clasificacion)
        {
            if(CambiosDeTurno.inns.current == 0)
            {

                tablero[filaplayer1, columna] = card;
                mask[filaplayer1, columna] = true;

            }
        }
        public bool Valido(Carta2 card,uint clasificacion)
        {
            if(card.card != instance.jugadores[instance.current].faccion)
            {
                Debug.Log($"El current es :{instance.current}");
                Debug.Log(instance.jugadores[instance.current]);
                Debug.Log(card.card);
                return true;
            }
            return false;
        }
    }
}
