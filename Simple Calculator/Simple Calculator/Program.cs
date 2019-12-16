using System;

namespace Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Double x;
            Double y;
            Char operation;

            Console.WriteLine("SIMPLE CALCULATOR\n");

            Console.Write("Enter first number: ");
            x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter second number: ");
            y = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the operation (+, -, *, /): ");
            operation = Convert.ToChar(Console.ReadLine());
            Console.WriteLine();

            switch (operation)
            {
                case '+':
                    Console.WriteLine("{0} + {1} = {2}.", x, y, x + y);
                    break;    

                case '-':
                    Console.WriteLine("{0} - {1} = {2}.", x, y, x - y);
                    break;

                case '*':
                    Console.WriteLine("{0} * {1} = {2}.", x, y, x * y);
                    break;

                case '/':
                    if (y == 0)
                    {
                        Console.WriteLine("Cannot divide by zero.");
                    }
                    else
                    {
                        Console.WriteLine("{0} / {1} = {2}.", x, y, x / y);
                    }
                    break;
            }

        }
    }
}
