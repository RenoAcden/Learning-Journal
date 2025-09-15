using System;
using System.Collections.Generic; //for dictionary
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Lists <>
            //it allogate the space they need

            List<int> Numbers = new List<int>()
            {
                1,2, 3, 4, 5, 6, 7, 8, 9
            };

            Numbers.Add(10);
            Numbers.Add(11);

            for (int i = 0; i < Numbers.Count; i++)
            {
                Console.Write($"{Numbers[i]} ");
            }

            Numbers.RemoveAt(0);
            Console.WriteLine();
            Numbers.Remove(11);
            foreach (var item in Numbers)
            {
                Console.WriteLine(item);
            }

            //Dictionary

            Dictionary<int, string> names = new Dictionary<int, string>()
            {
                //KeyValuePair
                { 1, "Reno" },
                { 2, "Fabi" },
                { 3, "Karthi" }
            };

            for (int i = 0; i < names.Count; i++)
            {
                KeyValuePair<int, string> pair = names.ElementAt(i);
                Console.WriteLine($"{pair.Key} - {pair.Value}");
            }

            foreach (KeyValuePair<int, string> test in names)
            {
                Console.WriteLine($"{test.Key} - {test.Value}");
            }

            Dictionary<string, string> teachers = new Dictionary<string, string>
            {
                {"Math", "Fabi" },
                {"Science", "Ramesh" }
            };

            //Console.WriteLine(teachers["Math"]);

            if (teachers.TryGetValue("Math", out string teacher))
            {
                Console.WriteLine(teacher);

                teachers["Math"] = "joe";
            }
            else
            {
                Console.WriteLine("math teacher not found");
            }
            /*
            if (teachers.ContainsKey("Math"))
            {
                teachers.Remove("Math");
            }
            else
            {
                Console.WriteLine("Math not found ");
            }*/

            foreach (var item in teachers)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Double tap Enter to EXIT");
            Console.ReadLine();
        }
    }
}
