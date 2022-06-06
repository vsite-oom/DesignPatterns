using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Interpreter
{
    public class AndExpression : IExpression
    {

        public AndExpression(IExpression leftSide, IExpression rightSide)
        {
            this.leftSide = leftSide;
            this.rightSide = rightSide;
        }
    
    public bool Interpret(Context context)
    {
        return leftSide.Interpret(context) ^ rightSide.Interpret(context);
    }

        private IExpression leftSide;
        private IExpression rightSide;

    }
}
