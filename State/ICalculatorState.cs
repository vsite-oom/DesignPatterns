namespace DesignPatterns.State
{
    interface ICalculatorState
    {
        void Evaluate(double value);
        double Value { get; }
    }

    abstract class CalculatorState : ICalculatorState
    {
        protected CalculatorState(double value)
        {
            Value = value;
        }

        public double Value { get; protected set; }

        public abstract void Evaluate(double value);
    }
}
