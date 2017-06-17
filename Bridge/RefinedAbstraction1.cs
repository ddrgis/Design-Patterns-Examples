using System;

namespace Bridge
{
    public class RefinedAbstraction1 : Abstraction
    {
        public RefinedAbstraction1(Implementation implementation) : base(implementation)
        {
        }

        public override void Operation()
        {
            Console.WriteLine("RefinedAbstraction1");
            base.Operation();
            Console.WriteLine();
        }
    }
}