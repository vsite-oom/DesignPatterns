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
            this.leftSide = leftSide;
            this.rightSide = rightSide;
        }

        private IExpression leftSide;
        private IExpression rightSide;

        public bool Interpret(Context context)
        {
            return this.leftSide.Interpret(context) ^ this.rightSide.Interpret(context);
        }
    }
}
