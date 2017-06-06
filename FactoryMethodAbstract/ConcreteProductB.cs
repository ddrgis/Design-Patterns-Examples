using System;

namespace FactoryMethodAbstract
{
    public class ConcreteProductB : Product
    {
        public override void SomeMethod()
        {
            Console.WriteLine("I'm Concrete Product B Implementation");
        }
    }
}