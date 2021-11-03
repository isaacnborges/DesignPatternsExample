namespace Command_2
{
    public class Receiver
    {
        public void DoSomething(string value)
        {
            Console.WriteLine($"Receiver: Working on ({value}.)");
        }

        public void DoSomethingElse(string value)
        {
            Console.WriteLine($"Receiver: Also working on ({value}.)");
        }
    }
}
