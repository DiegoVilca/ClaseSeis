using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Ejercicio:
 * 
 * hacer que el siguiente codigo funcione en el main:
 *          Producto prod1 = (Producto)33;

            int resultado;

            resultado = prod1 + prod1;
 */


namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {


            Producto prod1 = (Producto)33;

            int resultado;

            resultado = prod1 + prod1;

            Console.WriteLine("Resultado: " + resultado);

            Console.ReadKey();
        }
    }
}
