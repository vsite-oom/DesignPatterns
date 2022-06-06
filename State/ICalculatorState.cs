using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.State
{
    interface ICalculatorState
    {
        void Evaluate(double value);
        double Value { get; }
    }

    abstract class CalculatorState : ICalculatorState
    {
        public CalculatorState(double value)
        {
            Value = value;
        }

        public double Value { get; protected set; }

        public abstract void Evaluate(double value);
    }
}
