namespace Adapter_1.Target
{
    public interface ILogger
    {
        void Log(string message);
        void LogError(Exception exception);
    }
}
