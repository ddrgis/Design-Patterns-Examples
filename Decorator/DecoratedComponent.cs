using System;

namespace Decorator
{
    public class DecoratedComponent : Component
    {
        private readonly Component component;
        private readonly string decoratedState;
        public DecoratedComponent(Component component, string decoratedState)
        {
            this.component = component;
            this.decoratedState = decoratedState;
        }
        public override void Operation()
        {
            component.Operation();
            Console.Write(" with decorated behavior and decorated state");
        }
    }
}