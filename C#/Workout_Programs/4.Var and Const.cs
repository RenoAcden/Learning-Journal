using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace MyFirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
        {
            //Var:
            
            var a = 35;
            Console.WriteLine(a);

            var b = 3.345345D;
            Console.WriteLine(b);

            var c = 34568823476L;
            Console.WriteLine(c);

            var d = 4.7F;
            Console.WriteLine(d);

            var e = 3.3454M;
            Console.WriteLine(e);

            var f = "Hello World";
            Console.WriteLine(f);

            var g = 'R';
            Console.WriteLine(g);
            Console.WriteLine();

            //Const:

            const int h = 2025;
            int n = 10;
            const double s = h / 2D;

            Console.WriteLine(n * s);
            Console.WriteLine(n * h / 2D);
            Console.WriteLine();

            //Number Zero is not printing when 0 is put in front but when you put in a string it will work

            string Name = "Reno Acden R";
            int NoZero = 0123456789;
            string YesZero = "0123456789";
            int age = 20;

            Console.WriteLine(Name);
            Console.WriteLine(NoZero);
            Console.WriteLine(YesZero);
            Console.WriteLine(age);
            Console.WriteLine();

            var Name1 = "Reno Acden R";
            var NoZero1 = 0123456789;
            var YesZero1 = "0123456789";
            var age1 = 20;

            Console.WriteLine(Name1);
            Console.WriteLine(NoZero1);
            Console.WriteLine(YesZero1);
            Console.WriteLine(age1);





            Console.ReadLine();
        }
    }
}
