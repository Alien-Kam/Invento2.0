using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using Carta;

public class DragandDrop : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler, IPointerEnterHandler, IPointerExitHandler
{
    Vector3 starPosition; // Posicion inicial 
    Transform starParent; //posicion inicial del padre 
    Transform dragParent; //Es cuando se haa drag en el item se coloque dentro de ese parent
    public static GameObject itemDragging; // gameobject en movimiento 
    private bool haSidoMovida = false; // Es para verificar si la carta ya se movio 
    public int ownerIndex; // Índice del propietario de la carta
    public static int playerIndex;
    public GameObject panelcard;
    public Image imagepanel;
    public Sprite newImage;
    private Image cardImage; // Imagen de la carta


    // Start is called before the first frame update
    void Start()
    {
        
        dragParent = GameObject.FindGameObjectWithTag("DragParent").transform; // Este es el padre
       
        panelcard = GameObject.FindWithTag("Panelcard");

        if (panelcard != null)
        {
            imagepanel = panelcard.GetComponent<Image>();
        }
        cardImage = GetComponent<Image>(); // Obtener la imagen de la carta
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        if (haSidoMovida || ownerIndex != playerIndex)
        {
            return;
        }
        itemDragging = gameObject; // El objeto que se mueve 
        starPosition = transform.position; // posicion inicial
        starParent = transform.parent; // posicion del padre 
        transform.SetParent(dragParent, false);

    }

    public void OnDrag(PointerEventData eventData)
    {
        if (haSidoMovida || ownerIndex != playerIndex)
        {
            return;// En este caso si la carta ya se movio no se hace mas nada
        }
        transform.position = Input.mousePosition; // movimiento del mouse actualiza la posicion del objeto 
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        if (haSidoMovida || ownerIndex != playerIndex)
        {
            return; // En este caso si la carta ya se movio no se hace mas nada 
        }

        itemDragging = null;

        if (transform.parent == dragParent)
        {
            haSidoMovida = false;

            transform.position = starPosition;

            transform.SetParent(starParent);
        }
        else
        {
            haSidoMovida = true; // Esto es para que ya no se pueda mover mas porque ya ha sido colocada
            CambiosDeTurno.hasmovid = true;
            ControlTurno.instancia.EndTurn();
            
        }

    }
    public void OnPointerEnter(PointerEventData eventData)
    {
        if (imagepanel != null && cardImage != null && ownerIndex == playerIndex)
        {
            imagepanel.sprite = cardImage.sprite; // Mostrar la imagen de la carta en el panel
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if (imagepanel != null)
        {
            imagepanel.sprite = panelcard.GetComponent<Image>().sprite; // Limpiar la imagen del panel cuando el mouse salga de la carta
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

}
