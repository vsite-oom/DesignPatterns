namespace DesignPatterns.Interpreter
{
    public class ConstantTerminalExpression : IExpression
    {
        private readonly double value;

        public ConstantTerminalExpression(double value)
        {
            this.value = value;
        }

        public double Interpret(Context context)
        {
            return value;
        }
    }
}
