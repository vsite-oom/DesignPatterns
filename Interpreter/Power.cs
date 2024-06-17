using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Interpreter
{
    public class Power : IExpression
    {
        private IExpression lhs;
        private IExpression rhs;

        public Power(IExpression lhs, IExpression rhs)
        {
            this.lhs = lhs;
            this.rhs = rhs;
        }

        public double Interpret(Context context)
        {
            return Math.Pow(lhs.Interpret(context), rhs.Interpret(context));
        }
    }
}
