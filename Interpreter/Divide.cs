namespace DesignPatterns.Interpreter
{
    public class Divide : IExpression
    {
        private IExpression expression;

        public Divide(IExpression expression)
        {
            this.expression = expression;
        }

        public double Interpret(Context context)
        {
            throw new NotImplementedException();
        }
    }
}
