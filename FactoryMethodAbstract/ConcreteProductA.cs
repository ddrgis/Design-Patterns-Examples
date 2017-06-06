using System;

namespace FactoryMethodAbstract
{
    public class ConcreteProductA : Product
    {
        public override void SomeMethod()
        {
            Console.WriteLine("I'm Concrete Product A Implementation");
        }
    }
}