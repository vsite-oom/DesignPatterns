namespace DesignPatterns.Interpreter
{
    class Interpreter
    {
        static void Main(string[] args)
        {
            // Expression: 3 + 5
            IExpression constant3 = new ConstantTerminalExpression(3);
            IExpression constant5 = new ConstantTerminalExpression(5);
            IExpression sum3and5 = new Add(constant3, constant5);
            var result = sum3and5.Interpret(new Context());
            Console.WriteLine($"3 + 5 = {result}");

            // Expression: 5 + a
            IExpression a = new VariableTerminalExpression("a");
            IExpression sum5andA = new Add(constant5, a);

            // Evaluate for a = 10
            var context = new Context(new Dictionary<string, double>() { { "a", 10 } });
            result = sum5andA.Interpret(context);
            Console.WriteLine($"5 + a = {result}, for {context}");
            // Evaluate for a = 8            
            context = new Context(new Dictionary<string, double>() { { "a", 8 } });
            result = sum5andA.Interpret(context);
            Console.WriteLine($"5 + a = {result}, for {context}");

            // Expression: a - b
            IExpression b = new VariableTerminalExpression("b");
            IExpression subtractBfromA = new Subtract(a, b);
            // Evaluate for a = 5, b = 12
            context = new Context(new Dictionary<string, double>() { { "a", 5 }, { "b", 12 } });
            result = subtractBfromA.Interpret(context);
            Console.WriteLine($"a - b = {result}, for {context}");

            // Expression: a - b + c
            IExpression triplet = new Add(subtractBfromA, new VariableTerminalExpression("c"));
            // Evaluate for a = 5, b = 12, c = 3
            context = new Context(new Dictionary<string, double>() { { "a", 5 }, { "b", 12 }, { "c", 3 } });
            result = triplet.Interpret(context);
            Console.WriteLine($"a - b + c = {result}, for {context}");
            // Evaluate for a = 17, b = 5, c = 2
            context = new Context(new Dictionary<string, double>() { { "a", 17 }, { "b", 5 }, { "c", 2 } });
            result = triplet.Interpret(context);
            Console.WriteLine($"a - b + c = {result}, for {context}");

            // Expression: -(a - b + c)
            IExpression minusTriplet = new Minus(triplet);
            // Evaluate for a = 17, b = 5, c = 2
            result = minusTriplet.Interpret(context);
            Console.WriteLine($"-(a - b + c) = {result}, for {context}");

            // 3.3a Implement and test Multiply and Divide classes.

            var multiplySausage = new Multiply(minusTriplet, minusTriplet);
            result = multiplySausage.Interpret(context);
            Console.WriteLine($"-(a - b + c) * -(a - b + c) = {result}, for {context}");
            // TODO: 3.3b Add Power class, implement and test it.
        }
    }
}
