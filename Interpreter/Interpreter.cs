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
            // Primjer (logički OR): false || a
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

            // Primjer: a ^ b & c || !d
            var negation = new NotExpression(new VariableTerminalExpression("d"));
            var andOp = new AndExpression(new VariableTerminalExpression("b"), new VariableTerminalExpression("c"));
            var xorOp = new XorExpression(new VariableTerminalExpression("a"), andOp);
            var final = new OrExpression(xorOp, negation);

            var c1 = new Context(new Dictionary<string, bool>() { { "a", false }, { "b", false }, { "c", false }, { "d", false } });
     
            Console.WriteLine(final.Interpret(c1));
            c1 = new Context(new Dictionary<string, bool>() { { "a", false }, { "b", false }, { "c", true }, { "d", false } });
     
            Console.WriteLine(final.Interpret(c1));
            Console.ReadKey();
        }
    }
}
