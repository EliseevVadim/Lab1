using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задание_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, x;
            x = int.Parse(Console.ReadLine());
            a = x * x;
            Console.WriteLine((a + x + 1) * (3 * a - 8 * x + 7));
            Console.ReadKey();
        }
    }
}
