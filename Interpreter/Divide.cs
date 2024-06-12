namespace DesignPatterns.Interpreter
{
    public class Divide : IExpression
    {
        private readonly IExpression lhs;
        private readonly IExpression rhs;

        public Divide(IExpression lhs, IExpression rhs)
        {
            this.lhs = lhs;
            this.rhs = rhs;
        }

        public double Interpret(Context context)
        {
            return lhs.Interpret(context) / rhs.Interpret(context);
        }
    }
}
