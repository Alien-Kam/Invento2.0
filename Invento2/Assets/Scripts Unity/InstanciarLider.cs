using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



/* Vamos a ver en el 2do proyecto no se que tipo de efectos me podran poner asi q se debe hacer una lista con cada tipo de efecto
  o al menos las palabras claves que no puedan faltar como aumetar eliminar y cosas asi */

public class InstanciarLider : MonoBehaviour
{
    public GameObject gameObjectConImagen; // Referencia al GameObject que tiene la imagen
    public Button boton; // Referencia al botón

    void Start()
    {
        // Obtén el componente Image del GameObject
        Image imagen = gameObjectConImagen.GetComponent<Image>();

        // Asegúrate de que el GameObject tiene un componente Image
        if (imagen != null)
        {
            // Asigna la imagen del GameObject al botón
            boton.image.sprite = imagen.sprite;
        }
        else
        {
            Debug.LogError("El GameObject no tiene un componente Image.");
        }
    }
    // Poner los efectos de los lideres 
    public void Effect()
    {

    }
}
