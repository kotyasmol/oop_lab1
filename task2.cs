using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    //var11
    internal class task2
    {
        static double ReadDouble()
        {
            double outputDoub = 0;
            bool parsed = false;
            do
            {
                try
                {
                    Console.Write("Enter number ");
                    outputDoub = Convert.ToDouble(Console.ReadLine());
                    parsed = true;
                }
                catch
                {
                    Console.WriteLine("Error");
                }
            } while (!parsed);

           return outputDoub;
        }
        static void Main()
        {
            Console.WriteLine("X1: ");
            double x = ReadDouble();

            Console.WriteLine("Y1: ");
            double y = ReadDouble();

            bool result = (Math.Pow(x, 2) + Math.Pow(y, 2) <= 1)
                && (y<=0 && x<=0);
            if (result) { Console.WriteLine(result);}
            else { Console.WriteLine(result);}
        }
    }
}
