using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            string num;
            char[] array;
            Console.Write("Ingrese numero:");
            numero = int.Parse(Console.ReadLine());
            num = numero.ToString();         
            array= num.ToCharArray();
            Array.Reverse(array);
            Console.WriteLine(array);

        }
    }
}
