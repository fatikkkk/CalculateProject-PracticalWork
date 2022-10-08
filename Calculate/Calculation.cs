using System;

namespace Calculate
{
    public class Calculation
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Sub(int a, int b)
        {
            return a - b;
        }
        public int Multiplication(int a, int b)
        {
            return a * b;
        }
        public int Division(int a, int b)
        {
            if (b == 0)
            {
                Console.WriteLine("Error");
                return 0;
            }
            else
            {
                return a / b;
            }
        }
        public int Percent(int a, int b)
        {
            return a % b;
        }
    }
}
