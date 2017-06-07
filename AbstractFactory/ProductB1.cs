using System;

namespace AbstractFactory
{
    public class ProductB1 : AbstractProductB
    {
        public override void ToConsole()
        {
            Console.WriteLine("I'm ProductB from 1 family");
        }
    }
}