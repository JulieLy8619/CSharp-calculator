using System;

namespace lab0preworkcalc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        //add function
        private static int Addition(int num1, int num2) 
        {
            return num1 + num2;
        }


        //subtraction function
        private static int Subtraction(int num1, int num2)
        {
            return num1 - num2;
        }

        //multiply function
        private static int Multiplication(int num1, int num2)
        {
            return num1 * num2;
        }

        //divide function
        private static int Division(int num1, int num2)
        {
            return num1 / num2;
        }
    }
}
