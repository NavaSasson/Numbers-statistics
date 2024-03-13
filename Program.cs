using Ex01_05;
using System;
using System.Linq;

namespace Ex01_05
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Please enter a positive integer which contains 9 digits:");
            string inputFromUser = GetValidInputFromUser();
            TheLargestDigitInNumber(inputFromUser);
            TheSmallestDigitInNumber(inputFromUser);
            HowManyDigitsDivisibleByFour(inputFromUser);
            CountDigitsBiggerThanUnitDigit(inputFromUser);
        }

        private static string GetValidInputFromUser()
        {
            string inputFromUser = Console.ReadLine();
            bool isValidInput = CheckIfValidInput(inputFromUser);

            if (!isValidInput)
            {
                Console.WriteLine("Invalid number, try again!");
                inputFromUser = GetValidInputFromUser();
            }

            return inputFromUser;
        }

        private static bool CheckIfValidInput(string i_InputStr)
        {
            bool isIntegerNumber = int.TryParse(i_InputStr.TrimStart('0'), out int result);
            bool isValidInput = isIntegerNumber;

            if (isIntegerNumber)
            {
                bool isPositiveNumber = int.Parse(i_InputStr, System.Globalization.NumberStyles.Integer) > 0;
                isValidInput = isPositiveNumber;
                if (isPositiveNumber)
                {
                    bool isStrContainNineDigits = i_InputStr.Length == 9;
                    isValidInput = isStrContainNineDigits;
                }
            }

            return isValidInput;
        }

        private static void TheLargestDigitInNumber(string i_InputStr)
        {
            char maxDigit = i_InputStr.Max();

            Console.WriteLine("The largest digit in your number is {0}", maxDigit);
        }

        private static void TheSmallestDigitInNumber(string i_InputStr)
        {
            char minDigit = i_InputStr.Min();

            Console.WriteLine("The smallest digit in your number is {0}", minDigit);
        }

        private static void HowManyDigitsDivisibleByFour(string i_InputStr)
        {
            int digitsDivisibleByFourCounter = i_InputStr.Count(c => int.Parse(c.ToString()) % 4 == 0);

            Console.WriteLine("The number of digits which divisible by four is {0}", digitsDivisibleByFourCounter);
        }

        private static void CountDigitsBiggerThanUnitDigit(string i_InputStr)
        {
            char unitDigit = i_InputStr.Last();
            int digitsBiggerThanUnitDigitCounter = i_InputStr.Count(c => c > unitDigit);

            Console.WriteLine("The number of digits which bigger than the unit digit is {0}", digitsBiggerThanUnitDigitCounter);
        }
    }
}
