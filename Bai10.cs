using System;

namespace Bai10
{
    struct Student
    {
        public string Name;
        public double Score;

        public Student(string name, double score)
        {
            Name = name;
            Score = score;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of students: ");
            int n;

            while(!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                Console.WriteLine("Invalid number. Please enter a positive integer: ");
            }

            Student[] students = new Student[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter information for student {i + 1}:");

                Console.Write("Name: ");
                string name = Console.ReadLine();

                double score;
                Console.Write("Score: ");
                while (!double.TryParse(Console.ReadLine(), out score) || score <= 0 || score > 100)
                {
                    Console.WriteLine("Invalid score. Please enter a score between 0 and 100: ");
                }

                students[i] = new Student(name, score);
            }

            Console.WriteLine("\nStudent Information:");
            double totalScore = 0;
            for (int i = 0;i < n;i++)
            {
                Console.WriteLine($"Student {i + 1}: Name: {students[i].Name}, Score: {students[i].Score}");
                totalScore += students[i].Score;
            }

            double averageScore = totalScore / n;
            Console.WriteLine($"\nThe average score of the class is: {averageScore:F2}");
        }
    }
}
