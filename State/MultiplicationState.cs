using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.State
{
    class MultiplicationState : CalculatorState
    {
        public MultiplicationState(double? initialValue) : base(initialValue ?? 1)
        {
        }
        public override void Evaluate(double value)
        {
            Value = Value * value;
        }
    }
}
