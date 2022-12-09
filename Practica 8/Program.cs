using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numero;
            double numeroDecimal;
            Console.Write("Ingrese un numero: ");
            numero= Convert.ToDouble(Console.ReadLine());
            numeroDecimal = numero;
            numero = Math.Truncate(numero);
            numero =  numeroDecimal-numero;
            numero = Math.Abs(numero);
            Console.WriteLine(numero);
        }
    }
}
