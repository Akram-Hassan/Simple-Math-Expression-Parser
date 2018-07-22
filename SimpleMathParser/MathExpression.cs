namespace SimpleMathParser
{
    public class MathExpression
    {
        private string text;

        public MathExpression(string text)
        {
            this.text = text;
        }

        public string[] tokens {
            get {
                return new string[0];
            }
        }
    }
}