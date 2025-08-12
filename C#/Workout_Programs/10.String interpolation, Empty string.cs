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
            /*
            //String interpolation($)

            string name = "Reno";
            int age = 20;

            Console.WriteLine("Your name is " + name + ", Your age is " + age);
            Console.WriteLine();

            Console.WriteLine($"Your name is {name}, Your age is {age}");
            Console.WriteLine();

            //String Concatenation(+)

            Console.WriteLine("String Concatenation:");
            Console.WriteLine("Your name is " + name + ", and your age is " + age);
            Console.WriteLine("Your name is {0}, and your age is {1}", name, age);
            Console.WriteLine($"Your name is {name}, and your age is {age}");

            string test = string.Concat("Your name is ", name, "and your age is ", age);
            Console.WriteLine(test);
           
            //OR

            Console.WriteLine(string.Concat("Your name is ", name, "and your age is ", age));
            Console.WriteLine();

            string[] names = new string[] { " Reno", " Fabio", " Karthi" };
            Console.WriteLine(string.Concat(names));
            

            //Empty String

            Console.WriteLine("Empty String:");

           
            string test1 = "";
            Console.WriteLine(test1);
           

            Console.Write("Enter your name: ");
            string dumy = Console.ReadLine();

            if (dumy != string.Empty)
            {
                Console.WriteLine();
                Console.WriteLine($"Your name is {dumy}");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Name is empty!");
            }
            */

            //String Equals Function

            Console.WriteLine("String Equals Function");

            Console.WriteLine("");

            string message = "Welcome";
            string compare = "Welcome";

            /*
            //here == checks the length
            if(message == compare)
                Console.WriteLine("Same");
            else
                Console.WriteLine("Different");
            */

            if (message.Equals(compare)) // here Equals check the value and memory of the string
                Console.WriteLine("Same");
            else
                Console.WriteLine("Different");

            Console.WriteLine("Enter your name: ");
            string name1 = Console.ReadLine();

            if (!name1.Equals(""))
                Console.WriteLine("Your name is " +name1);
            else
                Console.WriteLine("Invalid name input");

            Console.WriteLine();
            Console.WriteLine("Double tap Enter");
            Console.ReadLine();
        }
    }
}
