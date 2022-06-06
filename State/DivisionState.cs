using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.State
{
    class DivisionState : CalculatorState
    {
        public DivisionState(double? initialValue) : base (initialValue?? 1)
        {
        }
        public override void Evaluate(double value)
        {
            Value = Value / value;
        }
    }
}
