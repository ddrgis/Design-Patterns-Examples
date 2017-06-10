using System;

namespace Decorator
{
    public class ConcreteComponent : Component
    {
        public override void Operation()
        {
            Console.Write("I'm concrete component operation");
        }
    }
}