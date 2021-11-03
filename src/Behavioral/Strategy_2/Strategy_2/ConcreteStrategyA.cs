namespace Strategy_2
{
    public class ConcreteStrategyA : IStrategy
    {
        public object DoAlgorithm(object data)
        {
            var list = data as List<int>;
            list.Sort();

            return list;
        }
    }
}
