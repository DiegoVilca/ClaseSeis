using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    public class Peso
    {
        public int cantidad;

        public Peso(int cantidad)
        {
            this.cantidad = cantidad;
        }


        public static Peso operator +(Peso unPeso, Dolar unDolar)
        {
            return new Peso(unPeso.cantidad + unDolar.cantidad * 15);

        }

        public static explicit operator Peso(int numero)
        {
            return new Peso(numero);
        }

    }
}
