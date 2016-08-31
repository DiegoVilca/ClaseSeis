using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dolar UnDolar;
            Peso UnPeso;

            UnDolar = 1;

            UnPeso = (Peso)1;

            UnDolar = UnDolar + UnPeso;

            Console.WriteLine("Dolares: " + UnDolar.cantidad);

            UnPeso = UnPeso + UnDolar;

            Console.WriteLine("Pesos: "+ UnPeso.cantidad);

            Console.ReadKey();
        }
    }
}
