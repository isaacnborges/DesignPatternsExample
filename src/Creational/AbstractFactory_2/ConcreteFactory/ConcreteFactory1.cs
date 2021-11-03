using AbstractFactory_2.AbstractFactory;
using AbstractFactory_2.AbstractProducts;
using AbstractFactory_2.ConcreteProducts;

namespace AbstractFactory_2.ConcreteFactory
{
    public class ConcreteFactory1 : IAbstractFactory
    {
        public IAbstractProductA CreateProductA()
        {
            return new ConcreteProductA1();
        }

        public IAbstractProductB CreateProductB()
        {
            return new ConcreteProductB1();
        }
    }
}
