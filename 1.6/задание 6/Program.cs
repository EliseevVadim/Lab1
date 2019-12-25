using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задание_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,b,c,d,e,answer;
            a = int.Parse(Console.ReadLine());
            b = a / 1000;
            c = a % 10;
            d = (a % 100)/10;
            e = (a / 100)%10;
            answer = b * c * d * e;
            Console.WriteLine(answer);
            Console.ReadKey();

        }
    }
}
