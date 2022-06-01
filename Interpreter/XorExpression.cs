using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Interpreter
{
    public class XorExpression : IExpression
    {
        public XorExpression(IExpression leftSide, IExpression rightSide)
        {
            this.rhs = rightSide;
            this.lhs = leftSide;
        }
        private IExpression lhs, rhs;
        public bool Interpret(Context context)
        {
            return lhs.Interpret(context) ^ rhs.Interpret(context);
        }
    }
}
