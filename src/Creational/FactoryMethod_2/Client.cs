using FactoryMethod_2.ConcreteCreator;
using FactoryMethod_2.Creator;

namespace FactoryMethod_2
{
    public class Client
    {
        public static void Execute()
        {
            Console.WriteLine("App: Launched with the ConcreteCreator1.");
            ClientCode(new ConcreteCreator1());

            Console.WriteLine("");

            Console.WriteLine("App: Launched with the ConcreteCreator2.");
            ClientCode(new ConcreteCreator2());
        }

        public static void ClientCode(AbstractCreator creator)
        {
            Console.WriteLine("Client: I'm not aware of the creator's class, but it still works." +
                              "\n" + creator.SomeOperation());
        }
    }
}
