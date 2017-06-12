using System;

namespace Strategy
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Logic of strategy choosing can be here
            IStrategy strategy = new ConcreteStrategy1();
            var client = new Client(strategy);
            client.Execute();

            strategy = new ConcreteStrategy2();
            client = new Client(strategy);
            client.Execute();

            Console.ReadKey();
        }
    }
}