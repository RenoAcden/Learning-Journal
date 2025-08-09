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
            //Switch case

            
            Console.Write("Enter a day of a week : ");
            int day = Convert.ToInt32(Console.ReadLine());

            switch (day)
            {
                case 1:
                    Console.WriteLine("Sunday");
                    break;
                case 2:
                    Console.WriteLine("Monday");
                    break;
                case 3:
                    Console.WriteLine("Tuesday");
                    break;
                case 4:
                    Console.WriteLine("Wednesday");
                    break;
                case 5:
                    Console.WriteLine("Thrusday");
                    break;
                case 6:
                    Console.WriteLine("Friday");
                    break;
                case 7:
                    Console.WriteLine("Saturday");
                    break;
                default:
                    Console.WriteLine("Inavid week, Enter value between 1 to 7");
                    break;

            Console.WriteLine(day);

            }

            //For Loop


            Console.Write("What you want to repeat? : ");
            string msg = Console.ReadLine();

            Console.Write("How many times do You want to reapeat if? : ");
            int times = Convert.ToInt32(Console.ReadLine());


            if (times < 0)
            {
                Console.WriteLine("Sorry, Please Enter a value above 0");
            }
            else
            {
                for (int i = 0; i < times; i++)
                {
                    Console.WriteLine(msg);
                }
            }
            

            //While Loop

            Console.WriteLine("");

            int r = 0;
            while (r < 10)
            {
                Console.WriteLine(r);
                r++;
            }

	   //Example

           Console.Write("Enter first number : ");
           int num1 = Convert.ToInt32(Console.ReadLine());

           Console.Write("Enter second number : ");
           int num2 = Convert.ToInt32(Console.ReadLine());

           Console.WriteLine();
           Console.WriteLine("Whats the Value of " + num1 + " X " + num2 + "?");

           int RealAns = num1*num2;
           int FakeAns = 0;

           /*
           while (RealAns != FakeAns)
           {

               Console.Write("Enter Your answer : ");
               FakeAns = Convert.ToInt32(Console.ReadLine());
               Console.WriteLine();

               if (RealAns != FakeAns)
               {
                   Console.WriteLine("Close but it was wrong! Try Again");
               }
           }
           Console.WriteLine("Well done!");
           */

           //do while Loop

           do
           {
               Console.Write("Enter Your answer : ");
               FakeAns = Convert.ToInt32(Console.ReadLine());
               Console.WriteLine();

               if (RealAns != FakeAns)
               {
                   Console.WriteLine("Close but it was wrong! Try Again");
               }
           } while (RealAns != FakeAns);

           Console.WriteLine("Well Done!");



           Console.WriteLine();
           Console.WriteLine("Enter to Exit");
           Console.ReadLine();
        }
    }
}

