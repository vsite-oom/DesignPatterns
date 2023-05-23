namespace DesignPatterns.State
{
    class SubtractionState : CalculatorState
    {
        public SubtractionState(double? initialValue) : base(initialValue ?? 0)
        {
        }
        public override void Evaluate(double value)
        {
            Value -= value;
        }
    }
}
