using System;
using System.Text;
using System.Globalization;

namespace BasicValidations 
{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            // Number 1
            Console.WriteLine("Enter a number:");
            int numberInt = int.Parse(Console.ReadLine()!);

            if (numberInt >= 0) Console.WriteLine("Not negative");
            else Console.WriteLine("Negative");

            // Number 2
            Console.WriteLine("Enter a number for validate:");
            int evenOrOdd = int.Parse(Console.ReadLine()!);

            if (evenOrOdd % 2 == 0) Console.WriteLine("Even");
            else Console.WriteLine("Odd");

            // Number 3
            Console.WriteLine("Enter two number:");
            string[] multipleEnter = Console.ReadLine()!.Split(' ');
            double[] multiple = [double.Parse(multipleEnter[0]), double.Parse(multipleEnter[1])];

            if ((multiple[0] % multiple[1] == 0) || (multiple[1] % multiple[0] == 0) || (multiple[0] * multiple[1] == 0)) Console.WriteLine("Are multiple.");
            else Console.WriteLine("Are not multiple.");

            // Number 4
            Console.WriteLine("Enter an entry and exit time (no minutes):");
            string[] times = Console.ReadLine()!.Split(' ');
            int hours = (int.Parse(times[1]) - int.Parse(times[0]) + 24) % 24;

            if (hours == 0 ) hours = 24;

            Console.WriteLine($"The game lasted: {hours}");

            // Number 5
            double[] menuItens = [4, 4.5, 5, 2, 1.5];

            Console.WriteLine("Enter the code (1 to 5) and quantity of items:");
            string[] clientChoice = Console.ReadLine()!.Split(' ');

            Console.WriteLine($"Total: R${menuItens[int.Parse(clientChoice[0]) - 1] * int.Parse(clientChoice[1])}");

            // Number 6
            Console.WriteLine("Enter a value:");
            double numberInterval = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

            if ((numberInterval >= 0) && (numberInterval < 25)) Console.WriteLine($"Interval between (0, 25)");
            else if ((numberInterval >= 25) && (numberInterval < 50)) Console.WriteLine($"Interval between (25, 50)");
            else if ((numberInterval >= 50) && (numberInterval < 75)) Console.WriteLine($"Interval between (50, 75)");
            else if ((numberInterval >= 75) && (numberInterval <= 100)) Console.WriteLine($"Interval between (75, 100)");
            else Console.WriteLine("Out of Interval");

            // Number 7
            Console.WriteLine("Enter the X and Y coordinates:");
            string[] axle = Console.ReadLine()!.Split(' ');

            double axleX = double.Parse(axle[0]);
            double axleY = double.Parse(axle[1]);

            if ((axleX == 0) && (axleY == 0)) Console.WriteLine("Origin");
            else if (axleX == 0) Console.WriteLine("Axle Y");
            else if (axleY == 0) Console.WriteLine("Axle X");
            else Console.WriteLine((axleX > 0) ? ((axleY > 0) ? "Q1" : "Q4") : ((axleY > 0) ? "Q2" : "Q3"));

            // Number 8 
            Console.WriteLine("Enter your rent:");
            double rent = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

            if ((rent >= 0) && (rent <= 2000.00)) Console.WriteLine("Exempt");
            else if ((rent > 2000.00) && (rent <= 3000.00)) Console.WriteLine($"Tax: R${((rent - 2000) * 0.08).ToString("F2", CultureInfo.InvariantCulture)}");
            else if ((rent > 3000.00) && (rent <= 4500.00)) Console.WriteLine($"Tax: R${((rent - 3000) * 0.18 + (1000.0 * 0.08)).ToString("F2", CultureInfo.InvariantCulture)}");
            else if (rent > 4500.00) Console.WriteLine($"Tax: R${((rent - 4500) * 0.28 + (1500.00 * 0.18) + (1000.0 * 0.08)).ToString("F2", CultureInfo.InvariantCulture)}");
            else Console.WriteLine("Tax Evader, good job!");
        }
    }
}