namespace SimpleMathParser
{
    public enum Operator {
        Add, Subtract, Multiply, Divide
    }

    public struct MathOperation
    {
        private Operator mathOperator;
        private int value;

        public int Value => this.value;
        public Operator Operator => this.mathOperator;

        public MathOperation(Operator mathOperator, int value)
        {
            this.value = value;
            this.mathOperator = mathOperator;
        }
    }
}