using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Carta;

public class Players : MonoBehaviour
{
    public static Players instance;
    public Players player;
    public string playerName;
    public int puntos;
    public int playerIndex;
    public Carta.Faccion  faccion;
    public TextMeshProUGUI puntosText;
    
    public void CreadordeJugadores()
    {
        Jugador player = new Jugador(playerName, playerIndex, faccion);
         //instance.jugadores.Add(player);

    }

    void Start()
    {
        CreadordeJugadores();
        puntos = 0;
        UpdatepuntosText();
       
    }
    public void UpdatepuntosText()
    {
        if (puntosText != null)
        {
            puntosText.text = $"Puntos : {puntos}";
        }
    }
}
