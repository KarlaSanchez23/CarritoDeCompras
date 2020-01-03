using System;
using System.Collections.Generic;
using System.Text;

namespace CarritoDeCompras
{
   public class Impresora
    {
        public Impresora()
        {
        }
        /*Aquí se realiza el primer principio que es: PRINCIPIO DE RESPONSABILIDAD ÚNICA, que consiste en que un 
          objeto realice una sola cosa. En este caso, se crea una clase llamada impresora donde unicamente se imprimirá
          los datos del Cliente.

        NOTA: este método no se puede realizar en la clase Cliente, ya que estaría realizando 2 cosas a la vez,
        por lo tanto, no estaría cumpliendo con el Princicpio de Responsabilidad Única.*/

        public void ImprimirDatosCliente(Cliente cliente)
        {

            Console.WriteLine(cliente.Apellidos + cliente.Nombres);

            //return cliente.Nombres + " " + cliente.Apellidos;

        }

    }
}
