namespace DesignPatterns.NullObject
{
    internal class ConsoleLogger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
    internal class NullLogger
    {
        public new void Log(string message)
        {
            
        }
    }
}
