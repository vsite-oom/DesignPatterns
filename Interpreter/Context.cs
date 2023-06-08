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

        public override string ToString()
        {
            if (variables.Count == 0)
            {
                return string.Empty;
            }
            var keValues = variables.Select(kv => $"{kv.Key} = {kv.Value}");
            return string.Join(", ", keValues);
        }
    }
}
