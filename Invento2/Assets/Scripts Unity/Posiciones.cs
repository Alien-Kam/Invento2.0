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

    public enum Clasificacion
    {
        CuerpoaCuerpo = 0b_001,
        LargaDistancia = 0b_010,
        Asedio = 0b_100,
    }
    public void CosasTablero(OnDrop.Clasificacion clas, int pos)
    {
        switch (clas)
        {
            case OnDrop.Clasificacion.CuerpoaCuerpo:
                Transform hijo = CuerpoaCuerpo[pos].transform.GetChild(0);
                Debug.Log(hijo.name);
                // Obtener el componente Cartas del hijo
                Cartas scriptCartas = hijo.GetComponent<Cartas>();

                OnDrop onDropScript = CuerpoaCuerpo[pos].GetComponent<OnDrop>();

                if (scriptCartas != null)
                {
                    Carta2 carta = scriptCartas.ObtenerInstanciaCarta();
               
                    if (carta != null && onDropScript != null)
                    {
                        uint clasificacion = onDropScript.clasificacion;
                        if (!EsValido(carta, clasificacion))
                        {
                            instancia.Mesa(carta, pos, 3, 2, clasificacion);

                        }

                    }
                }
                break;

            case OnDrop.Clasificacion.LargaDistancia:
                Transform hijo1 = LargaDistancia[pos].transform.GetChild(0);
              
                // Obtener el componente Cartas del hijo
                Cartas scriptCartas1 = hijo1.GetComponent<Cartas>();

                OnDrop onDropScript1 = LargaDistancia[pos].GetComponent<OnDrop>();

                if (scriptCartas1 != null)
                {
                    Carta2 carta = scriptCartas1.ObtenerInstanciaCarta();
                    Debug.Log(carta);
                    if (carta != null && onDropScript1 != null)
                    {
                        uint clasificacion = onDropScript1.clasificacion;
                        if (!EsValido(carta, clasificacion))
                        {
                            instancia.Mesa(carta, pos, 4, 1, clasificacion);

                        }
                    }
                }
                break;

            case OnDrop.Clasificacion.Asedio:
                Transform hijo2 = Asedio[pos].transform.GetChild(0);
              
                // Obtener el componente Cartas del hijo
                Cartas scriptCartas2 = hijo2.GetComponent<Cartas>();

                OnDrop onDropScript2 = Asedio[pos].GetComponent<OnDrop>();

                if (scriptCartas2 != null)
                {
                    Carta2 carta = scriptCartas2.ObtenerInstanciaCarta();
                    Debug.Log(carta);
                    if (carta != null && onDropScript2 != null)
                    {
                        uint clasificacion = onDropScript2.clasificacion;
                        if (!EsValido(carta, clasificacion))
                        {
                            instancia.Mesa(carta, pos, 5, 0, clasificacion);
                        }

                    }
                }
                break;
        }
    }
    public bool EsValido(Carta2 card, uint clasificacion)
    {
        Debug.Log("Es Valido");
        return instancia.Valido(card, clasificacion);
    }
}


