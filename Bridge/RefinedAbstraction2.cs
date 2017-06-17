using System;

namespace Bridge
{
    public class RefinedAbstraction2 : Abstraction
    {
        public RefinedAbstraction2(Implementation implementation) : base(implementation)
        {
        }

        public override void Operation()
        {
            Console.WriteLine("RefinedAbstraction2");
            base.Operation();
            Console.WriteLine();
        }
    }
}