using System;
using System.IO;

namespace Bai11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Cô điền cả đường dẫn thì nó mới nhận file
            Console.Write("Enter the filename (including path if necessary): ");
            string filename = Console.ReadLine();

            Console.Write("Enter the content to write into the file: ");
            string content = Console.ReadLine();

            try
            {
                File.WriteAllText(filename, content);
                Console.WriteLine("Content written to file successfully.");

                string fileContent = File.ReadAllText(filename);

                Console.WriteLine("\nContent read from the file:");
                Console.WriteLine(fileContent);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}
