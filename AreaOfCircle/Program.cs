using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfCircle
{
    class Program
    {
        static void Main(string[] args)
        {
            const double pi = 3.14;
            double radius;
            double.TryParse(Console.ReadLine(), out radius);
            Console.WriteLine((radius * radius) * pi);
        }
    }
}