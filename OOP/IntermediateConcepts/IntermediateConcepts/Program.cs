using System;
using System.Globalization;

namespace IntermediateConcepts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Number 1
            Rectangle item = new Rectangle();

            Console.WriteLine("Enter the width and height of the rectangle:");
            item.Width = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
            item.Height = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

            Console.WriteLine($"Area: {item.Area()}\nPerimeter: {item.Perimeter()}\nDiagonal: {item.Diagonal()}");

            // Number 2
            Employee employee = new Employee();

            Console.WriteLine("Enter your name, salary and tax (Enter each data):");
            employee.Name = Console.ReadLine();
            employee.GrossSalary = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
            employee.Tax = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

            Console.WriteLine($"Employee: {employee.DataReturn()}");

            Console.WriteLine("Enter the increase percentage:");
            double percent = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

            employee.SalaryIncrease(percent);
            Console.WriteLine($"Employee: {employee.DataReturn()}");

            // Number 3
            Student student = new Student();

            Console.WriteLine("Enter your name (Enter each data):");
            student.Name = Console.ReadLine();

            Console.WriteLine("Enter your notes (Enter each data):");
            for (int i = 0; i < 3; i++)
            {
                student.Notes![i] = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
            }

            Console.WriteLine($"Media: {student.FinalMedia()}\n{student.StudentResult()}");

            // Number 4
            Console.WriteLine("What is the dollar exchange rate:");
            double price = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

            Console.WriteLine("How many dollars will you buy:");
            double value = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

            Console.WriteLine($"Value to pay: {Price.ConversionProcess(price, value)}");
        }
    }
}