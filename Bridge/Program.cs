using System;

namespace Bridge
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var abstraction1 = new RefinedAbstraction1(new ConcreteImplemention1());
            abstraction1.Operation();

            abstraction1 = new RefinedAbstraction1(new ConcreteImplemention2());
            abstraction1.Operation();

            var abstraction2 = new RefinedAbstraction2(new ConcreteImplemention1());
            abstraction2.Operation();

            abstraction2 = new RefinedAbstraction2(new ConcreteImplemention2());
            abstraction2.Operation();

            Console.ReadKey();
        }
    }
}