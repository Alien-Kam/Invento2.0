using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Carta;
using UnityEngine.EventSystems;

public class Posiciones : MonoBehaviour, IDropHandler
{
    public GameObject[] CuerpoaCuerpo;
    public GameObject[] LargaDistancia;
    public GameObject[] Asedio;
    public GameObject[] Aumento;
    public GameObject[] Clima;
    private float lastClickTime;
    private const float doubleClickThreshold = float.MaxValue;
    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("On Drop");
        throw new System.NotImplementedException();
    }

    // Preguntar si los gameobjects de las listas tienen hijos y pasarle el elemento al tablero.

}
