using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            var component = new ConcreteComponent();
            component.Operation();
            Console.WriteLine();

            var changedComponent = new DecoratedComponent(component, "new state");
            changedComponent.Operation();

            Console.ReadKey();
        }
    }
}
