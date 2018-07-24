using System.Linq;
using System.Collections.Generic;

namespace SimpleMathParser
{
    public class MathExpression
    {
        private string text;

        public MathExpression(string text)
        {
            this.text = text;
        }

        public List<string> tokens {
            get {
                var tokens = new List<string>();
                if (!string.IsNullOrEmpty(text))
                    tokens = text.Split(new char[] { '+' , '-' , '*' , '/' })
                                .ToList();
                return tokens;
            }
        }
    }
}