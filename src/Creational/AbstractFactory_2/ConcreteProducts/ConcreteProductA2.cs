using AbstractFactory_2.AbstractProducts;

namespace AbstractFactory_2.ConcreteProducts
{
    public class ConcreteProductA2 : IAbstractProductA
    {
        public string UsefulFunctionA()
        {
            return "A2 - The result of the product A2";
        }
    }
}
