using FactoryMethod_2.Product;

namespace FactoryMethod_2.ConcreteProduct
{
    internal class ConcreteProduct2 : IProduct
    {
        public string Operation()
        {
            return "'Result of ConcreteProduct2'";
        }
    }
}
