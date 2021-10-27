using System;
using System.IO; 

namespace FileCreate
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootDirectory = @"C:\Users\opilane\samples\wishlist";
            Console.WriteLine("Enter file name:");
            string fileName = Console.ReadLine();
            string fullFilePath = $@"{rootDirectory}\{fileName}.txt";

            bool DirectoryExists = Directory.Exists(rootDirectory);
            bool fileExists = File.Exists(fullFilePath);

            if (DirectoryExists && fileExists)
            {
                Console.WriteLine($"File {fileName} already exist in {rootDirectory}");
            }
            else if (!DirectoryExists)
            {
                Console.WriteLine($"Wishlist directory does not exists.");
                Directory.CreateDirectory(rootDirectory);
                File.Create(fullFilePath);
                Console.WriteLine($"File {fileName}.txt has been created.");
            }
            else
            {
                File.Create(rootDirectory);
                Console.WriteLine($"File {fileName}.txt has been created.");
            }
        }
    }
}
