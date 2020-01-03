using System;
using System.Collections.Generic;
using System.Text;

namespace CarritoDeCompras
{
    //Aquí se cumple el cuarto principio que es: PRINCIPIO DE SEGREGACIÓN DE INTERFACES
    //Se tiene la clase padre (PRODUCTO) y las clases hijas (PRODUCTO CON DESCUENTO y PRODUCTO SIN DESCUENTO) y se quiere 
    //agregar en los productos con descuento una nueva funcionalidad de productos en oferta, para ello y para no afectar a 
    //la clase producto sin descuento, se crea una interfaz PRODUCTO EN OFERTA con el fin de implementarla en la clase productos con descuento.
    interface IProductoEnOferta
    {
        int ObtenerProductoEnOferta();
    }
}
