using System;

namespace AbstractFactory
{
    public abstract class AbstractProductB
    {
        public virtual void ToConsole()
        {
            Console.WriteLine("I'm abstract ProductB");
        }
    }
}