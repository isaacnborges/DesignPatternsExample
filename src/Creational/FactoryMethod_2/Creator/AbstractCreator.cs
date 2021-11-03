using FactoryMethod_2.Product;

namespace FactoryMethod_2.Creator
{
    public abstract class AbstractCreator
    {
        public abstract IProduct FactoryMedhot();

        public string SomeOperation()
        {
            var product = FactoryMedhot();
            var result = $"Creator: The same creator's code has worked with {product.Operation()}";

            return result;
        }
    }
}
