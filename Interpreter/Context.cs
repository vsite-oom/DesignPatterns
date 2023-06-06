namespace DesignPatterns.Interpreter
{
    public class Context
    {
        private readonly Dictionary<string, double> variables = new Dictionary<string, double>();

        public Context()
        {
        }

        public Context(Dictionary<string, double> variables)
        {
            this.variables = variables;
        }

        public double GetValue(string variableName)
        {
            return variables[variableName];
        }
    }
}
