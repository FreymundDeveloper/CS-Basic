using System;
using System.Drawing;
using System.Globalization;

namespace BasicCalculation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Number 1
            Console.WriteLine("Enter two values:");
            string[] value = Console.ReadLine()!.Split(' ');

            Console.WriteLine($"Sum = {int.Parse(value[0]) + int.Parse(value[1])}");

            // Number 2
            Console.WriteLine("Enter a area:");
            double area = 3.14159 * (Math.Pow(double.Parse(Console.ReadLine()!), 2));

            Console.WriteLine($"Area = {area}");

            // Number 3
            Console.WriteLine("Enter four values:");
            string[] difference = Console.ReadLine()!.Split(' ');

            Console.WriteLine($"Difference = {(int.Parse(difference[0]) * int.Parse(difference[1])) - (int.Parse(difference[2]) * int.Parse(difference[3]))}");

            // Number 4
            Console.WriteLine("Enter the number, hours worked and salary of the employee:");
            string[] employee = Console.ReadLine()!.Split(' ');

            Console.WriteLine($"NUMBER = {employee[0]}\nSALARY = U${double.Parse(employee[1]) * double.Parse(employee[2], CultureInfo.InvariantCulture)}");

            // Number 5
            Console.WriteLine("Enter the code, amount and value of the first piece:");
            string[] pieceOne = Console.ReadLine()!.Split(' ');
            Console.WriteLine("Enter the code, amount and value of the second piece:");
            string[] pieceTwo = Console.ReadLine()!.Split(' ');

            Console.WriteLine($"Value to pay: R${(double.Parse(pieceOne[1]) * double.Parse(pieceOne[2], CultureInfo.InvariantCulture)) +
                (double.Parse(pieceTwo[1]) * double.Parse(pieceTwo[2], CultureInfo.InvariantCulture))}");

            // Number 6
            Console.WriteLine("Enter the Value of A, B and C:");
            string[] valuesDigited = Console.ReadLine()!.Split(' ');
            double[] floatingPoint = [double.Parse(valuesDigited[0], CultureInfo.InvariantCulture), double.Parse(valuesDigited[1], CultureInfo.InvariantCulture), double.Parse(valuesDigited[2], CultureInfo.InvariantCulture)];

            string areaTriangleRectangle = (0.5 * floatingPoint[0] * floatingPoint[2]).ToString("F3", CultureInfo.InvariantCulture);
            string areaCircle = (3.14159 * (Math.Pow(floatingPoint[2], 2))).ToString("F3", CultureInfo.InvariantCulture);
            string areaTrapeze = (0.5 * (floatingPoint[0] + floatingPoint[1]) * floatingPoint[2]).ToString("F3", CultureInfo.InvariantCulture);
            string areaSquare = (Math.Pow(floatingPoint[1], 2)).ToString("F3", CultureInfo.InvariantCulture);
            string areaRectangle = (floatingPoint[0] * floatingPoint[1]).ToString("F3", CultureInfo.InvariantCulture);

            Console.WriteLine($"Triangle: {areaTriangleRectangle}\nCircle: {areaCircle}\nTrapeze: {areaTrapeze}\nSquare: {areaSquare}\nRectangle: {areaRectangle}");
        }
    }
}
