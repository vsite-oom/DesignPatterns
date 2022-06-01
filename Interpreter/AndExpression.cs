using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Interpreter
{
    public class AndExpression : IExpression
    {
        public AndExpression(IExpression lhs, IExpression rhs)
        {
            this.leftside = lhs;
            this.rightside = rhs;
        }
        private IExpression rightside;
        private IExpression leftside;

        public bool Interpret(Context context)
        {
            return leftside.Interpret(context) & rightside.Interpret(context);
        }
    }
}
