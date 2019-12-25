using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задание_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int h, m, s;
            double corner;
            h = int.Parse(Console.ReadLine());
            m = int.Parse(Console.ReadLine());
            s = int.Parse(Console.ReadLine());
            corner = (((360) * (3600 * h + 60 * m + s)) / (3600 * 12));
            Console.WriteLine(corner);
            Console.ReadKey();

        }
    }
}
