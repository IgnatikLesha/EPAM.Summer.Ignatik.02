using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewtonMethod
{
    class ConsoleTests
    {
        static void Main(string[] args)
        {
            double x = Newton.Root(27, 3, 0.0005);
            double y = Math.Pow(27, 1/3.0);
            Console.WriteLine(x);
            Console.WriteLine(y);
            x = Newton.Root(30, 5, 0.0005);
            y = Math.Pow(30, 1 / 5.0);
            Console.WriteLine(x);
            Console.WriteLine(y);
            x = Newton.Root(200, 7, 0.0005);
            y = Math.Pow(200, 1 / 7.0);
            Console.WriteLine(x);
            Console.WriteLine(y);
            x = Newton.Root(-40, 5, 0.0005);
            y = Math.Pow(-40, 1 / 5.0);
            Console.WriteLine(x);
            Console.WriteLine(y);
            x = Newton.Root(10, -2, 0.0005);
            y = Math.Pow(10, -1 / 2.0);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.ReadLine();
        }
    }
}
