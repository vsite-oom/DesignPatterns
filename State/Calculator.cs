using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.State
{
    class Calculator
    {
        public Calculator(string expression)
        {
            splitExpression = expression.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        }

        private string[] splitExpression;

        public double Evaluate()
        {
            CalculatorContext cc = new CalculatorContext(GetOperation(splitExpression[0]), double.Parse(splitExpression[1], System.Globalization.NumberFormatInfo.InvariantInfo));
            for (int i = 2; i < splitExpression.Length; ++i)
            {
                Operation op = GetOperation(splitExpression[i]);
                if (op != Operation.Unknown)
                    cc.ChangeState(op);
                else
                    cc.Evaluate(double.Parse(splitExpression[i], System.Globalization.NumberFormatInfo.InvariantInfo));
            }
            return cc.Value;
        }

        private Operation GetOperation(string item)
        {
            switch (item)
            {
                case "+":
                    return Operation.Addition;
                case "-":
                    return Operation.Subtraction;
                case "*":
                    return Operation.Multiplication;
                case "÷":
                case "/":
                    return Operation.Division;
                default:
                    return Operation.Unknown; ;
            }
        }
    }
}
