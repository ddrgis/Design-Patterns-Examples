using System;

namespace AbstractFactory
{
    public class ProductA2 : AbstractProductA
    {
        public override void ToConsole()
        {
            Console.WriteLine("I'm ProductA from 2 family");
        }
    }
}