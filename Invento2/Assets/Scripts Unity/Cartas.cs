using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Carta;

public class Cartas : MonoBehaviour
{
    public enum Tipo
    {
        Heore,
        Normales,
        Aumento,
        Clima,
        Senuelo,
    }

    public string nombre;
    public string habilidad;
    public int ataque;
    public uint clasificacion;
    public Tipo tipoCarta;
    public Carta.Faccion faccion;
    private Carta2 instanciaCarta;
    // hacer un switch
    public Carta2 CrearCarta()
    {
        switch (tipoCarta)
        {
            case Tipo.Heore:
                Heroe card = new Heroe(nombre, habilidad, faccion, ataque, clasificacion);
                return card;
              
            case Tipo.Normales:
                Normales cardh = new Normales(nombre, habilidad, faccion, ataque, clasificacion);
                return cardh;

            case Tipo.Clima:
                Clima cardc = new Clima(nombre, habilidad, faccion);
                break;

            case Tipo.Aumento:
                Aumento carda = new Aumento(nombre, habilidad, faccion);
                break;

            case Tipo.Senuelo:
                Senuelo cards = new Senuelo(nombre, habilidad, faccion);
                break;
        }
        return null;
    }
    public Carta2 ObtenerInstanciaCarta()
    {
        return CrearCarta();
    }
    private void Awake()
    {
        CrearCarta();
    }

    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {

    }
}
