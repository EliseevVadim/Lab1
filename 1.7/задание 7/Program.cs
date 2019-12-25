using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задание_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, d, c, b, reversed;
            a = int.Parse(Console.ReadLine());
            b = a / 100;
            d = a % 10;
            c = (a % 100) / 10;
            reversed = d * 100 + c * 10 + b;
            Console.WriteLine(reversed);
            Console.ReadKey();
        }
    }
}
