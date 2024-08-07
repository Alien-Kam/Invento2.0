using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Carta
{
    public enum FaccionCard
    {
        PrimeraFaccion,
        SegudaFaccion,
    }
    public abstract class CartaCread
    {
        public string namecard;
        public string ability;
        public FaccionCard card;

        public CartaCread(string nombre, string habilidad, FaccionCard carta)
        {
            namecard = nombre;
            ability = habilidad;
            card = carta;
        }
    }
    public abstract class Carta2 : CartaCread
    {
        public int ataque;
        public enum Clasificacion
        {
            CuerpoaCuerpo = 0b_001,
            LargaDistancia = 0b_010,
            Asedio = 0b_100,
            CCLDA = 0b_111,
            CCLD = 0b_011,
            CCA = 0b_101,
            LDA = 0b_110,
        }
        public uint clasificacion;

        protected Carta2(string nombre, string habilidad, FaccionCard carta, int ataque ,uint numero) : base(nombre, habilidad, carta)
        {
            this.ataque = ataque;
            clasificacion = numero;
        }
    }
    public class Aumento : CartaCread
    {
        public Aumento(string nombre, string habilidad, FaccionCard carta) : base(nombre, habilidad, carta)
        {
        }
    }
    public class Senuelo : CartaCread
    {
        public Senuelo(string nombre, string habilidad, FaccionCard carta) : base(nombre, habilidad, carta)
        {
        }
    }
    public class Clima : CartaCread
    {
        public Clima(string nombre, string habilidad, FaccionCard carta) : base(nombre, habilidad, carta)
        {
        }
    }
    public class Normales : Carta2
    {
        public Normales(string nombre, string habilidad, FaccionCard carta, int ataque, uint numero) : base(nombre, habilidad, carta, ataque, numero)
        {
        }
    }
    public class Heroe : Normales
    {
        public Heroe(string nombre, string habilidad, FaccionCard carta, int ataque, uint numero) : base(nombre, habilidad, carta, ataque, numero)
        {
        }
    }

}
