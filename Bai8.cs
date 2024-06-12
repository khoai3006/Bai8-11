using System;
using System.Collections.Generic;
using System.Text;

namespace Bai8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. ASCII Table");
                Console.WriteLine("2. UTF-8 Table");
                Console.WriteLine("3. Beep Sound");
                Console.WriteLine("4. Character Frequency");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AsciiTable();
                        break;
                    case 2:
                        Utf8Table();
                        break;
                    case 3:
                        BeepSound();
                        break;
                    case 4:
                        CharacterFrequency();
                        break;
                    case 5:
                        Console.WriteLine("Exiting...");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }

        static void AsciiTable()
        {
            Console.WriteLine("ASCII Table:");
            Console.WriteLine("Decimal\tChar");

            for (int i = 0; i < 128; i++)
            {
                if (i >= 32 && i <= 126)
                {
                    Console.WriteLine($"{i}\t{(char)i}");
                }
                else
                {
                    Console.WriteLine($"{i}\tNon-printable");
                }
            }
        }

        static void Utf8Table()
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Table UTF-8 (code 65001):");
            Console.WriteLine("Char\tUTF-8 Bytes");

            for (int i = 0; i < 256; i++)
            {
                char ch = (char)i;
                string utf8Bytes = BitConverter.ToString(Encoding.UTF8.GetBytes(new[] { ch }));
                Console.WriteLine($"{ch}\t{utf8Bytes}");
            }
        }

        static void BeepSound()
        {
            Console.WriteLine("Press Spacebar to play a beep sound. Press Esc to exit!");

            bool exit = false;

            while (!exit)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey(true);

                    if (key.Key == ConsoleKey.Spacebar)
                    {
                        Console.Beep();
                        Console.WriteLine("Beep!");
                    }
                    else if (key.Key == ConsoleKey.Escape)
                    {
                        exit = true;
                    }
                }
            }
        }

        static void CharacterFrequency()
        {
            Console.WriteLine("Enter a string: ");
            string input = Console.ReadLine();

            Dictionary<char, int> charCount = new Dictionary<char, int>();

            foreach (char c in input)
            {
                if (charCount.ContainsKey(c))
                {
                    charCount[c]++;
                }
                else
                {
                    charCount[c] = 1;
                }
            }

            Console.WriteLine("The frequency of each character:");
            foreach (KeyValuePair<char, int> entry in charCount)
            {
                Console.WriteLine($"'{entry.Key}' has appeared {entry.Value} time.");
            }
        }
    }
}
