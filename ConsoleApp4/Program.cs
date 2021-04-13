using System;

namespace ConsoleApp4
{
    public class Operations
    {
        public double Division(double a, double b)
        {
            return a / b;
        }
        public double Multiplication(double a, double b)
        {
            return a * b;
        }
        public double Subtraction(double a, double b)
        {
            return a - b;
        }
        public double Addition(double a, double b)
        {
            return a + b;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Operations obj1 = new Operations();
            Console.WriteLine(obj1.Division(12.4, 4.1));
            Console.WriteLine(obj1.Multiplication(12.4, 4.1));
            Console.WriteLine(obj1.Subtraction(12.4, 4.1));
            Console.WriteLine(obj1.Addition(12.4, 4.1));
        }
    }
}
