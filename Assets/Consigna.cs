using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Heladería "Los tres gustos"

//Esta heladería ofrece 3 gustos: chocolate, frutilla y dulce de leche y toma pedidos mediante códigos.
//El cliente debe pedir los gustos ingresando CHO, FRU y DDL.
//Además debe ingresar una cantidad de helado en gramos (250 para un cuarto, 500 para medio k, etc). 
//Esta semana tiene una promoción con frutilla, por lo que el precio se reduce un %10 solo en ese gusto.


//.Mostrar un mensaje de error y ningún otro mensaje ni realizar ningún cálculo si no se ingresa un código válido o 
//si las cantidades de helado son menores a 250 o mayores que 3000. 

//Sabiendo que el kilo de helado sale $500, devolver el costo del pedido si los ingresos son válidos. 
//Recuerdo contemplar la promoción.

public class Consigna : MonoBehaviour
{
    public string sabor;
    public int cantidad;
    float costo;
    float gramo = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        


        if (cantidad >= 250 && cantidad <= 3000)
        {
            costo = cantidad * gramo;

            switch (sabor)
            {
                case "CHO":
                    Debug.Log("Su costo es $" + costo);
                    break;
                case "FRU":
                    costo = costo - costo / 100 * 10;
                    Debug.Log("Su costo es $" + costo);
                    break;
                case "DDL":
                    Debug.Log("Su costo es $" + costo);
                    break;
                default:
                    Debug.Log("Debe ingresar un sabor valido.");
                    break;
            }
        }
        else
        {
            Debug.Log("Error.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
