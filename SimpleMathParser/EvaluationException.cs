using System;

namespace SimpleMathParser
{
    public class EvaluationException : Exception
    {
        public EvaluationException()
        {
        }

        public EvaluationException(string message)
        : base(message)
        {
        }

        public EvaluationException(string message, Exception inner)
        : base(message, inner)
        {
        }
    }
}