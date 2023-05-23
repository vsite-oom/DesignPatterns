namespace DesignPatterns.Interpreter
{
    public class ConstantTerminalExpression : IExpression
    {
        private readonly bool value;
        public ConstantTerminalExpression(bool value)
        {
            this.value = value;
        }

        public bool Interpret(Context context)
        {
            return value;
        }
    }
}
