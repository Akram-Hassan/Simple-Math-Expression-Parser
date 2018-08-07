namespace SimpleMathParser
{
    public enum Operator {
        Add, Subtract, Multiple, Divide
    }

    public struct MathOperation
    {
        private Operator mathOperator;
        private int value;

        public int Value => this.value;
        public Operator Operator => this.mathOperator;

        public MathOperation(int value, Operator mathOperator)
        {
            this.value = value;
            this.mathOperator = mathOperator;
        }
    }
}