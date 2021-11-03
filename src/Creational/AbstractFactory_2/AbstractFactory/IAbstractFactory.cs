using AbstractFactory_2.AbstractProducts;

namespace AbstractFactory_2.AbstractFactory
{
    public interface IAbstractFactory
    {
        IAbstractProductA CreateProductA();
        IAbstractProductB CreateProductB();
    }
}
