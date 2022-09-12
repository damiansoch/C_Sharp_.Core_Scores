using System;

namespace Scores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter you first name");
            string date = DateTime.Today.ToShortDateString();
            string uName = Console.ReadLine();
            string msg = $"\nWelcome back {uName}. Today is {date}.";

            Console.WriteLine(msg + "\n");


            string path = @"C:\Users\damia\source\repos\Scores\Scores\studentScores.txt";
            string[] lines = System.IO.File.ReadAllLines(path);

            double tScore = 0;
            Console.WriteLine("\nStudent Scores: \n");
            foreach (string line in lines)
            {
                Console.Write("\n" + line);
                double score = Convert.ToDouble(line);
                tScore += score;


            }
            Console.WriteLine($"\nThe total score is: {tScore}");
            Console.WriteLine($"The average is {tScore / lines.Length}");
            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();
        }
    }
}
