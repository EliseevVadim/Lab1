using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задание_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int a1 = int.Parse(Console.ReadLine());
            int b1 = int.Parse(Console.ReadLine());
            int c1 = int.Parse(Console.ReadLine());
            int d1 = int.Parse(Console.ReadLine());
            int a2 = int.Parse(Console.ReadLine());
            int b2 = int.Parse(Console.ReadLine());
            int c2 = int.Parse(Console.ReadLine());
            int d2 = int.Parse(Console.ReadLine());
            int a3 = int.Parse(Console.ReadLine());
            int b3 = int.Parse(Console.ReadLine());
            int c3 = int.Parse(Console.ReadLine());
            int d3 = int.Parse(Console.ReadLine());
            int determinate = a1 * b2 * c3 + b1 * c2 * a3 + c1 * a2 * b3 - c1 * b2 * a3 - b1 * a2 * c3 - a1 * c2 * b3;
            if (determinate == 0)
            {
                Console.WriteLine("Duck Alert!");
                
            } 
            else
            {
                int determinate_x = d1 * b2 * c3 + b1 * c2 * d3 + c1 * b3 * d2 - c1 * b2 * d3 - b1 * d2 * c3 - d1 * c2 * b3;
                int determinate_y = a1 * d2 * c3 + c1 * a2 * d3 + d1 * c2 * a3 - c1 * d2 * a3 - d1 * a2 * c3 - a1 * c2 * d3;
                int determinate_z = a1 * b2 * d3 + b1 * d2 * a3 + d1 * a2 * b3 - d1 * b2 * a3 - b1 * a2 * d3 - a1 * d2 * b3;
                int x = determinate_x / determinate;
                int y = determinate_y / determinate;
                int z = determinate_z / determinate;
                Console.WriteLine("x=" + x);
                Console.WriteLine("y=" + y);
                Console.WriteLine("z=" + z);
            }
            Console.ReadKey();

        }
    }
}
