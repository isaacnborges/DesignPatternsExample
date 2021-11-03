namespace Adapter_1.Target
{
    public class Logger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"Log padrão - {message}");
        }

        public void LogError(Exception exception)
        {
            Console.WriteLine($"Log padrão erro - {exception.Message}");
        }
    }
}
