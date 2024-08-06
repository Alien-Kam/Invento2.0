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
        Debug.Log("Se crearon los jugadores");
        Jugador player = new Jugador(playerName, playerIndex, faccion);
        
        
    }

    void Start()
    {
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
