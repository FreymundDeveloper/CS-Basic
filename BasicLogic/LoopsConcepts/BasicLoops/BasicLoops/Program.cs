using System;

namespace BasicLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Number 1
            int passwordNumber = 0;

            while (passwordNumber != 2002) 
            {
                Console.WriteLine("Enter your number password:");
                passwordNumber = int.Parse(Console.ReadLine()!);

                if (passwordNumber == 2002) Console.WriteLine("Correct");
                else Console.WriteLine("Incorrect");
            }

            // Number 2
            int? x = null;
            int? y = null;

            while (x != 0 && y != 0)
            {
                Console.WriteLine("Enter X and Y coordinates:");
                string[] quadrant = Console.ReadLine()!.Split(' ');
                x = int.Parse(quadrant[0]);
                y = int.Parse(quadrant[1]);

                if (x > 0 && y > 0) Console.WriteLine("First");
                else if (x < 0 && y > 0) Console.WriteLine("Second");
                else if (x < 0 && y < 0) Console.WriteLine("Third");
                else if (x > 0 && y < 0) Console.WriteLine("Fourth");
            }

            // Number 3
            int alcohol = 0,
                gasoline = 0,
                diesel = 0,
                options = 0;

            while (options != 4)
            {
                Console.WriteLine("Select your favorite option (1.Alcohol 2.Gasoline 3.Diesel 4.Quit):");
                options = int.Parse(Console.ReadLine()!);

                if (options == 1) alcohol += 1;
                else if (options == 2) gasoline += 1;
                else if (options == 3) diesel += 1;
                else if (options == 4) Console.WriteLine("Thank you, Bye.");
                else Console.WriteLine("Invalid Option");
            }

            Console.WriteLine($"Alcohol: {alcohol}\nGasoline: {gasoline}\nDiesel: {diesel}");
        }
    }
}