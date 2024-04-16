using System;
using System.Globalization;

namespace InitialConcepts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Number 1
            Person person1 = new Person();
            Person person2 = new Person();

            Person[] persons = [ person1, person2 ];

            for (int i = 1; i <= persons.Length; i++)
            {
                Console.WriteLine($"Person #{i} name and age:");
                string[] data = Console.ReadLine()!.Split(' ');
                persons[i - 1].Name = data[0];
                persons[i - 1].Age = int.Parse(data[1]);
            }

            string? result = (persons[0].Age > persons[1].Age) ? persons[0].Name : persons[1].Name;
            Console.WriteLine($"Older person: {result}");

            // Number 2
            Employee emplyee1 = new Employee();
            Employee emplyee2 = new Employee();

            Employee[] employees = [emplyee1, emplyee2];

            for (int i = 1; i <= employees.Length; i++)
            {
                Console.WriteLine($"Employee #{i} name and wage:");
                string[] data = Console.ReadLine()!.Split(' ');
                employees[i - 1].Name = data[0];
                employees[i - 1].Wage = double.Parse(data[1], CultureInfo.InvariantCulture);
            }

            Console.WriteLine($"Average salary:{((employees[0].Wage + employees[1].Wage) / 2).ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}