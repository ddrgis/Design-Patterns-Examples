using System;

namespace Strategy
{
    public class ConcreteStrategy1 : IStrategy
    {
        public void Operation()
        {
            Console.WriteLine("First strategy");
        }
    }
}