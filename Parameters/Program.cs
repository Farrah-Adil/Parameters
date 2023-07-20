using System;

namespace SumOfDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            string inputNumber = Console.ReadLine();

            int sum = AddDigits(inputNumber);

            Console.WriteLine($"Sum of digits: {sum}");
        }

        static int AddDigits(string numberText)
        {
            int sum = 0;

            foreach (char digitChar in numberText)
            {
                if (char.IsDigit(digitChar))
                {
                    int digitValue = int.Parse(digitChar.ToString());
                    sum += digitValue;
                }
            }

            return sum;
        }
    }
}