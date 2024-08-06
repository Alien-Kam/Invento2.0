using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Carta
{
    public class Tablero
    {
        //El cuerpo a Cuerpo sera el primero en la matriz 

        public Carta[,] tableroplayer1 = new Carta[6,5];
        bool[,] tableropy1 = new bool[3, 5];
        bool[,] tableropy2 = new bool[3, 5];
        public Carta[] clima1 = new Carta[3];
        bool[] climapl1 = new bool[3];
        public Carta[] clima2 = new Carta[3];
        bool[] climapl2 = new bool[3];
        public Carta[] Aumento1 = new Carta[3];
        bool[] Aumentopl1 = new bool[3];
        public Carta[] Aumento2 = new Carta[3];
        bool[] Aumentopl2 = new bool[3];
    }
}
