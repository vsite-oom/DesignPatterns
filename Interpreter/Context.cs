namespace DesignPatterns.Interpreter
{
    public class Context
    {
        private readonly Dictionary<string, bool> variables = new Dictionary<string, bool>();

        public Context()
        {
        }

        public Context(Dictionary<string, bool> variables)
        {
            this.variables = variables;
        }

        public bool GetValue(string variableName)
        {
            return variables[variableName];
        }
    }
}
