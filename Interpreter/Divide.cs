namespace DesignPatterns.Interpreter
{
    public class Divide : IExpression
    {
        private IExpression lhs;
        private IExpression rhs;

        public Divide(IExpression expression)
        {
            this.lhs=lhs;
            this.rhs=rhs;
        }

        public double Interpret(Context context)
        {
            return lhs.Interpret(context) / rhs.Interpret(context);
        }
    }
}
