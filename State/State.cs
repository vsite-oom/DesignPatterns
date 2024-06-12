using System.Diagnostics;

namespace DesignPatterns.State
{
    class Program
    {
        static void Main(string[] args)
        {
            string expression = "+ 3 7 9 - 5 -4.2 12";
            Calculator calc = new Calculator(expression);
            var result = calc.Evaluate();
            Console.WriteLine(result);

            // TODO: 3.2 Implement MultiplicationState and DivisionState classes, uncomment lines below and test functionality.
            
            expression = "+ 3 7 9 * 10.4 2 ÷ 2 - 5 -4.2 12";
            calc = new Calculator(expression);
            result = calc.Evaluate();
            Console.WriteLine(result);

            Debug.Assert(Math.Abs(result - 184.8) < 1e-4);
        }
    }
}
