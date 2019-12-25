using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            double katet1;
            double katet2;
            double sqare;
            double perimeter;
            katet1 = double.Parse(Console.ReadLine());
            katet2 = double.Parse(Console.ReadLine());
            sqare = (katet2 * katet1) / 2;
            perimeter = katet1 + katet2 + Math.Sqrt(katet2 * katet2 + katet1 * katet1);
            Console.WriteLine(sqare);
            Console.WriteLine(perimeter);
            Console.ReadKey();
            

            
          
            
        }
    }
}
