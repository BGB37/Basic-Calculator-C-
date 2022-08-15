// BASIC CALCULATOR PROGRAM

using System;

    namespace BasicCalculator
{
    class Calculator
    {
        static double num1 = 0;
        static double num2 = 0;
        static string option;
        static double result;
         
        static void Main(string[] args)
        {
            Console.WriteLine("\t----------  ----------");
            Console.Write("\tBGB's Basic Calculator");
            Console.WriteLine(" :)");
            Console.WriteLine("\t----------  ---------");
            Console.Write("Enter first number: ");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter second number: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Select an option that you want to execute:");
            Console.WriteLine("\t + : Add");
            Console.WriteLine("\t - : Subtract");
            Console.WriteLine("\t x : Multiply");
            Console.WriteLine("\t / : Divide");
            option = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Option you entered is: {option}");
            Console.ForegroundColor = ConsoleColor.Blue;
            switch (option)
            {
                case "+": 
                    result = num1 + num2;
                    Console.WriteLine($"{num1} + {num2} = " + result );
                    break;

                case "-":
                    result = num1 - num2;
                    Console.WriteLine($"{num1} - {num2} = " + result);
                    break;

                case "x":
                    result = num1 * num2;
                    Console.WriteLine($"{num1} x {num2} = " + result);
                    break;

                case "/":
                    result = num1 / num2;
                    Console.WriteLine($"{num1} / {num2} = " + result);
                    break;

                default:
                    Console.WriteLine("Option you entered is not defined");
                    break;
            }
            Console.ForegroundColor = ConsoleColor.White;

        }

    }

}
