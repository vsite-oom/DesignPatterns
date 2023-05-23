namespace DesignPatterns.State
{
    enum Operation
    {
        Addition,
        Subtraction,
        Multiplication,
        Division,
        Unknown
    }
    class CalculatorContext
    {
        public CalculatorContext(Operation operation, double value)
        {
            this.value = value;
            ChangeState(operation);
        }
        public void ChangeState(Operation operation)
        {
            switch (operation)
            {
                case Operation.Addition:
                    calculatorState = new AdditionState(Value);
                    break;
                case Operation.Subtraction:
                    calculatorState = new SubtractionState(Value);
                    break;
                case Operation.Multiplication:
                    calculatorState = new MultiplicationState(Value);
                    break;
                case Operation.Division:
                    calculatorState = new DivisionState(Value);
                    break;
            }
        }

        public void Evaluate(double val)
        {
            calculatorState.Evaluate(val);
        }

        private ICalculatorState calculatorState;

        private double value;

        public double Value => calculatorState != null ? calculatorState.Value : value;
    }
}

