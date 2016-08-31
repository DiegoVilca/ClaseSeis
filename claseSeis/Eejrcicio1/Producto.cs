using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Producto
    {

        int cantidad;

        public Producto(int cantidad)
        {
            this.cantidad = cantidad;
        }

        

        public static int operator +(Producto productoUno, Producto productoDos)
        {
            return productoUno.cantidad + productoDos.cantidad;

        }

        public static implicit operator Producto(int numero)
        {
            return new Producto(numero);
        }

    }
}
