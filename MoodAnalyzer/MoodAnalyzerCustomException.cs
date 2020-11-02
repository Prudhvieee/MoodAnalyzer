using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyzerProblem
{
    public class MoodAnalyzerCustomException : Exception
    {
        public enum ExceptionType
        {
            EMPTY_MESSAGE, NULL_MESSAGE, NO_SUCH_CLASS, NO_SUCH_METHOD, NO_A_VALID_INPUT
        }
        private readonly ExceptionType type;
        readonly string message;
        public MoodAnalyzerCustomException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
            this.message = message;
        }
    }
}
