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
            
            //Arrays[]

            Console.Write("Enter the size of the array : ");
            int j = Convert.ToInt32(Console.ReadLine());

            string[] numbers = new string[j];

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("Enter a number : ");
                numbers[i] = Console.ReadLine(); 
            }

            Console.WriteLine();

            for (int i = 0; i < numbers.Length; i++) 
            {
                Console.Write($"{numbers[i]} ");
            }
            Console.WriteLine();

            /*
            Console.WriteLine();

            foreach (int num in numbers) //by using this loop this will go from start to end, we can't control the loop like for loop 
            {
                Console.WriteLine($"{num} ");
            }
            */

            // Adding using Array

            Console.Write("Enter how many numbers to add : ");
            int anglecount = Convert.ToInt32(Console.ReadLine());

            int angleadd = 0;
            for (int i = 0; i < anglecount; i++)
            {
                Console.Write($"Enter value {i+1} : ");
                angleadd += Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine($"Answer : {angleadd}");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Double tap Enter to EXIT");
            Console.ReadLine();
        }
    }
}
