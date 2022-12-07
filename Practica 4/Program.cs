using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float pulgada = 2.54f;
            float longitud;
            float resultado;
            Console.Write("Ingrese longitud: ");
            longitud = float.Parse(Console.ReadLine());
            resultado = longitud / pulgada;
            Console.WriteLine($"{longitud} cm" + " = " + $"{resultado} in");


        }
    }
}
