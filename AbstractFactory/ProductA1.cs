using System;

namespace AbstractFactory
{
    public class ProductA1 : AbstractProductA
    {
        public override void ToConsole()
        {
            Console.WriteLine("I'm ProductA from 1 family");
        }
    }
}