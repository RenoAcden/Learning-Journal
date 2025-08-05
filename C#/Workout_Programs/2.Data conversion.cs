using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    class Program
    {
        static void Main(string[] args)
        {

            string textRollNo = "84";
            int intNo = Convert.ToInt32(textRollNo);
            Console.WriteLine(intNo);

            string textLongNo = "289347238787";
            long LongNo = Convert.ToInt64(textLongNo);
            Console.WriteLine(LongNo);

            string textDouble = "-85.6547";
            double DoubleNo = Convert.ToDouble(textDouble);
            Console.WriteLine(DoubleNo);

            string textfloat = "4.76";
            float FloatNo = Convert.ToSingle(textfloat);
            Console.WriteLine(FloatNo);

            string textDecimal = "8.7653";
            decimal DecimalNo = Convert.ToDecimal(textDecimal);
            Console.WriteLine(DecimalNo);

	    bool boolFlase = false;    
            bool boolTrue = true;

            Console.WriteLine(boolTrue);
            Console.WriteLine(boolFlase);

            Console.ReadLine();
        }
    }
}
