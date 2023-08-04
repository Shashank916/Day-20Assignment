using System;
using System.Numerics;
using MySharedLibrary;

namespace MainApp
{
    public class UserManagementModule
    {
        private MyUtilityClass utility;

        public UserManagementModule()
        {
            utility = new MyUtilityClass();
        }

        public void ValidateUserInput(int number)
        {
            bool isEven = utility.IsEvenNumber(number);
            Console.WriteLine($"The number {number} is {(isEven ? "even" : "odd")}.");
        }

        public BigInteger CalculateFactorial(int number)
        {
            if (number < 0)
            {
                throw new ArgumentException("Factorial is not defined for negative numbers.");
            }

            if (number == 0 || number == 1)
            {
                return 1;
            }

            BigInteger result = 1;

            for (int i = 2; i <= number; i++)
            {
                result *= i;
            }

            return result;
        }
    }
}
