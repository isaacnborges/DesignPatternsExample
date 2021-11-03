using AbstractFactory_2.AbstractProducts;

namespace AbstractFactory_2.ConcreteProducts
{
    public class ConcreteProductB1 : IAbstractProductB
    {
        public string UsefulFunctionB()
        {
            return "B1 - The result of the product B1";
        }

        public string AnotherUsefulFunctionB(IAbstractProductA collaborator)
        {
            var result = collaborator.UsefulFunctionA();
            return $"B1 - The result of the B1 collaborating with the result ({result})";
        }
    }
}
