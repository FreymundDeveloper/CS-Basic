using System;

namespace BasicLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Number 1

            Student[] studentsList = new Student[10];

            Console.WriteLine("Number of students:");
            int studentsNumber = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < studentsNumber; i++) 
            {

                Console.WriteLine("Enter your name:");
                string name = Console.ReadLine()!;
                Console.WriteLine("Enter your email:");
                string email = Console.ReadLine()!;
                Console.WriteLine("Number your room number:");
                int room = int.Parse(Console.ReadLine()!);

                studentsList[room] = new Student(name, email);
            }

            for (int i = 0; i < 10; i++) {
                if (studentsList[i] != null) Console.WriteLine($"{i}: {studentsList[i].ReturnData()}");
            }

            // Number 2

            Console.WriteLine("How many employees will be registered:");
            int employeesNumber = int.Parse(Console.ReadLine()!);

            List<Emplyoee> list = new List<Emplyoee>();

            for (int i = 0; i < employeesNumber; i++)
            {
                Console.WriteLine($"Emplyoee #{i+1}:\nEnter a id, name and salary (Enter each data):");
                list.Add(new Emplyoee(int.Parse(Console.ReadLine()!), Console.ReadLine()!, double.Parse(Console.ReadLine()!)));
            }

            Console.WriteLine("Enter the employee id that will have salary increase:");
            int idSearch = int.Parse(Console.ReadLine()!);

            Emplyoee? search = list.Find(x => x.Id == idSearch);
            if (search != null)
            {
                Console.WriteLine("Enter the percentage:");
                search.SalaryIncrease(double.Parse(Console.ReadLine()!));
            }
            else Console.WriteLine("This id does not exist!");

            Console.WriteLine("Updated list of employees:");
            foreach (Emplyoee item in list)
            {
                Console.WriteLine(item.ReturnData());
            }

            // Number 3

            Console.WriteLine("Enter the value for M:");
            int m = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Enter the value for N:");
            int n = int.Parse(Console.ReadLine()!);

            int[,] mat = new int[m, n];

            for (int i = 0; i < m; i++)
            {
                string[] line = Console.ReadLine()!.Split(' ');
                for (int j = 0; j < n; j++)
                {
                    mat[i,j] = int.Parse(line[j]);
                }
            }

            Console.Write("Number:");
            int x = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (x == mat[i, j])
                    {
                        Console.WriteLine($"Position: {i}, {j}:");

                        if (j > 0) Console.WriteLine($"Left: {mat[i, j - 1]}");
                        if (i > 0) Console.WriteLine($"Up: {mat[i - 1, j]}");
                        if (j < n - 1) Console.WriteLine($"Right: {mat[i, j + 1]}");
                        if (i < m - 1) Console.WriteLine($"Down: {mat[i + 1, j]}");
                    }
                }
            }
        }
    }
}