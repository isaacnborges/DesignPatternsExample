namespace Decorator
{
    public abstract class Decorator : Component
    {
        protected Component _component;

        public Decorator(Component component)
        {
            _component = component;
        }

        public void SetComponent(Component component)
        {
            _component = component;
        }

        public override string Operation()
        {
            if (_component == null)
            {
                return string.Empty;
            }

            return _component.Operation();
        }
    }
}
