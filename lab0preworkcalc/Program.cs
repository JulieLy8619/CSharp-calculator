using System;

namespace lab0preworkcalc
{
    class Program
    {
        static void Main(string[] args)
        {
            //asks the user which what they want to do (add, subtract, multiply, or divide)
            Console.WriteLine("What would you like to do: Add (+), Subtract (-), Multiply (*) or Divide (/)?");
            string userCalcChoice = Console.ReadLine();
            string userCalcChoiceUpper = userCalcChoice.ToUpper();

            //asks the user for their numbers
            Console.WriteLine($"What is the first number you would like to {userCalcChoice}");
            int userParamOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"What would you like to {userCalcChoice} against {userParamOne}");
            int userParamTwo = Convert.ToInt32(Console.ReadLine());

            //if clauses to call which function
            //I want answer format to be param1 choice param2 = answer
            if (userCalcChoice == "+" || userCalcChoiceUpper == "ADD") 
            {
                int addAnswer = Addition(userParamOne, userParamTwo);
                Console.WriteLine($"{userParamOne} + {userParamTwo} = {addAnswer}");
            }
            else if (userCalcChoice == "-" || userCalcChoiceUpper == "SUBTRACT")
            {
                int subAnswer = Subtraction(userParamOne, userParamTwo);
                Console.WriteLine($"{userParamOne} + {userParamTwo} = {subAnswer}");
            }
            else if (userCalcChoice == "*" || userCalcChoiceUpper == "MULTIPLY")
            {
                int multAnswer = Multiplication(userParamOne, userParamTwo);
                Console.WriteLine($"{userParamOne} + {userParamTwo} = {multAnswer}");
            }
            else if (userCalcChoice == "/" || userCalcChoiceUpper == "DIVIDE")
            {
                int divAnswer = Division(userParamOne, userParamTwo);
                Console.WriteLine($"{userParamOne} + {userParamTwo} = {divAnswer}");
            }
            else //they didn't chose on of my selection, add do while if I have time later to repeat to ask until I get a valid choice
            {
                Console.WriteLine($"{userCalcChoice} is not a feature of this calculator");
            }
            Console.ReadLine();//so it doesn't auto exit
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
