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
             //Verbatim string literal (@)
            
            
            // \t \n \" \\=\
            //$ +
            //$"Your name is {name}"
            //"Your name s" + name

            string sentence = "He said \"something\"";
            Console.WriteLine(sentence);

            string dummy = "C:\\Users\\CoffeeNCode\\Desktop\\C#";
            Console.WriteLine(dummy);
 
            dummy = @"C:\\Users\\CoffeeNCode\\Desktop\\C#";
            Console.WriteLine(dummy);

            dummy = @"C:\Users\CoffeeNCode\Desktop\C#";
            Console.WriteLine(dummy);

            string reno= "HI 'Everyone'";
            Console.WriteLine(reno);

            sentence = @"He said ""something""";
            Console.WriteLine(sentence);

            reno = @"Good ""Morining""" + "\n Everyone ";
            Console.WriteLine(reno);

            Console.WriteLine();
            
            //String formatting ({0})

            string name = "Reno";
            int age = 20;

            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);

            Console.WriteLine();

            Console.WriteLine("Name: " + name + "\nAge: " + age);
            Console.WriteLine();

            Console.WriteLine("Name: {0} \nAge: {1}", name, age);

            Console.WriteLine();
            Console.WriteLine("Double tap Enter");
            Console.ReadLine();
        }
    }
}
