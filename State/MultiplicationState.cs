namespace DesignPatterns.State
{
    class MultiplicationState : CalculatorState
    {
        public MultiplicationState(double? initialValue) : base(initialValue ?? 1)
        {
        }
        public override void Evaluate(double value)
        {
            throw new NotImplementedException();
        }
    }
}
