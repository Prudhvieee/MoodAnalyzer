using System;
using System.Collections.Generic;
using System.Text;
namespace MoodAnalyzerProblem
{
    public class MoodAnalyzer
    {
        string message;
        public MoodAnalyzer(string message)
        {
            this.message = message;
        }
        /// <summary>
        /// AnalyseMood method is used to find the mood wheather the person is sad or happy.
        /// </summary>
        /// <returns>Sad else Happy.</returns>
        public string AnalyseMood(string message)
        {
            if (message.Contains("sad"))
            {
                return "SAD";
            }
            else
            {
                return "HAPPY";
            }
        }
    }
}