using System;
using System.Numerics;
using MySharedLibrary;

namespace MainApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MyUtilityClass utility = new MyUtilityClass();
            int numberToCheck = GetNumberFromUser("Enter a number to check if it's even or odd: ");
            bool isEven = utility.IsEvenNumber(numberToCheck);
            Console.WriteLine($"The number {numberToCheck} is {(isEven ? "even" : "odd")}.");

            UserManagementModule userModule = new UserManagementModule();

            int numberForFactorial = GetNumberFromUser("Enter a number to calculate its factorial: ");
            BigInteger factorialResult = userModule.CalculateFactorial(numberForFactorial);
            Console.WriteLine($"Factorial of {numberForFactorial} is: {factorialResult}");
        }

        static int GetNumberFromUser(string message)
        {
            int number;
            while (true)
            {
                Console.Write(message);
                if (int.TryParse(Console.ReadLine(), out number))
                {
                    return number;
                }
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
        }
    }
}
