using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Carta;
using UnityEngine.EventSystems;

public class Posiciones : MonoBehaviour
{
    public GameObject[] CuerpoaCuerpo;
    public GameObject[] LargaDistancia;
    public GameObject[] Asedio;
    public GameObject[] Aumento;
    public GameObject[] Clima;
    private float lastClickTime;
    private const float doubleClickThreshold = float.MaxValue;
    Tablero instancia = new Tablero();
    public enum ClasificacionPosiciones
    {
        CuerpoaCuerpo = 0b_001,
        LargaDistancia = 0b_010,
        Asedio = 0b_100,
    }

    public void CosasTablero()
    {
        Debug.Log("CosasTabero");
       
        for (int i = 0; i<CuerpoaCuerpo.Length; i++)
        {
            if (CuerpoaCuerpo[i].transform.childCount != 0)
            {
                Debug.Log("Hola");
                Transform hijo = CuerpoaCuerpo[i].transform.GetChild(0);
                
                // Obtener el componente Cartas del hijo
                Cartas scriptCartas = hijo.GetComponent<Cartas>();

                if (scriptCartas != null)
                {
                    Debug.Log("El script eiste");
                    // Obtener la instancia de Carta2
                    Carta2 carta = scriptCartas.ObtenerInstanciaCarta();
                    BoxCollider son = hijo.GetComponent<BoxCollider>();
                    if (carta != null)
                    {
                        Debug.Log(son.tag);
                    
                    }
                }
            }
        }
    }
}