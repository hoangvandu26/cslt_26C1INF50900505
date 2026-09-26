using System;
using System.Collections.Generic;
using System.Text;

namespace cslt.baitap7_arrays
{
    internal class linear_search
    {
        /*-Request a sentence from the user, then ask to enter a word.
          Search if the word appears in the phrase using the linear search algorithm.*/
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Nhập một câu văn:");
            string doan_van = Console.ReadLine();
            Console.WriteLine($"Câu bạn vừa nhập: {doan_van}");
            Console.Write("Nhập một từ bất kỳ để kiểm tra có trong câu của bạn hay không: ");
            string tu = Console.ReadLine();
            bool check = false;
            for (int i = 0; i <= doan_van.Length - tu.Length; i++)
            {
                bool co = true;
                for (int j = 0; j < tu.Length; j++)
                {
                    if (doan_van[i + j] != tu[j])
                    {
                        co = false;
                        break;
                    }
                }
                if (co) { check = true; break; }
            }

            if (check)
            {
                Console.WriteLine(check);
            }
            else { Console.WriteLine("false"); }
        }
    }
}
