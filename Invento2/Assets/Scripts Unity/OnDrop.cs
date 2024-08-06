/*using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class OnDrop : MonoBehaviour, IDropHandler
{
    public string faccion;
    GameObject item;
    Clasificacion clasificacionitem;
    Clasificacion clasificacionitem2;
    Clasificacion clasificacionitem3;
    Faccion faccionitem;
    private float lastClickTime;
    private const float doubleClickThreshold = float.MaxValue;
    List<GameObject> cuerpoacuerpo;
    List<GameObject> largadistancia;
    List<GameObject> asedio;
    List<GameObject> Cementerio;


    public enum Faccion
    {
        Primerafaccion,
        SegundaFaccion,

    }
    public enum Clasificacion
    {
        CuerpoaCuerpo,
        LargaDistancia,
        Asedio,
        Clima,
        Ninguna,
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    //Si entra al metodo y este metodo hace la funcion de Drop
    void IDropHandler.OnDrop(PointerEventData eventData)
    {
        if (!item)
        {
            item = DragandDrop.itemDragging;
            Carta cartaScript = item.GetComponent<Carta>(); // Esto me permite acceder a las variables de Carta
            clasificacionitem = (Clasificacion)cartaScript.clasificacion; // Estas variables coge las clasificaciones de las cartas
            clasificacionitem2 = (Clasificacion)cartaScript.clasificacion1;// Estas variables coge las clasificaciones de las cartas
            clasificacionitem3 = (Clasificacion)cartaScript.clasificacion2;// Estas variables coge las clasificaciones de las cartas
            faccionitem = (Faccion)cartaScript.faccion;

            //Esto pincha 
            string tagposicion = null;
            BoxCollider collider = GetComponent<BoxCollider>(); // esto le pregunta el tag de la posicion en donde se va a poner la carta
            if ((faccionitem == Faccion.Primerafaccion && faccion == "SegundaFaccion") || (faccionitem == Faccion.SegundaFaccion && faccion == "PrimeraFaccion"))
            {
                //Debug.Log("No se puede colocar la carta aqui porque es de otra faccion");
                return;
            }
            if (collider != null)
            {
                tagposicion = collider.tag;
                //Debug.Log("La posicion es de " + tagposicion);
            }

            // Esto pregunta si la carta puede ser colocada en esta posicion 
            if (tagposicion == "Cuerpo a Cuerpo" && clasificacionitem == Clasificacion.CuerpoaCuerpo)
            {
                //Debug.Log("La carta puede entrar en " +  tagposicion);
                item.transform.SetParent(transform);
                item.transform.position = transform.position;
                cuerpoacuerpo.Add(item);
            }

            //Si la carta es de larga Distancia puede ser colocada aqui
            if (tagposicion == "LargaDistancia" && (clasificacionitem == Clasificacion.LargaDistancia || clasificacionitem2 == Clasificacion.LargaDistancia))
            {
               // Debug.Log("La carta puede entrar en " + tagposicion);
                item.transform.SetParent(transform);
                item.transform.position = transform.position;
                largadistancia.Add(item);
            }

            //Si la carta es de Asedio
            if (tagposicion == "Asedio" && (clasificacionitem == Clasificacion.Asedio || clasificacionitem2 == Clasificacion.Asedio || clasificacionitem3 == Clasificacion.Asedio))
            {
               // Debug.Log("La carta puede entrar en " + tagposicion);
                item.transform.SetParent(transform);
                item.transform.position = transform.position;
                asedio.Add(item);
            }
        }
    }


    // Update is called once per frame
    void Update()
    {
        if (item != null && item.transform.parent != transform)
        {
            item = null;
        }

    }
}*/
