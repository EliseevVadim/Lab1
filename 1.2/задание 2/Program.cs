using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задание_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, hours, minutes;
            a = int.Parse(Console.ReadLine());
            hours = a / 3600;
            minutes = (a % 3600)/60;
            Console.WriteLine(hours+ " hours");
            Console.WriteLine(minutes+ " minutes");
            Console.ReadKey();
        }
    }
}
