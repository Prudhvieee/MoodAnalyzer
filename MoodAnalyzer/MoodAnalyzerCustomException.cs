using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyzerProblem
{
    public class MoodAnalyzerCustomException : Exception
    {
        public enum ExceptionType
        {
            EMPTY_MESSAGE, NULL_MESSAGE
        }
        private readonly ExceptionType type;
        public MoodAnalyzerCustomException(ExceptionType type, string message):base(message)
        {
            this.type = type;
        }
    }
}
