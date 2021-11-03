using FactoryMethod_2.Product;

namespace FactoryMethod_2.ConcreteProduct
{
    public class ConcreteProduct1 : IProduct
    {
        public string Operation()
        {
            return "'Result of ConcreteProduct1'";
        }
    }
}
