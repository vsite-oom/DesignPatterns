namespace DesignPatterns.Interpreter
{
    public class Divide : IExpression
    {
        private IExpression leftside;
        private IExpression rightside;

        public Divide(IExpression leftside, IExpression rightside)
        {
            this.leftside = leftside;
            this.rightside = rightside;
        }

        public double Interpret(Context context)
        {
            return leftside.Interpret(context) / rightside.Interpret(context);
        }
    }
}
