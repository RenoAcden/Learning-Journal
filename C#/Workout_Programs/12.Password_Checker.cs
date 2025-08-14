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

            //Password checker

            Console.Write("Enter a Password : ");
            string password = Console.ReadLine();

            Console.Write("Enter Password again : ");
            string passworda = Console.ReadLine();
            
            if (!password.Equals(string.Empty))
            {
                if (! passworda.Equals(string.Empty))
                {
                    if (password.Length >= 6 && passworda.Length >= 6)
                    {
                        if (password.Equals(passworda))
                        {
                            Console.WriteLine("Password is same");
                        }
                        else
                        {
                            Console.WriteLine("Password is not same, Enter same password");
                        }
                    }
                    else
                    {
                        Console.WriteLine("The password should contain 6 or more letters");
                    }

                }
                else
                {
                    Console.WriteLine("Please Enter the comformation password");
                }
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Please Enter a password");
            }




            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Double tap Enter to EXIT");
            Console.ReadLine();
        }
    }
}
