using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorStuff
{
    public class Calculator
    {
        public void UserInputMethod()
        {
            int current_state = 1;
            string symbol = "x";
            double inputA = 0;
            double inputB = 0;
            string readLine = "n";
            while (current_state <= 4)
            {
                switch (current_state)
                {

                    //checking symbol
                    case 1:
                        Console.WriteLine("What operation would you like to perform? (+,-,/,*)");
                        symbol = Console.ReadLine();
                        if (ValidSymbolInput(symbol) == true)
                        {
                            current_state++;
                        }
                        else
                        {
                            Console.WriteLine("That's not a valid input.");
                        }
                        break;
                    //Validating A
                    case 2:
                        Console.WriteLine("Your equation is in the form A" + symbol + "B");
                        Console.WriteLine("Input A:");
                        readLine = Console.ReadLine();
                        if (IsInputValidNumber(readLine) == true)
                        {
                            inputA = double.Parse(readLine);
                            current_state++;

                        }
                        else
                        {
                            Console.WriteLine("That's not a valid input.");
                            current_state = 2;
                        }
                        break;
                    //Validating B
                    case 3:
                        Console.WriteLine("Input B:");
                        readLine = Console.ReadLine();

                        if (IsInputValidNumber(readLine) == true)
                        {
                            inputB = double.Parse(readLine);
                            current_state++;
                        }
                        else
                        {
                            Console.WriteLine("That's not a valid input.");
                            current_state = 3;
                        }
                        break;
                    //Perform required calculation
                    case 4:
                        string answer = Calculate(symbol, inputA, inputB).ToString();
                        if (answer == null)
                        {
                            Console.WriteLine("Uh oh, something went wrong! Let's try again.");
                            current_state = 1;
                        }
                        else
                        {
                            Console.WriteLine("And the answer is...\n" + answer + "\nHoorah! \nWould you like to go again? (yes/no)");
                            string response = Console.ReadLine();
                            if (response == "yes")
                            {
                                current_state = 1;
                            }
                            else
                            {
                                Console.WriteLine("Thanks!");
                                current_state++;
                            }                          
                        }
                        break;

                }
            }
        }
            public bool ValidSymbolInput(string symbol)
        {
            if (symbol == "+" || symbol == "-" || symbol == "/" || symbol == "*")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool IsInputValidNumber(string readLine)
        {
            double converted;
            bool result = double.TryParse(readLine, out converted);
            return result;
        }

        public double Calculate(string symbol, double inputA, double inputB)
            {
                double result = 0;
                if (symbol == "+")
                {
                    return result = inputA + inputB;

                }
                if (symbol == "-")
                {
                    return result = inputA - inputB;

                }
                if (symbol == "/")
                {
                   return result = inputA / inputB;

                }
                if (symbol == "*")
            {
                return result = inputA * inputB;
            }
                else
            {
                return result;
            }
            }
          

        }
    }
