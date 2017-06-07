using System;

namespace AbstractFactory
{
    public abstract class AbstractProductA
    {
        public virtual void ToConsole()
        {
            Console.WriteLine("I'm abstract ProductA");
        }
    }
}