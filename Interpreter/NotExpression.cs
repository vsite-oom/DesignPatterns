namespace DesignPatterns.Interpreter
{
    public class NotExpression : IExpression
    {
        private IExpression expression;

        public NotExpression(IExpression expression)
        {
            this.expression = expression;
        }
        public bool Interpret(Context context)
        {
            return !expression.Interpret(context);
        }
    }
}
