namespace DesignPatterns.NullObject
{
    internal class Program
    {
        private static void DoSomething(ConsoleLogger logger)
        {
            logger.Log($"I am in '{System.Reflection.MethodBase.GetCurrentMethod().Name}'");
        }

        private static void DoSomethingElse(ConsoleLogger logger)
        {
            logger.Log($"I am in '{System.Reflection.MethodBase.GetCurrentMethod().Name}'");
        }

        // TODO: 038 Add NullLogger class to prevent logging output

        private static void Main(string[] args)
        {
            var logger = new ConsoleLogger();

            DoSomething(logger);
            DoSomethingElse(logger);
            DoSomething(logger);
        }
    }
}
