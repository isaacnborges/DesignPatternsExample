namespace Strategy_2
{
    public class Context
    {
        private IStrategy _strategy;

        public Context()
        { }

        public Context(IStrategy strategy)
        {
            _strategy = strategy;
        }

        public void SetStrategy(IStrategy strategy)
        {
            _strategy = strategy;
        }

        public void DoSomeBusinessLogic()
        {
            Console.WriteLine("Context: Sorting data using the strategy (not sure how it'll do it)");
            var result = _strategy.DoAlgorithm(new List<int> { 3, 1, 5, 2, 4 });

            string resultStr = string.Empty;
            foreach (var element in result as List<int>)
            {
                resultStr += element + "-";
            }

            resultStr = resultStr.Remove(resultStr.Length - 1); //removing last ","

            Console.WriteLine(resultStr);
        }
    }
}
