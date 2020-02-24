using System;

namespace NumberLogics
{
    class Program
    {
        static void Main(string[] args)
        {
            var smallestNumber = processDevision(2520, 11);
            Console.WriteLine($"Smallest Divisible Number is {smallestNumber}");
        }

        static bool isDivisible(int number, int devider)
        {
            return number % devider == 0;
        }

        static int processDevision(int number, int devider)
        {
            while (devider < 21)
            {
                if (isDivisible(number, devider))
                {
                    devider += 1;
                    continue;
                }
                else
                {
                    number += 1;
                    number = processDevision(number, devider);
                }
            }

            return number;
        }
    }
}
