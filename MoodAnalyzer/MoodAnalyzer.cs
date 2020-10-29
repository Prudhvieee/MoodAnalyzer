using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyzerProblem
{
    public class MoodAnalyzer
    {
        private string message;
        /// <summary>
        /// Initializes a new instance of the <see cref="MoodAnalyzer"/> class.
        /// </summary>
        /// <param name="message">The message.</param>
        public MoodAnalyzer(string message)
        {
            this.message = message;
        }
        /// <summary>
        /// AnalyseMood method is used to find the mood wheather the person is sad or happy.
        /// </summary>
        /// <param name="mesaage">The mesaage.</param>
        /// <returns></returns>
        public string AnalyseMood(string mesaage)
        {
            try
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
            catch
            {
                return "HAPPY";
            }
        }
    }
}
