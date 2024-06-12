using System;

namespace Bai9
{
    internal class Program
    {
        static void Main()
        {
            bool countinueProgram = true;

            while (countinueProgram)
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Reverse a string");
                Console.WriteLine("2. Count the number of words in a string");
                Console.WriteLine("3. Exit");
                Console.Write("Enter your choice (1, 2, or 3): ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Please enter a string to count words: ");
                        string inputToReversed = Console.ReadLine();
                        string reversed = RevereseString(inputToReversed);
                        Console.WriteLine($"The reversed string is: {reversed}");
                        break;

                    case "2":
                        Console.Write("Please enter a string to count words: ");
                        String inputToCount = Console.ReadLine();
                        int wordCount = CountWords(inputToCount);
                        Console.WriteLine($"The number of words in the string is: {wordCount}");
                        break;

                    case "3":
                        countinueProgram = false;
                        Console.WriteLine("Exiting the program. Goodbye!");
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please enter 1, 2, or 3.");
                        break;
                }
                Console.WriteLine();
            }
        }
        static string RevereseString(string str)
        {
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        static int CountWords(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return 0;
            }

            string[] words = str.Split(new char[] { ' ', '\t', '\n'},StringSplitOptions.RemoveEmptyEntries);
            return words.Length;
        }
    }
}
