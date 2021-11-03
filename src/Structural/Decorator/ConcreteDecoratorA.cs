namespace Decorator
{
    public class ConcreteDecoratorA : Decorator
    {
        public ConcreteDecoratorA(Component component) : base(component)
        { }

        public override string Operation()
        {
            return $"ConcreteDecoratorA_({base.Operation()})";
        }
    }
}
