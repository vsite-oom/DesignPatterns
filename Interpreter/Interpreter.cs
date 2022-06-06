using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Interpreter
{
    class Interpreter
    {
        static void Main(string[] args)
        {
            // Primjer (logički OR): a || false
            IExpression left = new ConstantTerminalExpression(false);
            IExpression right = new VariableTerminalExpression("a");
            IExpression or = new OrExpression(left, right);
            var result = or.Interpret(new Context(new Dictionary<string, bool>() { { "a", false }, { "b", true } }));
            Console.WriteLine(result);

            // Primjer (logički XOR): a ^ b
            left = right;
            right = new VariableTerminalExpression("b");
            IExpression xor = new XorExpression(left, right);
            result = xor.Interpret(new Context(new Dictionary<string, bool>() { { "a", false }, { "b", false } }));
            Console.WriteLine(result);

            // Primjer (logički XOR i OR): a ^ b || c
            or = new OrExpression(xor, new VariableTerminalExpression("c"));
            result = or.Interpret(new Context(new Dictionary<string, bool>() { { "a", false }, { "b", false }, { "c", true } }));
            Console.WriteLine(result);

            // Primjer (logički XOR i OR): a && b || (c ^ a)
            var and = new AndExpression(new VariableTerminalExpression("a"), new VariableTerminalExpression("b"));
            var xor2 = new XorExpression(new VariableTerminalExpression("c"), new VariableTerminalExpression("a"));
            var or2 = new OrExpression(and, xor2);
            result = or2.Interpret(new Context(new Dictionary<string, bool>() { { "a", false }, { "b", false }, { "c", true } }));
            Console.WriteLine(result);
        }
    }
}
