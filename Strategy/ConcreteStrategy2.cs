using System;

namespace Strategy
{
    public class ConcreteStrategy2 : IStrategy
    {
        public void Operation()
        {
            Console.WriteLine("Second strategy");
        }
    }
}