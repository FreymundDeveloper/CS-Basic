using FilesTreatment.Entities;
using System;
using System.Globalization;

namespace FilesTreatment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Remember to remove Summary.csv, if there is one.

                string sourcePath = @"C:\Users\Lucas\Desktop\CS-Basic\Miscellaneous\FilesManipulation\Files";
                string[] fileLines = File.ReadAllLines(sourcePath + @"\Test.csv");

                using(StreamWriter newFile = File.AppendText(sourcePath + @"\Summary.csv"))
                {
                    foreach (string line in fileLines)
                    {
                        string[] contentLine = line.Split(',');

                        Product product = new Product(contentLine[0], double.Parse(contentLine[1], CultureInfo.InvariantCulture), int.Parse(contentLine[2]));
                        newFile.WriteLine($"{product.Name}, {product.TotalPrice()}");
                    }
                }

            }
            catch (Exception ex) 
            {
                Console.WriteLine("ERROR Found: \n" + ex.Message);
            }
        }
    }
}