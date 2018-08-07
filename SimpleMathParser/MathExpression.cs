using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System;

namespace SimpleMathParser
{
    public class MathExpression
    {
        private string text;
        private string pattern = @"^(\d+)([/*+-]\d+)*$";

        public MathExpression(string text)
        {
            if (!Regex.IsMatch(text, pattern))
            {
                throw new ExpressionEvaluationException($"{text} is invalid expression");
            }
            this.text = text;
        }

        public int FirstValue {
            get {
                Match firstMatch = Regex.Matches(text, pattern)[0];
                Group firstNumberGroup = firstMatch.Groups[1];

                int result;
                int.TryParse(firstNumberGroup.ToString(), out result);
                return result;
            }
        }
    }
}