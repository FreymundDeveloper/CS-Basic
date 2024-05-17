using System;

namespace DictionaryManipulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = File.OpenText(@"C:\Users\Lucas\Desktop\CS-Basic\OOP\DictionaryConcepts\Files\in.csv")) 
            {
                Dictionary<string, int> map = new Dictionary<string, int>();

                while (!reader.EndOfStream)
                {
                    string[] data = reader.ReadLine()!.Split(',');

                    if (map.ContainsKey(data[0])) map[data[0]] += int.Parse(data[1]);
                    else map[data[0]] = int.Parse(data[1]);
                }

                foreach (var item in map)
                {
                    Console.WriteLine($"{item.Key}: {item.Value}");
                }
            }
        }
    }
}