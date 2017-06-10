using System;

namespace Facade
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var systemFacade = new Facede();
            Console.WriteLine("MethodA executing:");
            systemFacade.MethodA();

            Console.WriteLine();

            Console.WriteLine("MethodB executing:");
            systemFacade.MethodB();

            Console.ReadKey();
        }
    }
}