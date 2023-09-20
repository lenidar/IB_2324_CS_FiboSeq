using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IB_2324_CS_FiboSeq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 1;
            int num3 = 0;

            Console.WriteLine($"0 - {num1}\n0 - {num2}");

            for(int x = 0; x < 50; x++)
            {
                num3 = num1 + num2;
                num1 = num2;
                num2 = num3;
                Console.WriteLine($"{x + 1} - {num3}");
            }

            Console.ReadKey();
        }
    }
}
