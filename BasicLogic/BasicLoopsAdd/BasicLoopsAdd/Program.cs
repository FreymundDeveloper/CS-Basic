using System;
using System.Globalization;

namespace BasicLoopsAdd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Number 1
            Console.WriteLine("Enter a value:");
            int count = int.Parse(Console.ReadLine()!);

            for (int i = 1; i < count; i++)
            {
                if(i % 2 != 0) Console.WriteLine(i);
            }

            // Number 2
            int inValue = 0,
                outValue = 0;

            Console.WriteLine("Enter the number of entered:");
            int volume = int.Parse(Console.ReadLine()!);

            for (int i = 1; i <= volume; i++)
            {
                Console.WriteLine($"Enter the value #{i}:");
                int test = int.Parse(Console.ReadLine()!);

                if (test >= 10 && test <= 20) inValue++;
                else outValue++;
            }

            Console.WriteLine($"In: {inValue}\nOut:{outValue}");

            // Number 3
            Console.WriteLine("Enter amount of tests:");
            int amountTests = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < amountTests; i++)
            {
                Console.WriteLine("Enter three values to get mean:");
                string[] meanValues = Console.ReadLine()!.Split(' ');

                double x1 = double.Parse(meanValues[0], CultureInfo.InvariantCulture);
                double x2 = double.Parse(meanValues[1], CultureInfo.InvariantCulture);
                double x3 = double.Parse(meanValues[2], CultureInfo.InvariantCulture);

                Console.WriteLine($"Weighted average: {(((x1 * 2) + (x2 * 3) + (x3 * 5)) / (2 + 3 + 5)).ToString("F1", CultureInfo.InvariantCulture)}");
            }

            // Number 4
            Console.WriteLine("Enter how much operations you want do:");
            int operationNumbers = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < operationNumbers; i++)
            {
                Console.WriteLine("Enter two values to divided:");
                string[] meanValues = Console.ReadLine()!.Split(' ');

                double dividend = double.Parse(meanValues[0], CultureInfo.InvariantCulture);
                double divider = double.Parse(meanValues[1], CultureInfo.InvariantCulture);

                if (divider != 0) Console.WriteLine($"Division: {(dividend / divider).ToString("F1", CultureInfo.InvariantCulture)}");
                else Console.WriteLine("Impossible division");
            }

            // Number 5
            Console.WriteLine("Enter the number you want to factor:");
            int factorial = int.Parse(Console.ReadLine()!);
            int factorialResult = factorial;


            for (int i = 1; i < factorial; i++)
            {
                factorialResult *= i;
            }

            Console.WriteLine(factorialResult);

            // Number 6
            Console.WriteLine("Enter the number to see his dividers:");
            int dividerValiation = int.Parse(Console.ReadLine()!);

            for (int i = 1; i <= dividerValiation; i++)
            {
                if (dividerValiation % i == 0) Console.WriteLine(i);
            }

            // Number 7 
            Console.WriteLine("Enter the number to see his square and cube:");
            int squareAndCubeCall = int.Parse(Console.ReadLine()!);

            for (int i = 1; i <= squareAndCubeCall; i++)
            {
                Console.WriteLine($"{i} {Math.Pow(i, 2)} {Math.Pow(i, 3)}");
            }
        }
    }
}