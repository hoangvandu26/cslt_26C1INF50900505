using System;
using System.Collections.Generic;
using System.Text;

namespace cslt.session03
{
    internal class ex02
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Nhập bán kính của hình cầu: ");
            int r = int.Parse(Console.ReadLine());
            double surface = 4 * Math.PI*Math.Pow(r,2);
            double volume = (4 / 3) * Math.PI * Math.Pow(r, 3);
            Console.WriteLine($"Diện tích bề mặt của hình cầu bán kính {r} :{surface:f2} m2");
            Console.WriteLine($"Thể tích của hình cầu bán kính {r} :{volume:f2} m3");
        }
    }
}
