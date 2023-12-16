using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class task1
    {


        static int ReadValue()
        {
            bool isRead = false; 
            int value = 0; 

            do 
            {
                Console.Write("Enter number: ");
                try 
                {
                    value = Convert.ToInt32(Console.ReadLine()); 

                    isRead = true;
                }
                catch
                {
                    Console.WriteLine("Wrong format."); 
                    isRead = false; 
                }
            } while (!isRead); 

            return value; 
        }

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
                    Console.WriteLine("Wrong format");
                }
            } while (!parsed);

            return outputDoub;
        } 

        static void WriteR(int m, int n)
        {
            Console.WriteLine($"M: {m}");
            Console.WriteLine($"N: {n}");
        }

        static void Main(string[] args)
        {
            int m, n;
            Console.Write("M: ");
            m = ReadValue();
            Console.Write("N: ");
            n = ReadValue();



            int res1 = n++ + m--;
            Console.WriteLine("n+++m--");
            Console.WriteLine("Result 1: "+ res1); 
            WriteR(m, n);

            bool res2 = false; 
            res2 = n * m < n++; 
            Console.WriteLine("n*m < n++");
            Console.WriteLine($"Result 2: {res2}");
            WriteR(m, n);

            bool res3 = false;
            res3 = n-- < ++m;
            Console.WriteLine("n-- < ++m");
            Console.WriteLine($"Result 3: {res3}");
            WriteR(m, n);

            Console.Write("X: ");
            double x = ReadDouble();
            double res4;
            res4 = (Math.Pow(2, x) * x * Math.Cos(x) + 1);
            Console.WriteLine("2^x x cos(x) + 1");
            Console.WriteLine($"Result 4: {res4}");

        }
    }
}
