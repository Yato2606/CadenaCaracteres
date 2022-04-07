using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cadena;
            int num1 = 5, num2, resultado;

            //preguntamos al usuario el numero
            Console.WriteLine("Dame un numero para sumarlo: ");
            //se asigna la variable de tipo string
            cadena = Console.ReadLine();
            num2 = Int32.Parse(cadena);
            //num2 = Convert.ToInt32(cadena);
            //Realizar la suma
            resultado = num1 + num2;
            Console.WriteLine("El resultado es: " + resultado);
            Console.ReadKey();

        }
    }
}
