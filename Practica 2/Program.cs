using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double radio;
            double perimetro;
            double area;
            Console.Write("Ingrese el radio:");
            radio= Convert.ToDouble(Console.ReadLine());
            perimetro = Math.PI * radio *2;
            area = Math.PI * radio * radio;
            Console.WriteLine($"Perimetro:{perimetro}");
            Console.WriteLine($"Area:{area}");


        }
    }
}
