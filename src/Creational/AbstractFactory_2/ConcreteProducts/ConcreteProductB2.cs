using AbstractFactory_2.AbstractProducts;

namespace AbstractFactory_2.ConcreteProducts
{
    public class ConcreteProductB2 : IAbstractProductB
    {
        public string UsefulFunctionB()
        {
            return "B2 - The result of the product B2";
        }

        public string AnotherUsefulFunctionB(IAbstractProductA collaborator)
        {
            var result = collaborator.UsefulFunctionA();
            return $"B2 - The result of the B2 collaborating with the result ({result})";
        }
    }
}
