using System;

namespace Adapter
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var adapter = new Adapter(new Adaptee());
            adapter.Operation();

            Console.ReadKey();
        }
    }
}