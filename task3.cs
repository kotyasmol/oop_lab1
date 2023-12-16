using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    internal class task3
    {
            static void Main(string[] args)
            {
                PrintMenu();
            }

            static void SolveFloat()
            {
            float result, a = 1000f, b = 0.0001f;

            result = ((float)Math.Pow((a + b), 4) - (((float)Math.Pow(a, 4) + 4 * (float)Math.Pow(a, 3) * b))) / ((6 * (float)Math.Pow(a, 2) * (float)Math.Pow(b, 2)) + (float)Math.Pow(b, 4) + 4 * a * (float)Math.Pow(b, 3));
            Console.WriteLine("результат вычислений: " + result);
            }

            static void SolveDouble()
            {
            double a = 1000, b = 0.0001, result;

            result = (Math.Pow((a+b),4)-((Math.Pow(a,4)+4*Math.Pow(a,3)*b))) / ((6*Math.Pow(a,2)*Math.Pow(b,2)) + Math.Pow(b,4)+ 4*a*Math.Pow(b,3)); 
            Console.WriteLine("результат вычислений: " + result);
            }

            static void PrintMenu()
            {
                string buf;
                while (true)
                {
                    Console.WriteLine("Меню выбора задачи:");
                    Console.WriteLine("1 - Решить с  чилами типа float");
                    Console.WriteLine("2 - Решить с  чилами типа double");
                    Console.WriteLine("3 - Выход");

                    Console.Write("Введите номер задачи: ");
                    buf = Console.ReadLine();

                    if (buf == "3")
                        break;

                    switch (buf)
                    {
                        case "1":
                            SolveFloat();
                            break;

                        case "2":
                            SolveDouble();
                            break;
                      
                        default:
                            Console.WriteLine("Ошибка");
                            break;
                    }
                }

                Console.WriteLine("Завершение программы");
            }
        }
    }