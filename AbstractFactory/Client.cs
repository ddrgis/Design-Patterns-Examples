using System;

namespace AbstractFactory
{
    public class Client
    {
        private readonly AbstractProductA abstractProductA;
        private readonly AbstractProductB abstractProductB;

        public Client(AbstractFactory factory)
        {
            abstractProductA = factory.CreateProductA();
            abstractProductB = factory.CreateProductB();
        }

        public void ToConsole()
        {
            Console.Write("Product A: ");
            abstractProductA.ToConsole();
            Console.Write("Product B: ");
            abstractProductB.ToConsole();
        }
    }
}