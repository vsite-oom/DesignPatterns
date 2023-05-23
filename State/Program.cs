using System.Diagnostics;

namespace DesignPatterns.State
{
    class Program
    {
        static void Main(string[] args)
        {
            string expression = "+ 3 7 9 * 10.4 2 ÷ 2 - 5 -4.2 12";
            Calculator calc = new Calculator(expression);
            var result = calc.Evaluate();
            Console.WriteLine(result);

            Debug.Assert(Math.Abs(result - 184.8) < 1e-4);
        }
    }
}
