namespace Observable_2
{
    public interface ISubject
    {
        void Subscribe(IObserver observer);
        void UnSubscribe(IObserver observer);
        void Notify();
    }
}
