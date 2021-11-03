namespace Builder
{
    public class ConcreteBuilder : IBuilder
    {
        private Product _product = new();

        public ConcreteBuilder()
        {
            Reset();
        }

        public void Reset()
        {
            _product = new Product();
        }

        public void BuildPartA()
        {
            _product.Add("Part_A");
        }

        public void BuildPartB()
        {
            _product.Add("Part_B");
        }

        public void BuildPartC()
        {
            _product.Add("Part_C");
        }

        public Product GetProduct()
        {
            var result = _product;

            Reset();

            return result;
        }
    }
}
