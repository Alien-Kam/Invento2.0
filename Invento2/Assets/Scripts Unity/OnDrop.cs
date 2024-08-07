using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using Carta;

public class OnDrop : MonoBehaviour, IDropHandler
{
    GameObject item;
    private float lastClickTime;
    private const float doubleClickThreshold = float.MaxValue;
    public static Posiciones instancia;
 
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
        if (instancia == null)
        {
            instancia = FindObjectOfType<Posiciones>();
        }
    }

    //Si entra al metodo y este metodo hace la funcion de Drop
    void IDropHandler.OnDrop(PointerEventData eventData)
    {
        if (!item)
        {
            item = DragandDrop.itemDragging;
            item.transform.SetParent(transform);
            item.transform.position = transform.position; 
        }
        instancia.CosasTablero();
    }
    // Update is called once per frame
    void Update()
    {
        if (item != null && item.transform.parent != transform)
        {
            item = null;
        }

    }
}
