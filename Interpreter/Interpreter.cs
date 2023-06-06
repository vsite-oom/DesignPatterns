namespace DesignPatterns.Interpreter
{
    class Interpreter
    {
        static void Main(string[] args)
        {
            // Primjer: a + 5
            IExpression br1 = new ConstantTerminalExpression(5);
            IExpression br2 = new VariableTerminalExpression("a");
            IExpression add = new Add(br1, br2);
            
            var result = add.Interpret(new Context(new Dictionary<string, double>() { { "a", 10 } }));
            Console.WriteLine(result);

            // Primjer: a - b
            IExpression br3 = new VariableTerminalExpression("b");
            IExpression subtract = new Subtract(br2, br3);
            result = subtract.Interpret(new Context(new Dictionary<string, double>() { { "a", 5}, { "b", 12 } }));
            Console.WriteLine(result);

            // Primjer a - b + c
            IExpression triplet = new Add(subtract, new VariableTerminalExpression("c"));
            result = triplet.Interpret(new Context(new Dictionary<string, double>() { { "a", 5 }, { "b", 12 }, { "c", 3 } }));
            Console.WriteLine(result);

            // Primjer -(a - b + c)
            IExpression minusTriplet = new Minus(triplet);
            result = minusTriplet.Interpret(new Context(new Dictionary<string, double>() { { "a", 5 }, { "b", 12 }, { "c", 3 } }));
            Console.WriteLine(result);

            // TODO: 035a Implement and test Multiply and Divide classes

            // TODO: 035b Add Power class, implement i and test it
        }
    }
}
