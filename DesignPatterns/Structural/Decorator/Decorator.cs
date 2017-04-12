namespace DesignPatterns.Structural.Decorator
{
    public abstract class Decorator : Component
    {
        protected readonly Component component;

        protected Decorator(Component component)
        {
            this.component = component;
        }

        public override void Operation()
        {
            component?.Operation();
        }
    }
}