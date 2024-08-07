using System.Collections.Generic;
using UnityEngine;
using Carta;

public class DistribuirCard : MonoBehaviour
{ 
    public List<GameObject> deck = new List<GameObject>();
    public List<GameObject> hand = new List<GameObject>();
    public List<string> objectNames = new List<string>();
    public GameObject panel;
    public Transform canvasTransform;

    void Start()
    {
        // Este pasa 10 cartas del deck a la mano 
        for (int i = 0; i < 10; i++)
        {
            GameObject carta = deck[Random.Range(0, deck.Count)];
            hand.Add(carta);
            deck.Remove(carta);
        }
        Transform handposition = transform.Find("PositionCards");

        // Esto lo vamos a utilizar para instanciar la carta lider como un boton de la escena 
        Transform liderposition = transform.Find("BotondelLider");

        // Llamar aqui al metodo de instanaciar carta con los parametros de la mano y de la posicion de los gameobjects
         InstanciarCarta(hand, handposition);

        // Para ubicar las cartas dentro del canvas
        /*foreach (string objectName in objectNames)
        {
            GameObject obj = GameObject.Find(objectName);
            if (obj != null)
            {
                obj.transform.SetParent(canvasTransform, false);
            }
        }
    }*/

        void InstanciarCarta(List<GameObject> cartas, Transform position)
        {
            for (int i = 0; i < hand.Count; i++)
            {
                GameObject carta = hand[i];
                Cartas cartascript = hand[i].GetComponent<Cartas>();


                // GetChild busca el hijo y en este caso la posicion 
                Transform pos = position.GetChild(i);

                // Instancia las cartas 
                GameObject nuevaInstancia = Instantiate(carta, pos.position, Quaternion.identity, canvasTransform);
                objectNames.Add(carta.name + "(Clone)");

                //Escala de ellas 
                nuevaInstancia.transform.localScale = new Vector3(1.3f, 1.3f, 1.3f);

                // nuevaInstancia.AddComponent<DragandDop>();
                nuevaInstancia.AddComponent<CanvasGroup>();
            }
        }
    }

}
