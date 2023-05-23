namespace DesignPatterns.State
{
    class AdditionState : CalculatorState
    {
        public AdditionState(double? initialValue) : base(initialValue ?? 0)
        {
        }
        public override void Evaluate(double value)
        {
            Value += value;
        }
    }
}
