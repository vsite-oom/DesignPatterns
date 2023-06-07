namespace DesignPatterns.NullObject
{
    interface ILogger
    {
        void Log(string message);
    }
    internal class ConsoleLogger:ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
    class NullLogger : ILogger
    {
        public void Log(string message)
        {
            
        }
    }
}
