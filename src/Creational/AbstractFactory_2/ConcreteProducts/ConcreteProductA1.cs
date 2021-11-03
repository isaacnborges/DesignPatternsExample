using AbstractFactory_2.AbstractProducts;

namespace AbstractFactory_2.ConcreteProducts
{
    public class ConcreteProductA1 : IAbstractProductA
    {
        public string UsefulFunctionA()
        {
            return "A1 - The result of the product A1";
        }
    }
}
