using System;
using System.IO;

namespace WorkingWithFiles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            doApp();
            Console.ReadKey();
        }
        static void doApp()
        {
            // Path to the text file
            string filePath = "sample.txt";

            // Create a new text file
            CreateTextFile(filePath);

            // Read and display the contents of the text file
            ReadTextFile(filePath);
        }

        static void CreateTextFile(string filePath)
        {
            try
            {
                // Text to be written in the file
                string fileContent = "This is a sample text file.\n";

                // Write the text to the file
                File.WriteAllText(filePath, fileContent);

                Console.WriteLine("Text file created successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while creating the text file: " + ex.Message);
            }
        }

        static void ReadTextFile(string filePath)
        {
            try
            {
                // Read the text from the file
                string fileContent = File.ReadAllText(filePath);

                // Display the content of the file
                Console.WriteLine("\nText file content:");
                Console.WriteLine(fileContent);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while reading the text file: " + ex.Message);
            }
        }
    }
}
