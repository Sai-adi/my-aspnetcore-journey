using System;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main()
    {
        bool keepRunning = true;

        while (keepRunning)
        {
            Console.WriteLine("====Simple Calculator====");

            Console.Write("Enter First Number");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter First Number");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Choose operations +,-,*,/");
            string op = Console.ReadLine();

            double result = 0;
            bool validOperation = true;


            switch (op)
            {
                case "+":
                    result = num1 + num2;
                    break;

                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    result = num1 / num2;
                    break;
                default:
                    Console.WriteLine("Invalid Operator");
                    validOperation = false;
                    break;
            }
            if (validOperation)
                Console.WriteLine($"Result:{result}");

            Console.WriteLine("Do you want to perform another calculation? (y/n): ");
            string choise = Console.ReadLine();
            if (choise.ToLower() != "y")
                keepRunning = false;
            Console.WriteLine();

        }
        Console.WriteLine("Thanks for using thr Calculator");
    }
}