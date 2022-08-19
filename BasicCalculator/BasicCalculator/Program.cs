// BASIC CALCULATOR PROGRAM

using System;

namespace BasicCalculator
{
    class Calculator
    {
        static double num1 = 0;   //double'a çevirdik.
        static double num2 = 0;   //double'a çevirdik.
        static string option;
        static double result;
        static string goOn = "Y";
        static int count = 0;

        static void introMsg()
        {
            Console.WriteLine("\t----------  ----------");
            Console.Write("\tBGB's Basic Calculator");
            Console.WriteLine(" :)");
            Console.WriteLine("\t----------  ---------");
        }

        static void getNumbers()
        {
            Console.Write("\tEnter first number: ");
            num1 = Convert.ToDouble(Console.ReadLine()); 
            Console.Write("\tEnter second number: ");
            num2 = Convert.ToDouble(Console.ReadLine());
        }

        static void showOptions()
        {
            Console.WriteLine("\n\tSelect an option that you want to execute:");
            Console.WriteLine("\n\t + : Add");
            Console.WriteLine("\t - : Subtract");
            Console.WriteLine("\t x : Multiply");
            Console.WriteLine("\t / : Divide");

        }

        static void getOption()
        {
            option = Console.ReadLine();
        }

        static void ifUndefinedOptionEntered()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\tYou entered: {option}");
            Console.WriteLine("\tCharacter you entered is not defined. You should enter from the list below. \n\tSelect an option that you want to execute:\n\t +: Add\n\t -: Subtract\n\t x: Multiply\n\t / : Divide");
            Console.ForegroundColor = ConsoleColor.White;
        }

       /* static void SwitchCase()
        {
            switch (option)
            {
                case "+":
                    Console.ForegroundColor = ConsoleColor.Blue;
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
            }
        } */

        static void doYouWantToContinue()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n\tDo you want to continue? Y: yes / N: no");
            goOn = Console.ReadLine().ToUpper();
            while (goOn != "Y" && goOn != "N")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\n\tYou entered: {goOn}" + ". You should enter \"Y\" or \"N\" ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\n\tDo you want to continue? Y: yes / N: no");
                goOn = Console.ReadLine().ToUpper();
            }

        }

        static void showResult()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            //Console.WriteLine($"\n\tOption you entered is: {option}");
            switch (option)
            {
                case "+":
                    result = num1 + num2;
                    Console.WriteLine($"\n\t{num1} {option} {num2} = {result}");
                    break;

                case "-":
                    result = num1 - num2;
                    Console.WriteLine($"\n\t{num1} {option} {num2} = {result}");
                    break;

                case "x":
                    result = num1 * num2;
                    Console.WriteLine($"\n\t{num1} {option} {num2} = {result}");
                    break;

                case "/":
                    result = num1 / num2;
                    Console.WriteLine($"\n\t{num1} {option} {num2} = {result}");
                    break;
                default:
                    while (option != "+" && option != "-" && option != "x" && option != "/")
                    {
                        ifUndefinedOptionEntered();
                        getOption();
                        showResult();

                    }
                    //doYouWantToContinue();
                    //getNumbers();
                    //showOptions();
                    //showResult();
                    break;
            }
        }
            
        
                static void Main(string[] args)
            {
                    while (goOn == "Y")  // Added a loop if user wants to continue calculating
                    {
                        if (count == 0)
                        {
                            introMsg();
                        }

                         getNumbers();
                         showOptions();
                         getOption();
                         showResult();
                         doYouWantToContinue();
                         count++;

                }
                Console.WriteLine("\n\tProgram Ended.");
            }

        }

    }

