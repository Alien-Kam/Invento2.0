using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Codigosreutilizables : MonoBehaviour
{
    //Para el Drang and Drop

    // Transform posicion = Posicionesenelcampo.CuerpoaCuerpo.Find(obj => ).transform;
    /* GetComponent<CanvasGroup>().blocksRaycasts = true; // Restablece el bloqueo de raycast
     float distanciaMinima = float.MaxValue;
     Transform posicionMasCercana = startParent; // Comienza asumiendo la posición de inicio como la más cercana

     // Encuentra la posición más cercana de la lista
     for(int i = 0; i < posicionFin.Count; i++)
     {
         for (int j = 0; i < posicionFin[i].Count; j++)
         {
           /*  float distancia = Vector3.Distance(transform.position, originalPos.position);
             if (distancia < distanciaMinima)
             {
                 distanciaMinima = distancia;
                 posicionMasCercana = originalPos;
             }
         }
     }*/


    /* RaycastHit2D[] hits = Physics2D.RaycastAll(transform.position, Vector2.down, Mathf.Infinity);
        coliciones.Clear();
        foreach (RaycastHit2D hit in hits)
        {
            Debug.Log("Hola");
            if (hit.collider != null && hit.collider.gameObject != this.gameObject)
            {


            }
        }*/
}


/*public class DrandandDrop : MonoBehaviour, IDragHandler, IEndDragHandler, IBeginDragHandler
{
    Vector3 starPosition; // Posicion inicial 
    Transform starParent; //posicion inicial del padre 
    Transform dragParent; //Es cuando se haa drag en el item se coloque dentro de ese parent
    public static GameObject itemDragging; // gameobject en movimiento 
    // Start is called before the first frame update
    void Start()
    {
        dragParent = GameObject.FindGameObjectWithTag("DragParent").transform;
    }
    public void OnBeginDrag(PointerEventData eventData) // Llama solo una vez cuando se comienza a hacervel drag 
    {
        Debug.Log("OnBegingDrag");
        itemDragging = gameObject;
        starPosition = transform.position;
        starParent = transform.parent;
        transform.SetParent(dragParent);
    }

    public void OnDrag(PointerEventData eventData) //Se llama siempre que se este haciendo el drag
    {
        Debug.Log("OnDrag");
        transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData) // Se llama al final 
    {
        Debug.Log("EndDrag");
        itemDragging = null;
        if (transform.parent == dragParent)
        {
            transform.position = starPosition;
            transform.SetParent(starParent);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }*/

// On Drop
/*
public class DropSlot : MonoBehaviour, IDropHandler //Este interfaz es para la caida de un obj sobre otro 
{

    public GameObject item;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void OnDrop(PointerEventData eventData) // Este metodo es para saber cuado un objeto cae sobre otro 
    {
        if(!item)
        {
            item = DrandandDrop.itemDragging;
            item.transform.SetParent(transform);
            item.transform.position = transform.position;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(item != null && item.transform.parent != transform)
        {
            item = null;
        }
    }
}*/


/*Si el collider existe guarda en una variable su tag (su etiqueta)  y se la pregunta */
// Teniendo el tag de la posicion 



//Cambio de turno 
/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static Player instance;
    public int currentPlayerIndex = 0;
    public int totalPlayers = 2;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);

        }
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void StartTurn()
    {
        Debug.Log("Turno del jugador: " + currentPlayerIndex);
    }

    public void EndTurn()
    {
        currentPlayerIndex = (currentPlayerIndex + 1) % totalPlayers;
        StartTurn();
    }
}*/
