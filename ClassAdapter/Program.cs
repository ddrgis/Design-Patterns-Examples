using System;

namespace ClassAdapter
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var adapter = new Adapter();
            adapter.Operation();

            Console.ReadKey();
        }
    }
}