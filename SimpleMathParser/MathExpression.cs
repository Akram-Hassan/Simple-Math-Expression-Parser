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

        public bool Valid {
            get {
                return false;
            }
        }
    }
}