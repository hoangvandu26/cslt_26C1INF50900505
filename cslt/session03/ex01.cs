using System;
using System.Collections.Generic;
using System.Text;

namespace cslt.session03
{
    internal class ex1
    {
        static void Main()
        {
            Console.Write("Nhập độ Celsius : ");
            float celsius = float.Parse(Console.ReadLine());

            float kelvin = celsius + 273;
            float fahrenheit = celsius * 18 / 10 + 32;

            Console.WriteLine($"{celsius} °C = {kelvin} °K = {fahrenheit} °F");

        }
            

    }
}
