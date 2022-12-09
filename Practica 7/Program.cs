using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int horaA;
            int cantidadHoras;
            int resultado;
            Console.Write("Hora actual: ");
            horaA=int.Parse(Console.ReadLine());
            Console.Write("Cantidad de horas:");
            cantidadHoras=int.Parse(Console.ReadLine());
            resultado= (horaA+cantidadHoras)%12;
            Console.WriteLine($"En {cantidadHoras} horas, el reloj marcara las {resultado}");

        }
    }
}
