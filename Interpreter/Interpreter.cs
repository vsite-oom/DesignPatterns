using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalInterpreter
{
    class Interpreter
    {
        static void Main(string[] args)
        {
            IExpression left = new ConstantTerminalExpression(false);
            IExpression right = new VariableTerminalExpression("a");
            IExpression or = new OrExpression(left, right);
            var result = or.Interpret(new Context(new Dictionary<string, bool>() { { "a", false }, { "b", true } }));
            Console.WriteLine(result);
        }
    }
}
