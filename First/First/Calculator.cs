using System;


namespace Calculator
{
    class Program
    {
        
        static double getInput(string prompt)
        {
            double value;
            string userInput;

            Console.WriteLine(prompt);
            userInput = Console.ReadLine();

            value = double.Parse(userInput);
            return value;

        }

        static double CalculateInput(string operatorInput, double firstVal, double secondVal)
        {

            if(operatorInput == "+")
            {
                return firstVal + secondVal;
            }

            if(operatorInput == "-")
            {
                return firstVal - secondVal;
            }

            if(operatorInput == "x")
            {
                return firstVal * secondVal;
            }

            if(operatorInput == "/")
            {
                return firstVal / secondVal;
            }
            else
            {
                return 0;
            }
        }

        static void drawMinusLine()
        {
            for (int i = 0; i < 40; i++)
            {
                Console.Write("-");
            }
            Console.Write("\n");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Calculator! :)");
            double firstValue = getInput("Enter your first value: ");

            Console.WriteLine("Enter your operator (+ - / x) : ");
            string operatorInput = Console.ReadLine();

            double secondValue = getInput("Enter your second value: ");
            double answer = CalculateInput(operatorInput, firstValue, secondValue);
            Console.WriteLine("The answer is: " + answer);

            Console.WriteLine("\n" + "Thank you for using calculator :)" + "\n");

            while(true)
            {
                drawMinusLine();
                double inputVal = getInput("Enter your first value: ");

                Console.WriteLine("Enter your operator (+ - / x) : ");
                string inputOper = Console.ReadLine();

                double inputValTwo = getInput("Enter your second value: ");
                double answerOut = CalculateInput(inputOper, inputVal, inputValTwo);
                Console.WriteLine("The answer is: " + answerOut + "\n");
            }

        }
    }
}
