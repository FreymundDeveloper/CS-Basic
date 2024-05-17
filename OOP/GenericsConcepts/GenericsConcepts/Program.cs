using System;

namespace GenericsConcepts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] coursesOptions = ["A", "B", "C"];
            HashSet<int>[] courses = [new HashSet<int>(), new HashSet<int>(), new HashSet<int>()];

            for (int i = 0; i < coursesOptions.Length; i++)
            {
                Console.Write($"How many students for course {coursesOptions[i]}: ");
                int stundesNumber = int.Parse(Console.ReadLine()!);

                for (int j = 0; j < stundesNumber; j++)
                {
                    courses[i].Add(int.Parse(Console.ReadLine()!));
                }
            }

            HashSet<int> allData = new HashSet<int>(courses[0]);
            allData.UnionWith(courses[1]);
            allData.UnionWith(courses[2]);

            Console.WriteLine($"Total students: {allData.Count}");
        }
    }
}