using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
