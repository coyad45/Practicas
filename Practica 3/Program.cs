using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nota1;
            int nota2;
            int nota3;
            int nota4;
            float promedio = 4f;

            Console.Write("Primera nota: ");
            nota1=int.Parse(Console.ReadLine());
            Console.Write("Segunda nota: ");
            nota2=int.Parse(Console.ReadLine());
            Console.Write("Tercera nota: ");
            nota3=int.Parse(Console.ReadLine());
            Console.Write("Cuarta nota: ");
            nota4=int.Parse(Console.ReadLine());

            promedio= (nota1+ nota2 +nota3 +nota4) /promedio;
            Console.WriteLine($"El promedio es: {promedio}");

        }
    }
}
