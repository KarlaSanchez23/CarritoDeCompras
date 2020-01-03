using System;
using System.Collections.Generic;
using System.Text;

namespace CarritoDeCompras
{
   public class BaseDeDatos:IPersistencia //se implementa la interfaz IPersistencia que permite tener una sola funcionalidad 
        //que es el de guardar la informacion
    {
        public void Guardar(Carrito carrito)//Se crea un método guardar
        {
            throw new NotImplementedException();
        }
    }
}
