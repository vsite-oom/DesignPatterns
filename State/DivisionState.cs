namespace DesignPatterns.State
{
    class DivisionState : CalculatorState
    {
        public DivisionState(double? initialValue) : base (initialValue?? 1)
        {
        }
        public override void Evaluate(double value)
        {
            Value/=value;
        }
    }
}
