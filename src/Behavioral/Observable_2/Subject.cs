namespace Observable_2
{
    public class Subject : ISubject
    {
        public int State { get; set; } = -0;
        private readonly List<IObserver> _observers = new();

        public void Subscribe(IObserver observer)
        {
            Console.WriteLine($"Subject: Subscribe an observer - {observer.GetType().Name}.");
            _observers.Add(observer);
        }

        public void UnSubscribe(IObserver observer)
        {
            _observers.Remove(observer);
            Console.WriteLine("Subject: UnSubscribe an observer.");
        }

        public void Notify()
        {
            Console.WriteLine("Subject: Notifying observers...");

            foreach (var observer in _observers)
            {
                observer.Update(this);
            }
        }

        public void SomeBusinessLogic()
        {
            Console.WriteLine("\nSubject: I'm doing something important.");
            State = new Random().Next(0, 10);

            Thread.Sleep(15);

            Console.WriteLine("Subject: My state has just changed to: " + State);
            Notify();
        }
    }
}
