namespace DesignPatterns.Interpreter
{
    public class XorExpression : IExpression
    {
        public XorExpression(IExpression leftSide, IExpression rightSide)
        {
        }

        public bool Interpret(Context context)
        {
            throw new NotImplementedException();
        }
    }
}
