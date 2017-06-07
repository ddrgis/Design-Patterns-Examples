using System;

namespace AbstractFactory
{
    public class ProductB2 : AbstractProductB
    {
        public override void ToConsole()
        {
            Console.WriteLine("I'm ProductB from 2 family");
        }
    }
}