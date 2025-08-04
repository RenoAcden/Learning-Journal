using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            int a = 45;
            Console.WriteLine(a);
            Console.WriteLine(int.MinValue);
            Console.WriteLine(int.MaxValue);

            float b = 3.6F;
            Console.WriteLine(b);
            Console.WriteLine(float.MinValue);
            Console.WriteLine(float.MaxValue);

            double c = 57862.8572D;
            Console.WriteLine(c);
            Console.WriteLine(double.MinValue);
            Console.WriteLine(double.MaxValue);

            decimal d = 6.234M;
            Console.WriteLine(d);
            Console.WriteLine(decimal.MinValue);
            Console.WriteLine(decimal.MaxValue);

            long l = 235587L;
            Console.WriteLine(l);
            Console.WriteLine(long.MinValue);
            Console.WriteLine(long.MaxValue);

            a = 64;

            Console.WriteLine(a);

            Console.ReadLine();
        }
    }
}
