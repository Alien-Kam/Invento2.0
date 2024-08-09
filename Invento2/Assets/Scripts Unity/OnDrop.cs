using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using Carta;

public class OnDrop : MonoBehaviour, IDropHandler
{
    public Clasificacion nombreclas;
    public uint clasificacion;
    public int posicion;
    GameObject item;
    private float lastClickTime;
    private const float doubleClickThreshold = float.MaxValue;
    public static Posiciones instancia;
    public enum Clasificacion
    {
        CuerpoaCuerpo = 0b_001,
        LargaDistancia = 0b_010,
        Asedio = 0b_100,
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
            instancia.CosasTablero(nombreclas, posicion);
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
