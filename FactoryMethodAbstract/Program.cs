using System;

namespace FactoryMethodAbstract
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var aProductFactory = new ConcreteFactoryA();
            Product product = aProductFactory.CreateProduct();
            product.SomeMethod();

            var bProductFactory = new ConcreteFactoryB();
            product = bProductFactory.CreateProduct();
            product.SomeMethod();

            Console.ReadKey();
        }
    }
}
