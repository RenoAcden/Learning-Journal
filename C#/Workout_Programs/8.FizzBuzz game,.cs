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
            
            //FizzBuzz Game

            Console.Write("Enter a number : ");
            int a = Convert.ToInt32(Console.ReadLine());

            bool threeDiv = false;
            bool fiveDiv = false;

            for (int i = 1; i <= a; i++)
            {
                threeDiv = i % 3 == 0;
                fiveDiv = i % 5 == 0;

                if (threeDiv && fiveDiv)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (threeDiv)
                {
                    Console.WriteLine("Fizz");
                }
                else if (fiveDiv)
                {

                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }

            }
            Console.WriteLine();
            
            Console.WriteLine();
            Console.WriteLine("Double tap Enter");
            Console.ReadLine();
        }
    }
}
