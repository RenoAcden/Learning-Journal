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

            //Array Sorting

            int[] numbers = new int[]
            {
                7,4,8,3,0,5,9,1,2,6
            };

            foreach (int j in numbers) {
                Console.Write(j);
            }
            Console.WriteLine();

            Array.Sort(numbers);
            
            foreach(int i in numbers)
            {
                Console.Write(i);
            }

            //Array reversal

            Console.WriteLine();
            Array.Reverse(numbers);

            foreach (var item in numbers)
            {
                Console.Write(item);
            }

            //Array cleaning

            Console.WriteLine();

            Array.Clear(numbers, 5, 5); //(stored name, starting index, from starting index count forward)
            Array.Clear(numbers, 0, numbers.Length);

            for (int i = 0; i < numbers.Length; i++) //mimic version of Clear
            {
                numbers[i] = default; // default = 0
            }

            foreach (var test in numbers)
            {
                Console.Write(test);
            }


            //Array IndexOF

            int[] test24 = new int[] {
                10, 20, 30, 40, 50, 60, 70, 80, 90
            };

            Console.WriteLine("Enter a number to search : ");
            int search = Convert.ToInt32(Console.ReadLine());

            //int position = Array.IndexOf(test24, search);
            //int position = Array.IndexOf(test24, search, 2); //starts the search from the given index 
            int position = Array.IndexOf(test24, search, 3, 4); //starts the search from the given index and end with the given index



            //or
            /*
            int position = -1;

            for (int i = 0; position >= 0; i++) 
            { 
                if (search == test24[i])
                {
                    position = i;
                }
            }
            */

            if (position == -1)
            {
                Console.WriteLine($"Number {search} has been found at position {position + 1}");
            }
            else
            {
                Console.WriteLine($"Number {search} has not been found");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Double tap Enter to EXIT");
            Console.ReadLine();
        }
    }
}
 