using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    class Program
    {
        static void Main(string[] args)
        {

            int age = 37;
            age++;
            Console.WriteLine(age);

            age--;
            Console.WriteLine(age);

            age += 10;
            Console.WriteLine(age);

            age -= 10;
            Console.WriteLine(age);

            age *= 1;
            Console.WriteLine(age);

            age /= 10; //3.7 -> 3
            Console.WriteLine(age);

            double No = 47;
            Console.WriteLine(No/2);

            Console.WriteLine(age++);

            Console.WriteLine(++age);

            string x = "I am"; ;
            Console.WriteLine(x+" Reno");

            int a = 20;
            int b = 3;
            Console.WriteLine(a%b);






            Console.ReadLine();
        }
    }
}
