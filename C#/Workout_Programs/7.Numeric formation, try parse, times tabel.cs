using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Globalization;

namespace MyFirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Numeric Formation

            double value = 1000D  / 12.43D;

            Console.WriteLine(value);
            Console.WriteLine(string.Format("{0} {1}", value, 1000));

            Console.WriteLine(string.Format("{0:0}", value));
            Console.WriteLine(string.Format("{0:0#}", value));
            Console.WriteLine(string.Format("{0:0.0}", value));
            Console.WriteLine(string.Format("{0:0.#}", value));
            Console.WriteLine(string.Format("{0:0.00}", value));
            Console.WriteLine(value);

            double rupees = 10D / 3D;
            Console.WriteLine(string.Format("₹{0:0.0}",rupees));
            Console.WriteLine(rupees.ToString("C"));
            Console.WriteLine(rupees.ToString("C0"));
            Console.WriteLine(rupees.ToString("C1"));
            Console.WriteLine(rupees.ToString("C2"));

            Console.WriteLine(rupees.ToString("C",CultureInfo.CurrentCulture));
            Console.WriteLine(rupees.ToString("C", CultureInfo.CreateSpecificCulture("en-GB")));
            Console.WriteLine(rupees.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));
            Console.WriteLine(rupees.ToString("C", CultureInfo.CreateSpecificCulture("en-AU")));
            

            //TryParse function

            bool success = true;

            while (success)
            {
            
                Console.Write("Enter a number : ");
                string nstring = Console.ReadLine();
            

                if (int.TryParse(nstring, out int n))
                {
                    success = false;
                    Console.WriteLine(n);
                }
                else
                {
                    Console.WriteLine("Failed to convert");
                }

            }
            

            //Tinmes Table


            bool done = true;

            while (done)
            {
                Console.Write("Give a number for Times Tabel : ");
                string tInput = Console.ReadLine();

                if (int.TryParse(tInput, out int t))
                {
                    if (t == 0)
                    {
                        Console.WriteLine("There is No table for Zero!, Try Again");
                        Console.WriteLine();
                    }
                    else
                    {
                        for (int i = 1; i <= 10; i++)
                        {
                            //Console.WriteLine(i + " X " + t + " = " + i * t);
                            Console.WriteLine("{0} X {1} = {2}", i, t, i*t);
                        }
                        done = false;
                    }

                }
                else
                {
                    Console.WriteLine("Invalid Number, Try Again");
                    Console.WriteLine();
                }
            }

            Console.WriteLine();
            Console.WriteLine("Double tap Enter");
            Console.ReadLine();
        }
    }
}
