using System;
using System.Collections.Generic;
using System.Text;

namespace CarritoDeCompras
{
    public class ProductoConDescuento : Producto, IProducto, IProductoEnOferta//Esta interfaz se la incluye en esta
    //porque solo los productos que están con descuentos, cuentan con productos en oferta, en la clase productos sin descuentos, 
    //no se necesita realizar esa operación, por lo tanto cumple con el cuarto principio:PRINCIPIO DE SEGREGACIÓN DE INTERFACES.

    /*En esta clase, se implemente el tercer principio que es: PRINCIPIO DE SUSTITUCIÓN DE LISKOV, donde se utiliza un método 
     * de una clase en otra clase hija sin que haya errores. Para ello, se utilizó una interface llamada IProducto donde se 
     * sobre escribe el método de calcular descuento.
     */
    {
        public ProductoConDescuento()
        {
            
        }

        public decimal Descuento { get; set; }

        //Se sobre escribe el metodo calcular descuento
        // y se implementa una funcionalidad en la clase hija
        public  decimal CalcularDescuento()
        {
            return this.Precio * (this.Descuento / 100);
        }

        public int ObtenerProductoEnOferta()//PRINCIPIO DE SEGREGACIÓN DE INTERFACES
        {
            throw new NotImplementedException();
        }

    }
}
