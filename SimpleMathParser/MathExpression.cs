using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace SimpleMathParser
{
    public class MathExpression
    {
        private string text;
        private string pattern = @"^(\d+)([/*+-]\d+)*$";

        public MathExpression(string text)
        {
            this.text = text;
        }

        public bool Valid {
            get {
                return Regex.IsMatch(text, pattern);
            }
        }
    }
}