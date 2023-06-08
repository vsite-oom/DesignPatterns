namespace DesignPatterns.Interpreter
{
    public class Add : IExpression
    {
        private IExpression leftside;
        private IExpression rightside;

        public Add(IExpression leftside, IExpression rightside)
        {
            this.leftside = leftside;
            this.rightside = rightside;
        }

        public double Interpret(Context context)
        {
            return leftside.Interpret(context) + rightside.Interpret(context);
        }
    }
}
