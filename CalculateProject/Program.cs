using System;
using Calculate;

namespace CalculateProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Введите два числа:");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Вы ввели следующие числа: " + a + " и " + b);
            Console.WriteLine("Введите операцию");
            string oper = Console.ReadLine();
            Console.WriteLine("Вы выбрали следующую операцию: " + oper);
            Calculation calculate = new Calculation();
            int res = 0;
            switch (oper)
            {
                case "+":
                    {
                        res = calculate.Add(a, b);
                        Console.WriteLine("Result: " + res);
                        break;
                    }
                case "-":
                    {
                        res = calculate.Sub(a, b);
                        Console.WriteLine("Result: " + res);
                        break;
                    }
                case "*":
                    {
                        res = calculate.Multiplication(a, b);
                        Console.WriteLine("Result: " + res);
                        break;
                    }
                case "/":
                    {
                        res = calculate.Division(a, b);
                        Console.WriteLine("Result: " + res);
                        break;
                    }
                case "%":
                    {
                        res = calculate.Percent(a, b);
                        Console.WriteLine("Result: " + res);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Выбрана неверная операция");
                        break;
                    }
            }
        }
    }
}
