using System;

namespace MoodAnalyzerProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to mood analyzer.");
            Console.WriteLine("How is your mood now..?");
            string message = Console.ReadLine();
            MoodAnalyzer moodAnalyzer = new MoodAnalyzer(message);
            Console.WriteLine("you are in " + moodAnalyzer.AnalyseMood(message) + " Mood ");
        }
    }
}
