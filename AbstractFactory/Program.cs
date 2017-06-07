using System;

namespace AbstractFactory
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Some logic of factory choosing here...

            Console.WriteLine("Prodyct family №1:");
            var client = new Client(new Factory1());
            client.ToConsole();

            Console.WriteLine();

            Console.WriteLine("Prodyct family №2:");
            client = new Client(new Factory2());
            client.ToConsole();

            //Or without Clint class (Main() method is client of factories):

            //var factrory1 = new Factory1();
            //var productA = factrory1.CreateProductA();
            //var productB = factrory1.CreateProductB();
            //productA.ToConsole();
            //productB.ToConsole();

            //Console.WriteLine();

            //var factory2 = new Factory2();
            //productA = factory2.CreateProductA();
            //productB = factory2.CreateProductB();
            //productA.ToConsole();
            //productB.ToConsole();

            Console.ReadKey();
        }
    }
}