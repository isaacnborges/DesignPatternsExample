namespace Strategy_2
{
    public class ConcreteStrategyB : IStrategy
    {
        public object DoAlgorithm(object data)
        {
            var list = data as List<int>;
            list.Sort();
            list.Reverse();

            return list;
        }
    }
}
