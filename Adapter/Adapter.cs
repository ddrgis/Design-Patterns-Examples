using System.Runtime.InteropServices;

namespace Adapter
{
    public class Adapter : Target
    {
        private readonly Adaptee adaptee;

        public Adapter(Adaptee adaptee)
        {
            this.adaptee = adaptee;
        }

        public override void Operation()
        {
            adaptee.SpecificOperation();
        }
    }
}