using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_6
{
    internal class Program
    {
        static void Main(string[] args)

        {
            double catetoA;
            double catetoB;
            double hipotenusa;
            Console.Write("Ingrese cateto a: ");
            catetoA=double.Parse(Console.ReadLine());
            Console.Write("Ingrese cateto b: ");
            catetoB = double.Parse(Console.ReadLine());
            hipotenusa = Math.Sqrt((catetoA * catetoA) + (catetoB * catetoB));
            Console.WriteLine(hipotenusa);


        }
    }
}
