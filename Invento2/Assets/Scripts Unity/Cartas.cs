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
    public Carta.FaccionCard faccion;  

    // hacer un switch
    public void CrearCarta()
    {
        switch (tipoCarta)
        {
            case Tipo.Heore:
                Heroe card = new Heroe(nombre, habilidad, faccion, ataque, clasificacion);
                break;

            case Tipo.Normales:
                Normales cardh = new Normales(nombre, habilidad, faccion, ataque, clasificacion);
                break;

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
