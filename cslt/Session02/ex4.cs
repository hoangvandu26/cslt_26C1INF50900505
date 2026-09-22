using System;
using System.Collections.Generic;
using System.Text;

namespace cslt.Session02
{
    internal class ex4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("doi feet qua meter");
            Console.Write("nhap so feet: ");
            double feet = double.Parse(Console.ReadLine());
            double meter = feet * 0.3048;
            Console.WriteLine($"{feet} feet = {meter} meter");
        }
    }
}
