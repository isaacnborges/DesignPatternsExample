using FactoryMethod_2.ConcreteProduct;
using FactoryMethod_2.Creator;
using FactoryMethod_2.Product;

namespace FactoryMethod_2.ConcreteCreator
{
    public class ConcreteCreator1 : AbstractCreator
    {
        public override IProduct FactoryMedhot()
        {
            return new ConcreteProduct1();
        }
    }
}
