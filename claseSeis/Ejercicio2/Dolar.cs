using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    public class Dolar
    {
        public int cantidad;

        public Dolar(int cantidad)
        {
            this.cantidad = cantidad;
        }

        public static Dolar operator +(Dolar unDolar, Peso unPeso)
        {
            return new Dolar(unDolar.cantidad + unPeso.cantidad / 15);
        }

        public static implicit operator Dolar(int numero)
        {
            return new Dolar(numero);
        }

    }
}
