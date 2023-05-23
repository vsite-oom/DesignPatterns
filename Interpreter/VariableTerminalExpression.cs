namespace DesignPatterns.Interpreter
{
    public class VariableTerminalExpression : IExpression
    {
        private readonly string name;
        public VariableTerminalExpression(string name)
        {
            this.name = name;
        }
        public bool Interpret(Context context)
        {
            return context.GetValue(name);
        }
    }
}
