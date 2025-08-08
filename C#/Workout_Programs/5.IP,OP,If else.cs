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
            
         
            int a = 20;
            int b = 2;

            int c = a % b;
            Console.WriteLine(c);


            a = 25;
            c = a % b;
            Console.WriteLine(c);
            Console.WriteLine();

            //INPUT/OUTPUT:

            Console.WriteLine("HI I am Reno. " );
            Console.Write("Enter your name : ");
            string name = Console.ReadLine();

            Console.Write("Enter your age : ");
            int age = Convert.ToInt32( Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Your name is " + name +" and your age is " + age);

            if (name != string.Empty)
            {
                Console.WriteLine("Invalid name");
            }



            if (age <= 0 || age >= 125)
            {
                Console.WriteLine("Invalid age");
            }
            else
            {
                if (age < 13)
                {
                    Console.WriteLine("You are still a child");
                }
                else if (age >= 13 && age <= 19)
                {
                    Console.WriteLine("You are now teenager");
                }
                else if (age < 0 || age >= 150)
                {
                    Console.WriteLine("Invalid age");
                }
                else
                {
                    Console.WriteLine("You are Adult");
                }
            }


            Console.ReadLine();
        }
    }
}
