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
        static string goOn = "Y";
        static int count = 0;
        static double input;  // New
        static bool numberEnteredAndAccepted = false;
    

        static void introMsg()
        {
           Console.WriteLine
                (@"                          
                    --------------------
                   |      10 x 10 = 100 |
                   |____________________|
                   |  1    2    3   +   |
                   |  4    5    6   -   |
                   |  7    8    9   /   |
                   |  0   00   000  x   |
                   |____________________|");
            Console.ForegroundColor= ConsoleColor.Green;    
            Console.WriteLine(@"
                    ----------  ----------
                    BGB's Basic Calculator
                    ----------  --------- ");
            Console.ResetColor();
        }

        static void getNumbers()
        { 
            while (numberEnteredAndAccepted == false) // turn untill entered values are valid.
            {
                // static bool
                try
                {
                 Console.Write("\n\tEnter first number: ");
                 num1 = Convert.ToDouble(Console.ReadLine());
                 //if(!double.TryParse(input, out inputAfterParsedToDouble)
                 //checkIfNumberCanBeParsedToIntNum1();
                 Console.WriteLine("\n\tFirst number: {0}", num1);  // Only to check
                  
                 Console.Write("\n\tEnter second number: ");
                 num2 = Convert.ToDouble(Console.ReadLine());
                 //checkIfNumberCanBeParsedToIntNum2();
                 Console.WriteLine("\n\tSecond number: {0}", num2); // Only to check

                    numberEnteredAndAccepted = true;
               
                }
                catch (Exception e) // Uygulamanın catch'e girmesi bir exception'ın yakalanması demek.
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n\tThere was an error. \n\tDescription of the error is: " + e.Message);
                    //Console.BackgroundColor = ConsoleColor.Black;
                    Console.ResetColor();
                    numberEnteredAndAccepted = false;
                }
            }
          
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
            Console.Write("\n\tDo you want to continue? Y: yes / N: no");
            Console.WriteLine();
            goOn = Console.ReadLine().ToUpper();
            while (goOn != "Y" && goOn != "N")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"\n\tYou entered: {goOn}" + ". You should enter \"Y\" or \"N\" ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\n\n\tDo you want to continue? Y: yes / N: no");
                Console.WriteLine();
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

        static void programEnded()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("\n\tPROGRAM ENDED");
            Console.ResetColor();
        }


        static void Main(string[] args)
        {
            while (goOn == "Y")  // Added a loop if user wants to continue calculating
            {
                if (count == 0) // Eğer kullanıcı aynı oturum içerisinde ikinci veya daha fazla sayıdaki işlemini yapıyorsa, giriş mesajına gerek yok.
                {
                    introMsg();
                }

                getNumbers();
                showOptions();
                getOption();
                showResult();
                doYouWantToContinue();
                count++;
                numberEnteredAndAccepted = false; // Her turda getNumbers() içindeki while a girmesi için bu değişkeni her ana döngü sonunda false yapıyorum.


            }
            programEnded();
        }

    }

}

