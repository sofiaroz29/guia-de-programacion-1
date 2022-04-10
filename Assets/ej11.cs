using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Realizá un programa que resuelva el siguiente problema:
//Deberá ingresarse por Inspector una fecha de compra (String en el siguiente formato:
//YYYYMMDD), un nombre de comprador, un nombre de producto y una cantidad y precio del
//producto comprado. Mostrá a modo de ticket, la información ingresada y el monto a pagar.
//Modelo de Ticket:
//Fecha de Compra: YYYYMMDD
//Nombre del Comprador: xxxxx xxxxx
//Producto solicitado: xxxxx
//Cantidad solicitada: xx
//Precio Unitario: $xxx
//Total a Pagar: $xxxxx

public class ej11 : MonoBehaviour
{

    public string fechaCompra;
    public string nombre;
    public string producto;
    public float cantProducto;
    public float precioProducto;
    float precioTotal;
    

    // Start is called before the first frame update
    void Start()
    {
        precioTotal = cantProducto * precioProducto;
        Debug.Log("Fecha de compra: " + fechaCompra + "\n\r" + "Nombre del Comprador: " + nombre + "\n\r" + "Producto Solicitado: " + producto + "\n\r" + "Cantidad solicitada: " + cantProducto + "\n\r" + "Precio Unitario: " + precioProducto + "\n\r" + "Total a pagar: " + precioTotal);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
