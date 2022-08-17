// BASIC CALCULATOR PROGRAM

using System;

    namespace BasicCalculator
{
    class Calculator
    {
        static int num1 = 0;
        static int num2 = 0;
        static string option;
        static double result;
        static string goOn = "Y";
        static int count = 0;
        
        static void Main(string[] args)
        {
            while(goOn == "Y")  // Added a loop if user wants to continue calculating
            {   
                if (count == 0) { 
                Console.WriteLine("\t----------  ----------");
                Console.Write("\tBGB's Basic Calculator");
                Console.WriteLine(" :)");
                Console.WriteLine("\t----------  ---------");
                } 
                Console.Write("\tEnter first number: ");
                num1 = Convert.ToInt32(Console.ReadLine()); // If you enter decimals it doesn't work.
                Console.WriteLine(num1.GetType());
                Console.Write("\tEnter second number: ");
                num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\n\tSelect an option that you want to execute:");
                Console.WriteLine("\n\t + : Add");
                Console.WriteLine("\t - : Subtract");
                Console.WriteLine("\t x : Multiply");
                Console.WriteLine("\t / : Divide");
                
                option = Console.ReadLine();
               
                switch (option)
                {
                    case "+":
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine($"\tOption you entered is: {option}");
                        result = num1 + num2;
                        Console.WriteLine($"\t{num1} + {num2} = " + result);
                        break;

                    case "-":
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine($"\tOption you entered is: {option}");
                        result = num1 - num2;
                        Console.WriteLine($"\t{num1} - {num2} = " + result);
                        break;

                    case "x":
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine($"\tOption you entered is: {option}");
                        result = num1 * num2;
                        Console.WriteLine($"\t{num1} x {num2} = " + result);
                        break;

                    case "/":
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine($"\tOption you entered is: {option}");
                        result = num1 / num2;
                        Console.WriteLine($"\t{num1} / {num2} = " + result);
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"\tOption you entered is: {option}");
                        Console.WriteLine("\tcharacter you entered is not defined.");
                        break;
                }
                count++;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\n\tDo you want to continue? Y : yes / N : no");
                goOn = Console.ReadLine().ToUpper();

                if (goOn != "Y" && goOn != "N") {
                    Console.WriteLine($"You entered: {goOn}" + ". You should enter \"Y\" or \"N\" ");
                        while (goOn != "Y" && goOn != "N")
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\n\tDo you want to continue? Y : yes / N : no");
                            Console.ForegroundColor = ConsoleColor.White;
                            goOn = Console.ReadLine().ToUpper();
                        }
                }

            } 
        }

    }

}
