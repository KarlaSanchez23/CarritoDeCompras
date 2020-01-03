using System;
using System.Collections.Generic;
using System.Text;

namespace CarritoDeCompras
{
    public class ProductoSinDescuento:Producto, IProducto

        /*En esta clase, se implemente el tercer principio que es: PRINCIPIO DE SUSTITUCIÓN DE LISKOV, donde se utiliza un método 
         * de una clase en otra clase hija sin que haya errores. Para ello, se utilizó una interface llamada IProducto donde se 
         * sobre escribe el método de calcular descuento.
         */
    {
        public ProductoSinDescuento()
        {

        }

        public DateTime FechaInicioDescuento { get; set; }

        //Se sobre escribe el metodo calcular descuento
        // y se implementa una funcionalidad en la clase hija
        public decimal CalcularDescuento()
        {
            return 100;
        }



        /*
        public int CalcularFechaDescuento()
        {
            TimeSpan timespan = DateTime.Today - this.FechaInicioDescuento;
            int dia = timespan.Days;
            int fecha = dia / 365;
            return fecha;
        }*/

    }
}
