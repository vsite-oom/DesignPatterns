namespace DesignPatterns.Interpreter
{
	public class Multiply : IExpression
	{
		public Multiply(IExpression lhs, IExpression rhs)
		{
			this.lhs = lhs;
			this.rhs = rhs;
		}

		private readonly IExpression lhs;
		private readonly IExpression rhs;
		public double Interpret(Context context)
		{
			return lhs.Interpret(context) * rhs.Interpret(context);
		}
	}
}
