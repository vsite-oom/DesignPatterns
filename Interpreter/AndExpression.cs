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
            this.lhs = lhs;
            this.rhs = rhs;
        }

        private IExpression lhs;
        private IExpression rhs;
        public bool Interpret(Context context)
        {

            return lhs.Interpret(context) && rhs.Interpret(context);
        }
    }
}
