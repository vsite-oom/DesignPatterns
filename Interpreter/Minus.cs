namespace DesignPatterns.Interpreter
{
    public class Minus : IExpression
    {
        private IExpression expression;

        public Minus(IExpression expression)
        {
            this.expression = expression;
        }

        public double Interpret(Context context)
        {
            return -expression.Interpret(context);
        }
    }
}
