using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Xml;

namespace MyFirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //String iteration (looping)

            string word = "C# is Awesome C ";

            Console.WriteLine(word[0]);
            Console.WriteLine(word[1]);
            Console.WriteLine();

            for (int i = 0; i < word.Length; i++)
            {
                Console.Write(word[i]);
                Thread.Sleep(50);
            }

            Console.WriteLine();
            Console.WriteLine(word.Contains("C"));

            bool Contains = false;

            for (int j = 0; j < word.Length; j++) 
            { 
                if (word[j].Equals('C'))
                {
                    Contains = true; 
                    break;
                }
            }
            Console.WriteLine(Contains);

            //String IsNullOrEmpty function  

            Console.WriteLine("Enter your name : ");
            string name = Console.ReadLine();
            
            if (name != "")
                Console.WriteLine("0");

            if (!name.Equals(""))
                Console.WriteLine("1");

            if (!string.IsNullOrEmpty(name))
                Console.WriteLine("2");
            
            if (!string.IsNullOrEmpty(name))
            {
                if (!name.Equals(""))
                    Console.WriteLine("3");
            }
            
            //Print string in reverse

            Console.Write("Enter a message for reverse it : ");
            string eg = Console.ReadLine();

            Console.WriteLine(eg);


            for (int i = eg.Length-1; i >= 0; i--)
            {
                Console.Write(eg[i]);
            }


            



            Console.WriteLine();
            Console.WriteLine("Double tap Enter");
            Console.ReadLine();
        }
    }
}
