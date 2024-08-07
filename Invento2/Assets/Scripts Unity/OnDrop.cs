using System.Collections.Generic;
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
            Debug.Log(item.name);
            item.transform.SetParent(transform);
            item.transform.position = transform.position;
            
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
}
